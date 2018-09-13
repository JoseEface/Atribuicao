using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao.Configurations
{
    public class SituacaoConfiguration:EntityTypeConfiguration<Situacao>
    {
        public SituacaoConfiguration()
        {
            ToTable("Situacao");

            HasKey(p => p.idSituacao);

            Property(p => p.idSituacao).IsRequired().HasColumnName("idSituacao");

            Property(p => p.situacao).IsRequired().HasMaxLength(45).HasColumnName("situacao");

            Property(p => p.impedeAtribuicao).IsRequired().HasColumnName("impedeAtribuicao");

            HasMany(p => p.ProfessorSituacoes).WithRequired(p => p.Situacao).HasForeignKey(p => p.idSituacao);
        }
    }
}