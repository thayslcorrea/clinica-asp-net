namespace ClinicaApp.Models
{
    public class EscalaBristol
    {
        public int IdEscalaBristol { get; set; }
        public string Nome { get; set; }
        public bool? Sangue { get; set; }
    }

    public class EscalaBristolPacienteConsulta
    {
        public int IdEscalaBristol_Paciente_Consulta { get; set; }
        public int IdEscalaBristol { get; set; }
        public int IdPaciente { get; set; }
        public int IdHora_Paciente_Profissional { get; set; }

        public virtual EscalaBristol EscalaBristol { get; set; }
        public virtual Paciente Paciente { get; set; }
        public virtual HoraPacienteProfissional HoraPacienteProfissional { get; set; }
    }
}
