using System.ComponentModel.DataAnnotations;

namespace ClinicaApp.ViewModels
{
    // ViewModel para exibir e editar dados do profissional
    public class ProfissionalViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Digite um email válido.")]
        public string Email { get; set; }

        [Display(Name = "CPF")]
        public string CPF { get; set; } // Não editável

        [Display(Name = "Especialidade")]
        public string Especialidade { get; set; } // Medico / Nutricionista

        [Display(Name = "Plano")]
        public string Plano { get; set; } // Plano do profissional
    }
}
