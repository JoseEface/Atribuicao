using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao.Configurations
{
    public class CargaHorariaConfiguration:EntityTypeConfiguration<CargaHoraria>
    {
        public CargaHorariaConfiguration()
        {
            ToTable("CargaHoraria");

            HasKey(p => p.IdCargaHoraria);

            Property(p => p.IdCargaHoraria).IsRequired().HasColumnName("idCargaHoraria");

            Property(p => p.Valor).IsRequired().HasColumnName("valor");

            HasMany(p => p.ProfessorCategorias).WithRequired(p => p.CargaHoraria).HasForeignKey(p => p.cargaHoraria);
        }   
    }
}