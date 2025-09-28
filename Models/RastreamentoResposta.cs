namespace ClinicaApp.Models
{
    public class RastreamentoResposta
    {
        public int IdRastreamentoResposta { get; set; }
        public int IdPergunta { get; set; }
        public int VlrRespota { get; set; }
        public int IdParteCorpo { get; set; }
        public string Obs { get; set; }

        public virtual Pergunta Pergunta { get; set; }
        public virtual ICollection<RastreamentoMetabolico> Metabolicos { get; set; }
    }
}