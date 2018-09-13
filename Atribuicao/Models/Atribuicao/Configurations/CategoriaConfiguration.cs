using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao.Configurations
{
    public class CategoriaConfiguration:EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfiguration()
        {
            ToTable("categoria");

            HasKey(p => p.idCategoria);

            Property(p => p.idCategoria).IsRequired().HasColumnName("idCategoria");

            Property(p => p.letraCategoria).IsRequired().HasMaxLength(10).HasColumnName("letraCategoria");

            HasMany(p => p.ProfessorCategorias).WithRequired(p => p.Categoria).HasForeignKey(p => p.idCategoria);

        }
    }
}