using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao
{
    public class CargaHoraria
    {
        public int IdCargaHoraria { get; set; }
        public int Valor { get; set; }

        public ICollection<ProfessorCategoria> ProfessorCategorias { get; set; }
    }
}