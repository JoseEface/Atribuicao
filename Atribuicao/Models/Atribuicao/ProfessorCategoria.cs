using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao
{
    public class ProfessorCategoria
    {
        public int idCategoria { get; set; }
        public int idProfessor { get; set; }
        public DateTime inicioContrato { get; set; }
        public DateTime fimContrato { get; set; }
        public int cargaHoraria { get; set; }

        public virtual Categoria Categoria { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual CargaHoraria CargaHoraria { get; set; }
    }
}