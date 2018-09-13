using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao
{
    public class AulaVaga
    {
        public enum DiaSemana
        {
            segunda,
            terca,
            quarta,
            quinta,
            sexta,
            sabado
        }

        public int idAula { get; set; }
        public int idDisciplina { get; set; }
        public DiaSemana diaSemana { get; set; }
        public bool atpc { get; set; }
        public TimeSpan horarioInicio { get; set; }
        public TimeSpan horarioFim { get; set; }
        public int idTurma { get; set; }
        public int vagaCriadaPor { get; set; }
        
        public int idProfessor { get; set; }
        public int idSituacao { get; set; }

        public virtual Turma Turma { get; set; }
        public virtual Disciplina Disciplina { get; set; }
        public virtual UsuarioSistema UsuarioSistema { get; set; }
        public virtual ProfessorSituacao ProfessorSituacao {  get;set; }        
        public virtual ICollection<Atribui> Atribuicao { get; set; }
    }
}