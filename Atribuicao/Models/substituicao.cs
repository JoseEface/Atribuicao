namespace Atribuicao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("atribuicao.substituicao")]
    public partial class substituicao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public substituicao()
        {
            substituihorario = new HashSet<substituihorario>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idSubstituicao { get; set; }

        public int idUsuarioSistema { get; set; }

        public DateTime dataCriado { get; set; }

        public bool finalizada { get; set; }

        public int idProfessorSubstituido { get; set; }

        public int idSituacaoSubstituido { get; set; }

        public virtual usuariosistema usuariosistema { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<substituihorario> substituihorario { get; set; }
    }
}
