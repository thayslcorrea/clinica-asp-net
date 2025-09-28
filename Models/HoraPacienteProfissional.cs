using System;

namespace ClinicaApp.Models
{
    public class HoraPacienteProfissional
    {
        public int IdHoraPaciente_Profissional { get; set; }
        public int IdPaciente { get; set; }
        public int IdProfissional { get; set; }
        public DateTime? DataConsulta { get; set; }
        public TimeSpan HoraInicioIndividual { get; set; }
        public TimeSpan HoraFimIndividual { get; set; }
        public bool PrimeiraConsulta { get; set; }
        public bool Compareceu { get; set; }
        public string Motivo { get; set; }
        public string Resumo { get; set; }
        public decimal? Valor { get; set; }

        public virtual Paciente Paciente { get; set; }
        public virtual Profissional Profissional { get; set; }
    }
}