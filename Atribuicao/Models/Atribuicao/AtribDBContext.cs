using Atribuicao.Models.Atribuicao.Configurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao
{
    public class AtribDBContext:DbContext
    {

        public DbSet<Estado> Estado { get; set; }

        public AtribDBContext():base("AtribuicaoDBContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new AtribuiConfiguration());
            modelBuilder.Configurations.Add(new AulaVagaConfiguration());
            modelBuilder.Configurations.Add(new CategoriaConfiguration());
            modelBuilder.Configurations.Add(new CidadeConfiguration());
            modelBuilder.Configurations.Add(new DisciplinaConfiguration());
            modelBuilder.Configurations.Add(new EscolaConfiguration());
            modelBuilder.Configurations.Add(new EscolaTelefoneConfiguration());
            modelBuilder.Configurations.Add(new EscolaTipoEnsinoConfiguration());
            modelBuilder.Configurations.Add(new EstadoConfiguration());
            modelBuilder.Configurations.Add(new PapelConfiguration());
            modelBuilder.Configurations.Add(new PessoaConfiguration());
            modelBuilder.Configurations.Add(new ProfessorConfiguration());
            modelBuilder.Configurations.Add(new ProfessorCategoriaConfiguration());
            modelBuilder.Configurations.Add(new ProfessorDisciplinaConfiguration());
            modelBuilder.Configurations.Add(new ProfessorSituacaoConfiguration());
            modelBuilder.Configurations.Add(new SituacaoConfiguration());
            modelBuilder.Configurations.Add(new TelefoneConfiguration());
            modelBuilder.Configurations.Add(new TipoEnsinoConfiguration());
            modelBuilder.Configurations.Add(new TurmaConfiguration());
            modelBuilder.Configurations.Add(new UsuarioSistemaConfiguration());
        }
    }
}