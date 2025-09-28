namespace ClinicaApp.Models
{
    public class RastreamentoMetabolico
    {
        public int IdRastreamentoMetabolico { get; set; }
        public int IdRastreamentoResposta { get; set; }
        public int IdHoraPaciente_Profissional { get; set; }
        public string ObsGeral { get; set; }
        public int? Total { get; set; }

        public virtual RastreamentoResposta RastreamentoResposta { get; set; }
        public virtual HoraPacienteProfissional HoraPacienteProfissional { get; set; }
    }
}