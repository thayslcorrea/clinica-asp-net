namespace ClinicaApp.Models
{
    public class MedicoPaciente
    {
        public int IdMedico_Paciente { get; set; }
        public int IdPaciente { get; set; }
        public int IdProfissional { get; set; }
        public string InformacaoResumida { get; set; }

        public virtual Paciente Paciente { get; set; }
        public virtual Profissional Profissional { get; set; }
    }
}
