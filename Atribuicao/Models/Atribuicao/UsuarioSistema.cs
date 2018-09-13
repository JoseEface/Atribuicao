using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao
{
    public class UsuarioSistema
    {
        public int idUsuarioSistema { get; set; }

        public string login { get; set; }

        public string senha { get; set; }

        public int userRole { get; set; }

        public bool ativo { get; set; }

        public int idPessoa { get; set; }      
        

        public virtual Pessoa Pessoa { get; set; }

        public virtual Papel Papel { get; set; }

        public virtual ICollection<Atribui> Atribuicoes { get; set; }
    }
}