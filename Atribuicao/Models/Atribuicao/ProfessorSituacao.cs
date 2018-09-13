using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao
{
    public class ProfessorSituacao
    {
        public int idProfessor { get; set; }
        public int idSituacao { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataFim { get; set; }
        public DateTime dataCadastro { get; set; }
        public string observacoes { get; set; }

        public virtual Professor Professor { get; set; }
        public virtual Situacao Situacao { get; set; }
        public virtual ICollection<AulaVaga> AulasVagas { get; set; }

        public ProfessorSituacao()
        {
            dataCadastro = DateTime.Now;
        }
        
    }
}