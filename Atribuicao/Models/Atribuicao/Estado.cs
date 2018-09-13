using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace Atribuicao.Models.Atribuicao
{
    public class Estado
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public int idEstado { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(length: 22,ErrorMessage ="No máximo 22 caracteres")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(length: 2, ErrorMessage = "No máximo 2 caracteres")]
        public string sigla { get; set; }

        [JsonIgnore]
        public virtual ICollection<Cidade> Cidade { get; set; }

        public Estado()
        {
            Cidade = new List<Cidade>();
        }
    }
}