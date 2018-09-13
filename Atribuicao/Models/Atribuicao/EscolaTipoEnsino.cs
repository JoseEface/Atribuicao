using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao
{
    public class EscolaTipoEnsino
    {
        public int idEscola { get; set; }
        public int idTipoEnsino { get; set; }

        public virtual Escola Escola { get; set; }
        public virtual TipoEnsino TipoEnsino { get; set; }
    }
}