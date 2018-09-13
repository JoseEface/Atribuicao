using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao
{
    public class Professor
    {
        public int idProfessor { get; set; }

        public float classificacao { get; set; }

        public int idEscolaSede { get; set; }

        public int idPessoa { get; set; }                

        public bool ativo { get; set; }


        public virtual Escola EscolaSede { get; set; }

        public virtual Pessoa Pessoa { get; set; }

        public virtual ICollection<ProfessorCategoria> ProfessorCategorias { get; set; }

        public virtual ICollection<ProfessorSituacao> ProfessorSituacaoes { get; set; }

        public virtual ICollection<ProfessorDisciplina> ProfessorDisciplinas { get; set; }
        
        public virtual ICollection<Atribui> ProfessorAtribuicoes { get; set; }
    }
}