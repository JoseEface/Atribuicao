using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao.Configurations
{
    public class TelefoneConfiguration:EntityTypeConfiguration<Telefone>
    {
        public TelefoneConfiguration()
        {
            ToTable("telefone");
            HasKey(p => p.idFone);
            Property(p => p.idFone).IsRequired().HasColumnName("idFone");
            Property(p => p.numero).HasMaxLength(10).IsRequired().HasColumnName("numero");
            HasMany(p => p.EscolaTelefones).WithRequired(p => p.telefone).HasForeignKey(p => p.idTelefone);
        }
    }
}