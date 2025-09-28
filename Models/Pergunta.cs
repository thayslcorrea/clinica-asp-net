namespace ClinicaApp.Models
{
    public class Pergunta
    {
        public int IdPergunta { get; set; }
        public int IdProfissional { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public virtual Profissional Profissional { get; set; }
        public virtual ICollection<RastreamentoResposta> Respostas { get; set; }
    }
}