using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao
{
    public class Turma
    {
        public int idTurma { get; set; }

        public string serie { get; set; }

        public int idEscola { get; set; }

        public int idTipoEnsino { get; set; }

        public int idTurno { get; set; }

        public virtual Turno Turno { get; set; }

        public virtual Escola Escola { get; set; }

        public virtual TipoEnsino TipoEnsino { get; set; }      
        
        public virtual ICollection<AulaVaga> AulasVagas { get; set; }        
    }
}