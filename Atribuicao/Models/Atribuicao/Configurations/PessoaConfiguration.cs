using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao.Configurations
{
    public class PessoaConfiguration:EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfiguration()
        {
            ToTable("Pessoa");

            HasKey(p => p.IdPessoa);

            Property(p => p.IdPessoa).IsRequired().HasColumnName("idPessoa");

            Property(p => p.Nome).IsRequired().HasMaxLength(250).HasColumnName("nome");

            Property(p => p.Cpf).IsRequired().HasMaxLength(11).HasColumnName("cpf");

            Property(p => p.Rg).IsRequired().HasMaxLength(11).HasColumnName("rg");

            Property(p => p.Email).IsRequired().HasMaxLength(250).IsOptional().HasColumnName("email");

            Property(p => p.Telefone).HasMaxLength(15).IsRequired().HasColumnName("telefone");

            HasMany(p => p.UsuariosSistema).WithRequired(p => p.Pessoa).HasForeignKey(p => p.idPessoa);

            HasMany(p => p.Professores).WithRequired(p => p.Pessoa).HasForeignKey(p => p.idPessoa);
            
        }
    }
}