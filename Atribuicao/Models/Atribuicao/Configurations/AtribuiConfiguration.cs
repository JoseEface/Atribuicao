using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao.Configurations
{
    public class AtribuiConfiguration:EntityTypeConfiguration<Atribui>
    {
        public AtribuiConfiguration()
        {
            ToTable("Atribui");

            HasKey(p => new { p.IdAula, p.IdProfessorSubsituto, p.IdUsuarioSistema });

            HasIndex(p => p.IdAula).IsUnique();

            Property(p => p.IdAula).IsRequired().HasColumnName("idAula");

            Property(p => p.IdProfessorSubsituto).IsRequired().HasColumnName("idProfessorSubstituto");

            Property(p => p.IdUsuarioSistema).IsRequired().HasColumnName("idUsuarioSistema");

            Property(p => p.DataAtribuicao).IsRequired().HasColumnName("dataAtribuicao");
        }
    }
}