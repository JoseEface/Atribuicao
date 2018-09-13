using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.ViewModel
{
    public class EstadoViewModel
    {
        [Required]
        public int id { get; set; }

        [Required]
        [MaxLength(22)]
        public string nome { get; set; }

        [Required]
        [MaxLength(2)]
        public string sigla { get; set; }
    }
}