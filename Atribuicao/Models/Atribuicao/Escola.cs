using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atribuicao.Models.Atribuicao
{
    public class Escola
    {
        public int idEscola { get; set; }
        public string endereco { get; set; }
        public string nome { get; set; }
        public int idCidade { get; set; }
        public string cie { get; set; }
        public string ua { get; set; }

        public virtual Cidade cidade { get; set;  }
        public virtual ICollection<Turma> Turmas { get; set; }
        public virtual ICollection<EscolaTelefone> EscolaTelefones { get; set; }        
        public virtual ICollection<EscolaTipoEnsino> EscolaTipoEnsinos { get; set; }
        public virtual ICollection<Papel> Papeis { get; set; }
        public virtual ICollection<Professor> Professores { get; set; }
    }
}