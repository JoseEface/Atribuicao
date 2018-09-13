using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao.Configurations
{
    public class PapelConfiguration: EntityTypeConfiguration<Papel>
    {
        public PapelConfiguration()
        {
            ToTable("Papel");

            HasKey(p => p.idRole);

            Property(p => p.idRole).HasColumnName("idRole").IsRequired();

            Property(p => p.idEscola).HasColumnName("idEscola").IsOptional();

            Property(p => p.papelUsuario).IsRequired().HasColumnName("papelUsuario").HasMaxLength(20);

            HasMany(p => p.UsuarioSistemas).WithRequired(p => p.Papel).HasForeignKey(p => p.userRole);   
        }
    }
}