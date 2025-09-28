﻿namespace ClinicaApp.Models
{
    public class HistoricoAlimentarNutricional
    {
        public int IdHistAlimentarNutricional { get; set; }
        public int IdPaciente { get; set; }
        public int? MotivacaoTratamento { get; set; }
        public int? ModismosAlimentares { get; set; }
        public bool? FlgIntoleanciaAlimentar { get; set; }
        public string DescIntoleranciaAlimentar { get; set; }
        public int? FaseObesidadePerdaPeso { get; set; }
        public bool? FlgPerdaGanhoPeso { get; set; }
        public int? PesoMax { get; set; }
        public int? PesoMaxIdade { get; set; }
        public int? PesoMin { get; set; }
        public int? PesoMinIdade { get; set; }
        public bool? FlgDietas { get; set; }
        public string DescDietas { get; set; }
        public bool? FlgMedicamentos { get; set; }
        public string DescMedicamentos { get; set; }
        public bool? FlgExercicios { get; set; }
        public string DescExercicios { get; set; }
        public bool? FlgOutros { get; set; }
        public string DescOutros { get; set; }
        public string Obs { get; set; }

        public virtual Paciente Paciente { get; set; }
    }
}