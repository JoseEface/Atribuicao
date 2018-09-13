using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao
{
    public class TipoEnsino
    {
        public int idTipoEnsino { get; set; }
        public string ensino { get; set; }

        public virtual ICollection<Turma> Turmas { get; set; }
        public virtual ICollection<EscolaTipoEnsino> EscolaTipoEnsinos { get; set; }        
    }
}