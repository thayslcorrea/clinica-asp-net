using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaApp.Models
{
    public class Paciente
    {
        public int IdPaciente { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string NomeResponsavel { get; set; }
        public char Sexo { get; set; }
        public int Etnia { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public int? IdCidade { get; set; }
        public string TelResidencial { get; set; }
        public string TelComercial { get; set; }
        public string TelCelular { get; set; }
        public string Profissao { get; set; }
        public bool? FlgAtleta { get; set; }
        public bool? FlgGestante { get; set; }

        // Relação com Cidade
        public virtual Cidade Cidade { get; set; }

        // FK para Profissional
        public int IdProfissional { get; set; }

        // Navegação para o Profissional (único)
        [ForeignKey("IdProfissional")]
        public Profissional Profissional { get; set; }


        // Relacionamentos com outras tabelas
        public virtual ICollection<HistoricoPatologico> HistoricosPatologicos { get; set; }
        public virtual ICollection<HoraPacienteProfissional> HorasPacienteProfissional { get; set; }
    }
}
