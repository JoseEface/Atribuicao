using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao.Configurations
{
    public class TipoEnsinoConfiguration:EntityTypeConfiguration<TipoEnsino>
    {
        public TipoEnsinoConfiguration()
        {
            ToTable("TipoEnsino");
            HasKey(p => p.idTipoEnsino);

            Property(p => p.idTipoEnsino).IsRequired().HasColumnName("idTipoEnsino");
            Property(p => p.ensino).IsRequired().HasMaxLength(100).HasColumnName("ensino");

            HasMany(p => p.Turmas).WithRequired(p => p.TipoEnsino).HasForeignKey(p => p.idTipoEnsino);
            HasMany(p => p.EscolaTipoEnsinos).WithRequired(p => p.TipoEnsino).HasForeignKey(p => p.idTipoEnsino);
        }
    }
}