using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao
{
    public class ProfessorDisciplina
    {
        public int idDisciplina { get; set; }
        public int idProfessor { get; set; }

        public virtual Disciplina Disciplina {  get; set; }
        public virtual Professor Professor { get; set; }
    }
}