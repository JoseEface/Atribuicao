using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao.Configurations
{
    public class UsuarioSistemaConfiguration:EntityTypeConfiguration<UsuarioSistema>
    {
        public UsuarioSistemaConfiguration()
        {
            ToTable("UsuarioSistema");

            HasKey(p => p.idUsuarioSistema);

            Property(p => p.idUsuarioSistema).IsRequired().HasColumnName("idUsuarioSistema");

            Property(p => p.login).IsRequired().HasMaxLength(45).HasColumnName("login");

            Property(p => p.senha).IsRequired().HasMaxLength(64).HasColumnName("senha");

            Property(p => p.userRole).IsRequired().HasColumnName("userRole");

            Property(p => p.ativo).IsRequired().HasColumnName("ativo");

            Property(p => p.idPessoa).IsRequired().HasColumnName("idPessoa");

            HasMany(p => p.Atribuicoes).WithRequired(p => p.UsuarioSistema).HasForeignKey(p => p.IdUsuarioSistema);
        }
    }
}