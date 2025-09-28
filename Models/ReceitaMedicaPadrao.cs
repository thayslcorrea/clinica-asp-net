namespace ClinicaApp.Models
{
    public class ReceitaMedicaPadrao
    {
        public int IdReceitaMedicaPadrao { get; set; }
        public int IdProfissional { get; set; }
        public string Nome { get; set; }
        public string InformacaoComplementar { get; set; }

        public virtual Profissional Profissional { get; set; }
    }
}