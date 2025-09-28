namespace ClinicaApp.Models
{
    public class ReceitaAlimentarPadraoXAlimento
    {
        public int IdReceitaAlimentarPadrao_X_Alimento_X_QuantidadeAlimento { get; set; }
        public int IdReceitaAlimentarPadrao { get; set; }
        public int IdAlimento { get; set; }
        public int IdQuantidadeAlimento { get; set; }
        public string Periodicidade { get; set; }
        public string QuantoTempo { get; set; }

        public virtual ReceitaAlimentarPadrao ReceitaAlimentarPadrao { get; set; }
        public virtual Alimento Alimento { get; set; }
    }
}