using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao.Configurations
{
    public class AulaVagaConfiguration:EntityTypeConfiguration<AulaVaga>
    {
        public AulaVagaConfiguration()
        {
            ToTable("AulaVaga");

            HasKey(p => p.idAula);

            Property(p => p.idAula).IsRequired().HasColumnName("idAula");

            Property(p => p.idDisciplina).IsRequired().HasColumnName("idDisciplina");

            Property(p => p.diaSemana).IsRequired().HasColumnName("diaSemana");

            Property(p => p.atpc).IsRequired().HasColumnName("atpc");

            Property(p => p.horarioInicio).IsRequired().HasColumnName("horarioInicio");

            Property(p => p.horarioFim).IsRequired().HasColumnName("horarioFim");

            Property(p => p.idTurma).IsRequired().HasColumnName("idTurma");

            Property(p => p.vagaCriadaPor).IsRequired().HasColumnName("vagaCriadaPor");

            Property(p => p.idProfessor).IsRequired().HasColumnName("idProfessor");

            Property(p => p.idSituacao).IsRequired().HasColumnName("idSituacao");
        }
    }
}