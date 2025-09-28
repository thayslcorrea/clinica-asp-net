using System.Collections.Generic;

namespace ClinicaApp.Models
{
    public class TipoProfissional
    {
        public int IdTipoProfissional { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Profissional> Profissionais { get; set; }
    }
}
