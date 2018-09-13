using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao
{
    public class EscolaTelefone
    {
        public int idEscola { get; set; }
        public int idTelefone { get; set; }

        public virtual Escola escola { get; set; }
        public virtual Telefone telefone { get; set; }
    }
}