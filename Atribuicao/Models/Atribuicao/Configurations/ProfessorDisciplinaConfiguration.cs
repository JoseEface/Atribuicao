using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao.Configurations
{
    public class ProfessorDisciplinaConfiguration:EntityTypeConfiguration<ProfessorDisciplina>
    {
        public ProfessorDisciplinaConfiguration()
        {
            ToTable("ProfessorDisciplina");

            HasKey(p => new { p.idDisciplina, p.idProfessor });

            Property(p => p.idDisciplina).IsRequired().HasColumnName("idDisciplina");

            Property(p => p.idProfessor).IsRequired().HasColumnName("idProfessor");
        }
    }
}