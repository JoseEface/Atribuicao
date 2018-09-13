using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao
{
    public class Disciplina
    {
        public int idDisciplina { get; set; }
        public string nomeDisciplina { get; set; }        
        
        public virtual ICollection<ProfessorDisciplina> ProfessorDisciplinas { get; set; }
    }
}