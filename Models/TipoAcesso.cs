using System.Collections.Generic;

namespace ClinicaApp.Models
{
    public class TipoAcesso
    {
        public int IdTipoAcesso { get; set; }
        public string Nome { get; set; }
        public bool FlagAtivo { get; set; }

        public virtual ICollection<Profissional> Profissionais { get; set; }
    }
}
