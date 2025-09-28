using System;

namespace ClinicaApp.Models
{
    public class Contrato
    {
        public int IdContrato { get; set; }
        public int IdPlano { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }

        public virtual Plano Plano { get; set; }
        public virtual ICollection<Profissional> Profissionais { get; set; }
    }
}
