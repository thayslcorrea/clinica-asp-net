﻿namespace ClinicaApp.Models
{
    public class ExameFisico
    {
        public int IdExameFisico { get; set; }
        public int? IdHoraPaciente_Profissional { get; set; }
        public int? SNC { get; set; }
        public int? AtividadeFisica { get; set; }
        public string TipoAtividadeFisica { get; set; }
        public int? Frequencia { get; set; }
        public int? HoraPreferido { get; set; }
        public int? Tempo { get; set; }
        public bool? FlgDenticaoCompleta { get; set; }
        public bool? FlgDenticaoIncompleta { get; set; }
        public bool? FlgDenticaoAusente { get; set; }
        public bool? FlgDenticaoProtese { get; set; }
        public int? Mastigacao { get; set; }
        public int? Peristalse { get; set; }
        public bool? Fumante { get; set; }
        public int? FrequenciaCardiaca { get; set; }
        public string PA { get; set; }
        public int? FrequenciaRespiratoria { get; set; }
        public int? Temperatura { get; set; }
        public int? Glicemia { get; set; }
        public int? Diurese { get; set; }
        public int? TipoDiurese { get; set; }
        public int? Evacuacao { get; set; }
        public int? TipoEvacuacao { get; set; }
        public int? Ingestao { get; set; }
        public int? Excrecao { get; set; }
        public bool? FlgXerostomia { get; set; }
        public bool? FlgSialorreia { get; set; }
        public bool? FlgUlcerasBucais { get; set; }
        public bool? FlgNauseas { get; set; }
        public bool? FlgVomitos { get; set; }
        public bool? FlgDisfagia { get; set; }
        public bool? FlgOdinofagia { get; set; }
        public bool? FlgFistula { get; set; }
        public bool? FlgOral { get; set; }
        public bool? FlgOralEnteral { get; set; }
        public bool? FlgEnteralExclusiva { get; set; }
        public bool? FlgEnteralParental { get; set; }
        public bool? FlgParentalExclusiva { get; set; }
        public bool? FlgParentalOral { get; set; }
        public int? TipoAcesso { get; set; }
        public bool? FlgGastrico { get; set; }
        public bool? FlgTranspilorica { get; set; }
        public bool? FlgDuodenal { get; set; }
        public bool? FlgHiperemia { get; set; }
        public bool? FlgSaidaSecrecao { get; set; }
        public bool? FlgPresencaFeridas { get; set; }
        public string Obs { get; set; }

        public virtual HoraPacienteProfissional HoraPacienteProfissional { get; set; }
    }
}
