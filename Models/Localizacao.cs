using System.Collections.Generic;

namespace ClinicaApp.Models
{
    public class Pais
    {
        public int IdPais { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<Estado> Estados { get; set; }
    }

    public class Estado
    {
        public int IdEstado { get; set; }
        public int IdPais { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }

        public virtual Pais Pais { get; set; }
        public virtual ICollection<Cidade> Cidades { get; set; }
    }

    public class Cidade
    {
        public int IdCidade { get; set; }
        public int? IdEstado { get; set; }
        public string Nome { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
        public virtual ICollection<Profissional> Profissionais { get; set; }
    }
}
