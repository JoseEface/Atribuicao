using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao
{
    public class Turno
    {
        public int IdTurno { get; set; }
        public string NomeTurno { get; set; }

        public virtual ICollection <TurnoHorario> TurnoHorarios { get; set; }
    }
}