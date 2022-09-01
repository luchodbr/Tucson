using CrudLG.DTOs;
using System.ComponentModel.DataAnnotations;

namespace CrudLG.Entities
{
    public class Reserva
    {
        [Key]
        public int IdReserva { get; set; }
        public int NroCliente { get; set; }
        public string Fecha { get; set; }

        public string Turno { get; set; }

        public int NroMesa { get; set; }
        public int Cantidad { get; set; }
        public  EEstados Estado { get; set; }
        

        public static implicit operator Reserva(ReservaDTO entity)
        {
            return new Reserva
            {
                IdReserva = entity.IdReserva,
                NroCliente = entity.NroCliente,
                Fecha = entity.Fecha,
                Turno = entity.Turno,
                NroMesa = entity.NroMesa,
                Cantidad=entity.Cantidad
            };
        }
        public enum EEstados
        {
            EnCurso,
            EnEspera,
            Cancelado
        }
    }

}
