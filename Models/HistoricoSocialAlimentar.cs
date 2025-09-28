﻿namespace ClinicaApp.Models
{
    public class HistoricoSocialAlimentar
    {
        public int IdHistSocialAlimentar { get; set; }
        public int IdPaciente { get; set; }
        public string Profissao { get; set; }
        public int? CargaHoraria { get; set; }
        public int? NroPessoasRes { get; set; }
        public decimal? RendaFamiliar { get; set; }
        public string Escolaridade { get; set; }
        public string EstadoCivil { get; set; }
        public string NomeCompraAlimento { get; set; }
        public string NomeCozinhaAlimento { get; set; }
        public int? CompraFeita { get; set; }
        public string NomeRealizaRefeicao { get; set; }
        public bool? FlgTabagismo { get; set; }
        public int? QtdTabagismoDia { get; set; }
        public bool? FlgEtilismo { get; set; }
        public int? QtdEtilismoDia { get; set; }
        public bool? FlgCafe { get; set; }
        public int? QtdCafeDia { get; set; }
        public bool? FlgPaiMaeHas { get; set; }
        public bool? FlgAvosHas { get; set; }
        public bool? FlgIrmaosHas { get; set; }
        public bool? FlgPaiMaeDiabetes { get; set; }
        public bool? FlgAvosDiabetes { get; set; }
        public bool? FlgIrmaosDiabetes { get; set; }
        public bool? FlgPaiMaeCancer { get; set; }
        public bool? FlgAvosCancer { get; set; }
        public bool? FlgIrmaosCancer { get; set; }
        public bool? FlgPaiMaeObesidade { get; set; }
        public bool? FlgAvosObesidade { get; set; }
        public bool? FlgIrmaosObesidade { get; set; }

        public virtual Paciente Paciente { get; set; }
    }
}