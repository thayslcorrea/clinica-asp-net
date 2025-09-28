using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ClinicaApp.Models;

namespace ClinicaApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Identity já cuida de usuários e roles
        // public DbSet<IdentityUser> Users => Set<IdentityUser>();
        // public DbSet<IdentityRole> Roles => Set<IdentityRole>();

        // Tabelas principais do sistema
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Profissional> Profissionais { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<TipoProfissional> TiposProfissional { get; set; }
        public DbSet<TipoAcesso> TiposAcesso { get; set; }

        // Localização
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }

        // Históricos
        public DbSet<HistoricoPatologico> HistoricoPatologico { get; set; }
        public DbSet<HistoricoAlimentarNutricional> HistoricosAlimentares { get; set; }
        public DbSet<HistoricoDoencaAtual> HistoricosDoencaAtual { get; set; }
        public DbSet<HistoricoSocialAlimentar> HistoricosSociais { get; set; }

        // Consultas e agendamentos
        public DbSet<HoraPacienteProfissional> HorasPacienteProfissional { get; set; }
        public DbSet<MedicoPaciente> MedicosPacientes { get; set; }

        // Perguntas e rastreamento
        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<RastreamentoResposta> RastreamentoRespostas { get; set; }
        public DbSet<RastreamentoMetabolico> RastreamentoMetabolicos { get; set; }

        // Receitas
        public DbSet<ReceitaAlimentarPadrao> ReceitasAlimentaresPadrao { get; set; }
        public DbSet<ReceitaMedicaPadrao> ReceitasMedicasPadrao { get; set; }

        // Antropometria e Escala Bristol
        public DbSet<Antropometria> Antropometrias { get; set; }
        public DbSet<EscalaBristol> EscalasBristol { get; set; }
        public DbSet<EscalaBristolPacienteConsulta> EscalasBristolPacienteConsulta { get; set; }

        // Exame Físico
        public DbSet<ExameFisico> ExamesFisicos { get; set; }
        public DbSet<Exame> Exames { get; set; }

        // Alimentação e medicamentos
        public DbSet<Alimento> Alimentos { get; set; }
        public DbSet<CategoriaMedicamento> CategoriasMedicamento { get; set; }

        // Patologias
        public DbSet<GrupoPatologico> GruposPatologicos { get; set; }

        // Medicamentos, Suplementos e Substancias
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Substancia> Substancias { get; set; }
        public DbSet<Suplemento> Suplementos { get; set; }

        // Planos, contratos, receitas e despesas
        public DbSet<Plano> Planos { get; set; }
        public DbSet<GrupoReceitaDespesa> GruposReceitasDespesas { get; set; }
        public DbSet<LancarReceitaDespesa> LancarReceitasDespesas { get; set; }

        // Configuração extra (opcional)
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configurações adicionais de chave composta ou relacionamento podem ir aqui
        }
    }
}
