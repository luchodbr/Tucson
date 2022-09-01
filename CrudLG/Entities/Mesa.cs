using System.ComponentModel.DataAnnotations;

namespace CrudLG.Entities
{
    public class Mesa
    {
        [Key]
        public int NroMesa { get; set; }
        public ETipoMesa TipoMesa { get; set; }
        public bool EstaLibre { get; set; }
        public enum ETipoMesa
        {
            Pareja=2,
            Familia=4,
            XL=6
        }
    }
}
