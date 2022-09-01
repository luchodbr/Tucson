using CrudLG.DTOs;
using CrudLG.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CrudLG.Services
{
    public interface ITucsonService
    {
        public Task<IEnumerable<ReservaDTO>> GetReservas();
        public Task<ReservaDTO> CreateReserva(ReservaDTO reserva);
        public Task<IEnumerable<EsperaDTO>> GetEsperas();
        public Task<IEnumerable<ClienteDTO>> GetClientes();
        public void DeleteReserva(int id );

    }
}
