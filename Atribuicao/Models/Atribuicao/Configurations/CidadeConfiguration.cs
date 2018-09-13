using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao.Configurations
{
    public class CidadeConfiguration:EntityTypeConfiguration<Cidade>
    {
        public CidadeConfiguration()
        {
            ToTable("Cidade");

            HasKey(p => p.idCidade);

            Property(p => p.idCidade).IsRequired().HasColumnName("idCidade");

            Property(p => p.nomeCidade).HasMaxLength(150).IsRequired().HasColumnName("nomeCidade");

            Property(p => p.idCidade).IsRequired().HasColumnName("idEstado");            

            HasMany(p => p.Escolas).WithRequired(p => p.cidade).HasForeignKey(p => p.idCidade);
        }
    }
}