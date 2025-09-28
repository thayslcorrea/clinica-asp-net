using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClinicaApp.Models
{
    public class GrupoReceitaDespesa
    {
        [Key]
        public int IdReceitaDespesa { get; set; }

        [Required]
        public int Tipo { get; set; } // Ex: 1 = Receita, 2 = Despesa

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        // Relacionamento com Lancamentos
        public ICollection<LancarReceitaDespesa> Lancamentos { get; set; }
    }
}
