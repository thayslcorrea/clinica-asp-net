using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaApp.Models
{
    public class Medicamento
    {
        [Key]
        public int IdMedicamento { get; set; }

        [Required]
        public int IdCategoriaMedicamento { get; set; }

        [ForeignKey("IdCategoriaMedicamento")]
        public CategoriaMedicamento Categoria { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        public string Bula { get; set; }

        public byte[] BulaArquivo { get; set; }
    }
}
