
using CrudLG.Entities;
using static CrudLG.Entities.Mesa;

namespace CrudLG.Context
{
    public class DataSeeder
    {
        private readonly TucsonContext _context;

        public DataSeeder(TucsonContext ctx)
        {
            this._context = ctx;
        }
        public  void Seed()
        {
            if(!_context.Mesa.Any())
            {
                GenerateFakeData();
            }
        }
        public  void GenerateFakeData()
        {
            List<Mesa> mesas = new();
            for (int i = 0; i < 17; i++)
            {
                mesas.Add(new Mesa() { TipoMesa = ETipoMesa.Pareja, EstaLibre=false });
            }
            mesas.Add(new Mesa() { TipoMesa = ETipoMesa.Pareja, EstaLibre = true });
            for (int i = 0; i < 14; i++)
            {
                mesas.Add(new Mesa() { TipoMesa = ETipoMesa.Familia, EstaLibre = false});
            }
            mesas.Add(new Mesa() { TipoMesa = ETipoMesa.Familia, EstaLibre = true });
            for (int i = 0; i < 6; i++)
            {
                mesas.Add(new Mesa() { TipoMesa = ETipoMesa.XL, EstaLibre = false });
            }
            mesas.Add(new Mesa() { TipoMesa = ETipoMesa.XL, EstaLibre = true });


            _context.Mesa.AddRange(mesas);
            List<Cliente> clientes = new();
            clientes.Add(new Cliente() { Categoria = ECategoria.Classic, Nombre = "Pedro" });
            clientes.Add(new Cliente() { Categoria = ECategoria.Gold, Nombre = "Predo" });
            clientes.Add(new Cliente() { Categoria = ECategoria.Platinum, Nombre = "Pdro" });
            clientes.Add(new Cliente() { Categoria = ECategoria.Diamond, Nombre = "Pero" });
            clientes.Add(new Cliente() { Categoria = ECategoria.Classic, Nombre = "dro" });
            clientes.Add(new Cliente() { Categoria = ECategoria.Gold, Nombre = "Pepe" });
            clientes.Add(new Cliente() { Categoria = ECategoria.Gold, Nombre = "Juan" });
            clientes.Add(new Cliente() { Categoria = ECategoria.Diamond, Nombre = "Tomas" });
            clientes.Add(new Cliente() { Categoria = ECategoria.Platinum, Nombre = "Lucho" });
            clientes.Add(new Cliente() { Categoria = ECategoria.Classic, Nombre = "Pedro" });
            clientes.Add(new Cliente() { Categoria = ECategoria.Gold, Nombre = "Predo" });
            clientes.Add(new Cliente() { Categoria = ECategoria.Platinum, Nombre = "Pdro" });
            clientes.Add(new Cliente() { Categoria = ECategoria.Diamond, Nombre = "Pero" });
            clientes.Add(new Cliente() { Categoria = ECategoria.Classic, Nombre = "dro" });
            clientes.Add(new Cliente() { Categoria = ECategoria.Gold, Nombre = "Pepe" });
            clientes.Add(new Cliente() { Categoria = ECategoria.Gold, Nombre = "Juan" });
            clientes.Add(new Cliente() { Categoria = ECategoria.Diamond, Nombre = "Tomas" });
            clientes.Add(new Cliente() { Categoria = ECategoria.Platinum, Nombre = "Lucho" });
            _context.Clientes.AddRange(clientes);
            List<Reserva> reservas = new();

            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 1, Fecha = "8/30/2022", NroMesa = 1, Turno = "noche", Cantidad = 2 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 2, Fecha = "8/30/2022", NroMesa = 2, Turno = "noche", Cantidad = 2 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 3, Fecha = "8/30/2022", NroMesa = 3, Turno = "noche", Cantidad = 2 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 4, Fecha = "8/30/2022", NroMesa = 4, Turno = "noche", Cantidad = 2 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 5, Fecha = "8/30/2022", NroMesa = 5, Turno = "noche", Cantidad = 2 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 6, Fecha = "8/30/2022", NroMesa = 6, Turno = "noche", Cantidad = 2 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 7, Fecha = "8/30/2022", NroMesa = 7, Turno = "noche", Cantidad = 2 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 8, Fecha = "8/30/2022", NroMesa = 8, Turno = "noche", Cantidad = 2 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 9, Fecha = "8/30/2022", NroMesa = 9, Turno = "noche", Cantidad = 2 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 10, Fecha = "8/30/2022", NroMesa = 10, Turno = "noche", Cantidad = 2 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 11, Fecha = "8/30/2022", NroMesa = 11, Turno = "noche", Cantidad = 2 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 12, Fecha = "8/30/2022", NroMesa = 12, Turno = "noche", Cantidad = 2 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 13, Fecha = "8/30/2022", NroMesa = 13, Turno = "noche", Cantidad = 2 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 14, Fecha = "8/30/2022", NroMesa = 14, Turno = "noche", Cantidad = 2 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 15, Fecha = "8/30/2022", NroMesa = 15, Turno = "noche", Cantidad = 2 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 16, Fecha = "8/30/2022", NroMesa = 16, Turno = "noche", Cantidad = 2 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 17, Fecha = "8/30/2022", NroMesa = 17, Turno = "noche", Cantidad = 2 });

            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 2, Fecha = "8/30/2022", NroMesa = 19, Turno = "noche", Cantidad = 4 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 3, Fecha = "8/30/2022", NroMesa = 20, Turno = "noche", Cantidad = 4 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 4, Fecha = "8/30/2022", NroMesa = 21, Turno = "noche", Cantidad = 4 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 5, Fecha = "8/30/2022", NroMesa = 22, Turno = "noche", Cantidad = 4 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 6, Fecha = "8/30/2022", NroMesa = 23, Turno = "noche", Cantidad = 4 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 7, Fecha = "8/30/2022", NroMesa = 24, Turno = "noche", Cantidad = 4 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 8, Fecha = "8/30/2022", NroMesa = 25, Turno = "noche", Cantidad = 4 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 9, Fecha = "8/30/2022", NroMesa = 26, Turno = "noche", Cantidad = 4 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 10, Fecha = "8/30/2022", NroMesa = 27, Turno = "noche", Cantidad = 4 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 11, Fecha = "8/30/2022", NroMesa = 28, Turno = "noche", Cantidad = 4 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 12, Fecha = "8/30/2022", NroMesa = 29, Turno = "noche", Cantidad = 4 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 13, Fecha = "8/30/2022", NroMesa = 30, Turno = "noche", Cantidad = 4 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 14, Fecha = "8/30/2022", NroMesa = 31, Turno = "noche", Cantidad = 4 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 1, Fecha = "8/30/2022", NroMesa = 32, Turno = "noche", Cantidad = 4 });

            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 1, Fecha = "8/30/2022", NroMesa = 34, Turno = "noche", Cantidad = 6 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 2, Fecha = "8/30/2022", NroMesa = 35, Turno = "noche", Cantidad = 6 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 3, Fecha = "8/30/2022", NroMesa = 36, Turno = "noche", Cantidad = 6 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 4, Fecha = "8/30/2022", NroMesa = 37, Turno = "noche", Cantidad = 6 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 5, Fecha = "8/30/2022", NroMesa = 38, Turno = "noche", Cantidad = 6 });
            reservas.Add(new Reserva() { Estado = Reserva.EEstados.EnCurso, NroCliente = 6, Fecha = "8/30/2022", NroMesa = 39, Turno = "noche", Cantidad = 6 });


            _context.Reservas.AddRange(reservas);



            _context.SaveChanges();
        }
    }
}
