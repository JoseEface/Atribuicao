using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao.Configurations
{
    public class ProfessorConfiguration:EntityTypeConfiguration<Professor>
    {
        public ProfessorConfiguration()
        {
            ToTable("Professor");

            HasKey(p => p.idProfessor);

            Property(p => p.idProfessor).IsRequired().HasColumnName("idProfessor");

            Property(p => p.classificacao).HasColumnName("classificacao").IsRequired();

            Property(p => p.idEscolaSede).HasColumnName("sede").IsRequired();

            Property(p => p.idPessoa).HasColumnName("idPessoa").IsRequired();

            Property(p => p.ativo).IsRequired().HasColumnName("ativo");

            HasIndex(p => p.idPessoa).IsUnique();


            HasMany(p => p.ProfessorSituacaoes).WithRequired(p => p.Professor).HasForeignKey(p => p.idProfessor);

            HasMany(p => p.ProfessorCategorias).WithRequired(p => p.Professor).HasForeignKey(p => p.idProfessor);

            HasMany(p => p.ProfessorAtribuicoes).WithRequired(p => p.Professor).HasForeignKey(p => p.IdProfessorSubsituto);

            HasMany(p => p.ProfessorDisciplinas).WithRequired(p => p.Professor).HasForeignKey(p => p.idProfessor);
            
        }
    }
}