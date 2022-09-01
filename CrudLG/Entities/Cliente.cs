using CrudLG.DTOs;
using System.ComponentModel.DataAnnotations;

namespace CrudLG.Entities
{
    public class Cliente
    {
        [Key]
        public int NroCliente { get; set; }
        public string Nombre { get; set; }
        public ECategoria Categoria { get; set; }
        
        public static implicit operator Cliente(ClienteDTO entity)
        {
            return new Cliente
            {
                NroCliente = entity.NroCliente,
                Nombre = entity.Nombre,
                Categoria = entity.Categoria
            };
        }

    }
    public enum ECategoria
    {
        Classic= 2,
        Gold = 3,
        Platinum = 4,
        Diamond=0
    }
}
