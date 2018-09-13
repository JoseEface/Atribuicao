using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao.Configurations
{
    public class TurmaConfiguration:EntityTypeConfiguration<Turma>
    {
        public TurmaConfiguration()
        {
            ToTable("Turma");

            HasKey(p => p.idTurma);

            Property(p => p.idTurma).IsRequired().HasColumnName("idTurma");

            Property(p => p.idEscola).IsRequired().HasColumnName("idEscola");

            Property(p => p.idTipoEnsino).IsRequired().HasColumnName("idTipoEnsino");

            Property(p => p.serie).IsRequired().HasColumnName("serie").HasMaxLength(50);

        }
    }
}