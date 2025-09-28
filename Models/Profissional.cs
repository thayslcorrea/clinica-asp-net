using System.Collections.Generic;

namespace ClinicaApp.Models
{
    public class Profissional
    {
        public int IdProfissional { get; set; }
        public int? IdTipoProfissional { get; set; }
        public int IdContrato { get; set; }
        public int? IdTipoAcesso { get; set; }
        public int IdCidade { get; set; }
        public string IdUser { get; set; } // FK para ApplicationUser
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string CRM_CRN { get; set; }
        public string Especialidade { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string DDD1 { get; set; }
        public string DDD2 { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public decimal? Salario { get; set; }

        // Relações
        public virtual Cidade CidadeNavigation { get; set; }
        public virtual Contrato Contrato { get; set; }
        public virtual TipoProfissional TipoProfissional { get; set; }
        public virtual TipoAcesso TipoAcesso { get; set; }
        public virtual ApplicationUser Usuario { get; set; }

        public ICollection<Paciente> Pacientes { get; set; }

        public virtual ICollection<Pergunta> Perguntas { get; set; }
        public virtual ICollection<ReceitaAlimentarPadrao> ReceitasAlimentaresPadrao { get; set; }
        public virtual ICollection<ReceitaMedicaPadrao> ReceitasMedicasPadrao { get; set; }
    }
}
