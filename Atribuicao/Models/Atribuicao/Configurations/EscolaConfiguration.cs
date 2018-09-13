using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao.Configurations
{
    public class EscolaConfiguration:EntityTypeConfiguration<Escola>
    {
        public EscolaConfiguration()
        {
            ToTable("Escola");

            HasKey(p => p.idEscola);

            Property(p => p.idEscola).IsRequired().HasColumnName("idEscola");
            Property(p => p.endereco).IsRequired().HasMaxLength(450).HasColumnName("endereco");
            Property(p => p.nome).IsRequired().HasMaxLength(250).HasColumnName("nome");
            Property(p => p.cie).HasMaxLength(7).HasColumnName("CIE");
            Property(p => p.ua).HasMaxLength(5).HasColumnName("ua");
            Property(p => p.idCidade).HasColumnName("idCidade");
            
            HasMany(p => p.EscolaTelefones).WithRequired(p => p.escola).HasForeignKey(p => p.idEscola);
            HasMany(p => p.Turmas).WithRequired(p => p.Escola).HasForeignKey(p => p.idEscola);
            HasMany(p => p.EscolaTipoEnsinos).WithRequired(p => p.Escola).HasForeignKey(p => p.idEscola);
            HasMany(p => p.Papeis).WithOptional(p => p.Escola).HasForeignKey(p => p.idEscola);
            HasMany(p => p.Professores).WithRequired(p => p.EscolaSede).HasForeignKey(p => p.idEscolaSede);
        }
    }
}