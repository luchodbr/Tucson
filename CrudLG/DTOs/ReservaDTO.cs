using CrudLG.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CrudLG.DTOs
{
    public record class ReservaDTO
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int IdReserva { get; set; }
        public int NroCliente { get; set; }
        public string Fecha { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]

        public string? Turno { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] 
        public int NroMesa { get; set; }

        public int Cantidad { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? nombreCliente { get; set; }

        public static explicit operator ReservaDTO(Reserva entity)
        {
            return new ReservaDTO
            {
                IdReserva = entity.IdReserva,
                NroCliente = entity.NroCliente,
                Fecha = entity.Fecha,
                Turno = entity.Turno,
                NroMesa = entity.NroMesa,
                Cantidad = entity.Cantidad,
            };
        }


    }

}
