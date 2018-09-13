using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao
{
    public class Telefone
    {
        public int idFone { get; set; }
        public string numero { get; set; }

        public virtual ICollection<EscolaTelefone> EscolaTelefones { get; set; }
    }
}