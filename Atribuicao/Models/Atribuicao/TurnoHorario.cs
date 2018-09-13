using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao
{
    public class TurnoHorario
    {
        public int IdTurno { get; set; }
        public int IdHorario { get; set; }

        public Turno Turno { get; set; }
        public Horario Horario { get; set; }    
    }
}