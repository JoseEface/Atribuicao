using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao
{
    public class Situacao
    {
        public int idSituacao { get; set; }
        public string situacao { get; set; }
        public bool impedeAtribuicao { get; set; }

        public virtual ICollection<ProfessorSituacao> ProfessorSituacoes { get; set;  }
    }
}