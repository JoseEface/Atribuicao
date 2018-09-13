using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Atribuicao.Models
{
    public class StatusRetorno
    {
        public bool Sucesso { get; set; }

        public JsonResult ListaRetorno { get; set; }

        public string MensagemExtra { get; set; }
    }
}