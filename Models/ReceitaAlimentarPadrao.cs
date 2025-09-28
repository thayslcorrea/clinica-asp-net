namespace ClinicaApp.Models
{
    public class ReceitaAlimentarPadrao
    {
        public int IdReceitaAlimentarPadrao { get; set; }
        public int? IdProfissional { get; set; }
        public string Nome { get; set; }
        public string InformacaoComplementar { get; set; }

        public virtual Profissional Profissional { get; set; }
        public virtual ICollection<ReceitaAlimentarPadraoXAlimento> Itens { get; set; }
    }
}