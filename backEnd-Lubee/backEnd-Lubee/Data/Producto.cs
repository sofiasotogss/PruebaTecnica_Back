using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backEnd_Lubee.Data
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)] 
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(18,2)")]  
        public decimal Precio { get; set; }
    }
}
