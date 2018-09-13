using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao
{
    public class Atribui
    {
        public int IdUsuarioSistema { get; set; }

        public int IdProfessorSubsituto { get; set; }

        public int IdAula { get; set; }

        public DateTime DataAtribuicao { get; set; }


        public virtual UsuarioSistema UsuarioSistema { get; set; }
        
        public virtual Professor Professor { get; set; }

        public virtual AulaVaga AulaVaga { get; set; }
    }
}