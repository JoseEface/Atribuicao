using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao.Configurations
{
    public class ProfessorCategoriaConfiguration:EntityTypeConfiguration<ProfessorCategoria>
    {
        public ProfessorCategoriaConfiguration()
        {
            ToTable("ProfessorCategoria");

            HasKey(p => new { p.idCategoria, p.idProfessor });

            Property(p => p.idCategoria).HasColumnName("idCategoria").IsRequired();

            Property(p => p.idProfessor).HasColumnName("idProfessor").IsRequired();

            Property(p => p.inicioContrato).HasColumnName("inicioContrato");

            Property(p => p.fimContrato).HasColumnName("fimContrato");
        }
    }
}