using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao.Configurations
{
    public class EscolaTipoEnsinoConfiguration:EntityTypeConfiguration<EscolaTipoEnsino>
    {
        public EscolaTipoEnsinoConfiguration()
        {
            ToTable("EscolaTipoEnsino");

            HasKey(p => new { p.idEscola, p.idTipoEnsino });

            Property(p => p.idEscola).IsRequired().HasColumnName("idEscola");

            Property(p => p.idEscola).IsRequired().HasColumnName("idTipoEnsino");
        }
    }
}