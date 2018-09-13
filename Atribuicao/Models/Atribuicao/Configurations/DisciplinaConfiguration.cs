using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao.Configurations
{
    public class DisciplinaConfiguration:EntityTypeConfiguration<Disciplina>
    {
        public DisciplinaConfiguration()
        {
            ToTable("Disciplina");

            HasKey(p => p.idDisciplina);

            Property(p => p.idDisciplina).IsRequired().HasColumnName("idDisciplina");

            Property(p => p.nomeDisciplina).IsRequired().HasColumnName("nomeDisciplina");

            HasMany(p => p.ProfessorDisciplinas).WithRequired(p => p.Disciplina).HasForeignKey(p => p.idDisciplina);
        }
    }
}