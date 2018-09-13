using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao
{
    public class Categoria
    {
         public int idCategoria { get; set; }

         public string letraCategoria { get; set; }
         
         public virtual ICollection<ProfessorCategoria> ProfessorCategorias { get; set; }
    }
}