using System.Collections.Generic;

namespace ClinicaApp.Models
{
    public class Plano
    {
        public int IdPlano { get; set; }
        public string Nome { get; set; }
        public int Validade { get; set; } // dias ou meses, conforme definido
        public decimal Valor { get; set; }

        public virtual ICollection<Contrato> Contratos { get; set; }
    }
}
