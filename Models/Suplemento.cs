using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaApp.Models
{
    public class Suplemento
    {
        [Key]
        public int IdSuplemento { get; set; }

        [Required]
        public int IdTipoQuantidade { get; set; } // você pode criar a model TipoQuantidade se precisar

        [Required]
        public int Tipo { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        public float DoseMinima { get; set; }

        [Required]
        public float DoseMaxima { get; set; }

        [Required]
        public float Carboidrato { get; set; }

        [Required]
        public float VitaminaA { get; set; }

        [Required]
        public float VitaminaB { get; set; }
    }
}
