using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backEnd_Lubee.Data
{
    public class DetalleContrato
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("ContratoId")]
        public int ContratoId { get; set; }
        public Contrato IdContrato { get; set; }


        [Required]
        [ForeignKey("ItemId")]
        public int ItemId { get; set; }
        public Producto IdProducto { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        [Required]
        public bool Enabled { get; set; }

        [Required]
        public bool Deleted { get; set; }

        [Required]
        [MaxLength(150)]
        public string CreateBy { get; set; } = string.Empty;

    }
}
