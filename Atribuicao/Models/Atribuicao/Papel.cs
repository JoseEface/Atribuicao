using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao
{
    public class Papel
    {
        public int idRole { get; set; }

        public string papelUsuario { get; set; }

        public int? idEscola { get; set; }

        public virtual Escola Escola { get; set; }

        public virtual ICollection<UsuarioSistema> UsuarioSistemas { get; set; }
    }
}