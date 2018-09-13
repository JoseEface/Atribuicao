using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }

        public string Cpf { get; set; }

        public string Rg { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public virtual ICollection<UsuarioSistema> UsuariosSistema { get; set; }

        public virtual ICollection<Professor> Professores { get; set; }
    }
}