using CrudLG.Entities;

namespace CrudLG.DTOs
{
    public class ClienteDTO
    {
        public int NroCliente { get; set; }
        public string Nombre { get; set; }
        public ECategoria Categoria { get; set; }

        public static explicit operator ClienteDTO(Cliente entity)
        {
            return new ClienteDTO
            {
                NroCliente = entity.NroCliente,
                Nombre = entity.Nombre,
                Categoria = entity.Categoria
               
            };
        }
    }
}
