using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao
{
    public class Cidade
    {
        public int idCidade { get; set; }

        public string nomeCidade { get; set; }

        public int idEstado { get; set; }

        public virtual Estado Estado { get; set; }

        public virtual ICollection<Escola> Escolas { get; set; }
    }
}