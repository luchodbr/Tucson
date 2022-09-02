using CrudLG.DTOs;
using CrudLG.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using static CrudLG.Entities.Mesa;

namespace CrudLG.Services
{
    public class TucsonService : ITucsonService
    {
        private readonly TucsonContext _context;
        public TucsonService(TucsonContext context)
        {
            _context = context;
        }

        public async Task<ReservaDTO> CreateReserva(ReservaDTO reserva)
        {
            Reserva reservadb = reserva;

            var query = from m in _context.Mesa
                        where m.EstaLibre == true && (int)m.TipoMesa == reserva.Cantidad
                        select m.NroMesa != 0 ? m.NroMesa : 0;
                         

            int nroMesa = query.FirstOrDefault();
            reservadb.Turno = "noche";
            if (nroMesa > 0)
            {
                reservadb.NroMesa = nroMesa;
                var mesa = _context.Mesa.Find(nroMesa);
                mesa.EstaLibre = false;
                _context.Mesa.Update(mesa);
                _context.Reservas.Add(reservadb);
            }
            else
            {
                reservadb.Turno = "noche";
                reservadb.Estado = Reserva.EEstados.EnEspera;
                _context.Reservas.Add(reservadb);
            }
                await _context.SaveChangesAsync();
            return (ReservaDTO)reservadb;

        }
        public async void DeleteReserva(int id)
        {
            try
            {
                var reserva = _context.Reservas.Find(id);
                if (reserva == null)
                {
                    throw new Exception("not found");

                }
                else
                {
                    reserva.Estado = Reserva.EEstados.Cancelado;
                    var mesa = _context.Mesa.Find(reserva.NroMesa);
                    mesa.EstaLibre = true;
                  
                    _context.Reservas.Update(reserva);
                    var espera = _context.Reservas.Where(r => r.Estado == Reserva.EEstados.EnEspera && r.Cantidad == reserva.Cantidad).FirstOrDefault();
                    if (espera != null)
                    {

                        espera.Estado = Reserva.EEstados.EnCurso;
                        espera.NroMesa = reserva.NroMesa;
                        _context.Reservas.Update(espera);
                    }
                    else
                    {
                        _context.Mesa.Update(mesa);
                    }
                    
                    _context.SaveChanges();
                }


            }
            catch (Exception)
            {

                throw;
            }


        }


        public async Task<IEnumerable<ReservaDTO>> GetReservas()
        {
            try
            {
                var nombrePepe = "";
                return await _context.Reservas.Join(_context.Clientes, cliente => cliente.NroCliente, reserva => reserva.NroCliente, (reserva,cliente)=>new {Reserva = reserva,Cliente = cliente}).Where(reservaClientes => reservaClientes.Reserva.Estado == Reserva.EEstados.EnCurso)
                    .Select(v => new ReservaDTO{
                    nombreCliente = v.Cliente.Nombre,
                    NroMesa=v.Reserva.NroMesa,
                        Cantidad = v.Reserva.Cantidad,
                        NroCliente = v.Reserva.NroCliente,
                        Fecha = v.Reserva.Fecha,
                        IdReserva = v.Reserva.IdReserva,
                        Turno = v.Reserva.Turno

                    }).ToListAsync();

            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public async Task<IEnumerable<ClienteDTO>> GetClientes()
        {
            return await _context.Clientes.Select(c => (ClienteDTO)c).ToListAsync();
        }
        public async Task<IEnumerable<EsperaDTO>> GetEsperas()
        {

            var query = from r in _context.Reservas
                        join c in _context.Clientes on r.NroCliente equals c.NroCliente
                        where r.Estado == Reserva.EEstados.EnEspera
                        select new EsperaDTO
                        {
                            NroCliente = c.NroCliente,
                            Nombre = c.Nombre,
                            Cantidad = r.Cantidad,
                            Fecha = r.Fecha
                        };
            return query.ToList();
            //var esperas = await _context.Reservas.Where(reserva => reserva.Estado == Reserva.Eestados.EnEspera).Select(v =>
            //    new EsperaDTO() { NroCliente = v.NroCliente, Nombre = "", Cantidad = 1, Fecha = v.Fecha }
            //).ToListAsync();


            //return esperas;
        }


    }
}
