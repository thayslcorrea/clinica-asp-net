using System.ComponentModel.DataAnnotations;

namespace ClinicaApp.Models
{
    public class Substancia
    {
        [Key]
        public int IdSubstancia { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(5000)]
        public string InformacaoComplementar { get; set; }
    }
}
