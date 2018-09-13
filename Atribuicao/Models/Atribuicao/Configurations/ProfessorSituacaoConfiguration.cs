using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao.Configurations
{
    public class ProfessorSituacaoConfiguration:EntityTypeConfiguration<ProfessorSituacao>
    {
        public ProfessorSituacaoConfiguration()
        {
            ToTable("ProfessorSituacao");

            HasKey(p => new { p.idProfessor, p.idSituacao });            

            Property(p => p.idProfessor).IsRequired().HasColumnName("idProfessor");

            Property(p => p.idSituacao).IsRequired().HasColumnName("idSituacao");

            Property(p => p.dataInicio).IsRequired().HasColumnName("dataInicio");

            Property(p => p.dataFim).IsOptional().HasColumnName("dataFim");

            Property(p => p.dataCadastro).IsRequired().HasColumnName("dataCadastro");

            HasMany(p => p.AulasVagas).WithRequired(p => p.ProfessorSituacao).HasForeignKey(p => new { p.idProfessor, p.idSituacao });
           
        }
    }
}