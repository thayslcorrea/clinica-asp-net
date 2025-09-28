using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaApp.Models
{
    public class LancarReceitaDespesa
    {
        [Key]
        public int IdLancamento { get; set; }

        [Required]
        public int IdReceitaDespesa { get; set; }

        [ForeignKey("IdReceitaDespesa")]
        public GrupoReceitaDespesa GrupoReceitaDespesa { get; set; }

        [Required]
        public DateTime Data { get; set; }
    }
}
