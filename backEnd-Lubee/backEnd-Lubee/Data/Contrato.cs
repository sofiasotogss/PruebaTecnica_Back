using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backEnd_Lubee.Data
{
    [Table("Contrato")]
    public class Contrato
    {
        [Key]
        public int Id { get; set; }
        [Required] 
        [RegularExpression("^[A-Z]{3}[0-9]{3}$", ErrorMessage = "CourseCode debe tener el formato AAA999")]
        [MaxLength(6)]
        public string CourseCode { get; set; }
        [Required]
        public DateTime FechaAlta { get; set; }
        [Required]
        public bool Estado { get; set; }
        [Required]
        public int CantidadEgresados { get; set; }
        [Required]
        public DateTime FechaEntrega { get; set; }
        [MaxLength(150)]
        public string MedioEntrega { get; set; }
        [MaxLength(150)]
        public string Vendedor { get; set; }
        [Required]
        [MaxLength(50)]
        public string ColegioNivel { get; set; }
        [Required]
        [MaxLength(250)]
        public string ColegioNombre { get; set; }
        [Required]
        [MaxLength(10)]
        public string ColegioCurso { get; set; }
        [Required]
        [MaxLength(250)]
        public string ColegioLocalidad { get; set; }
        public int Comision { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }
    }
}
