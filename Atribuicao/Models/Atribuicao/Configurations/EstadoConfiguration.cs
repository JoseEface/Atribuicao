using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao.Configurations
{
    public class EstadoConfiguration:EntityTypeConfiguration<Estado>
    {

        public EstadoConfiguration()
        {
            ToTable("Estado");

            HasKey(p => p.idEstado);

            Property(p => p.idEstado).IsRequired().HasColumnName("idEstado");

            Property(p => p.nome).IsRequired().HasMaxLength(22).HasColumnName("nome");

            Property(p => p.sigla).IsRequired().HasMaxLength(2).HasColumnName("sigla");

            HasMany(p => p.Cidade).WithRequired(c => c.Estado).HasForeignKey(p => p.idEstado);

        }
    }
}