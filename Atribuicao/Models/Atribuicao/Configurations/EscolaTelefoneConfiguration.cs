using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao.Configurations
{
    public class EscolaTelefoneConfiguration:EntityTypeConfiguration<EscolaTelefone>
    {
        public EscolaTelefoneConfiguration()
        {
            ToTable("EscolaTelefone");

            HasKey(p => new { p.idEscola, p.idTelefone});

            Property(p => p.idTelefone).IsRequired().HasColumnName("idTelefone");
            Property(p => p.idEscola).IsRequired().HasColumnName("idEscola");
        }
    }
}