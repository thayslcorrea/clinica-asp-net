using System;
using System.ComponentModel.DataAnnotations;

namespace ClinicaApp.ViewModels
{
    // ViewModel para cadastro, edição e listagem de pacientes
    public class PacienteViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório.")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo Profissional responsável é obrigatório.")]
        [Display(Name = "Profissional Responsável")]
        public int ProfissionalId { get; set; } // FK para o profissional
    }
}
