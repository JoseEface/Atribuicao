namespace Atribuicao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("atribuicao.situacao")]
    public partial class situacao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public situacao()
        {
            professorsitucacao = new HashSet<professorsitucacao>();
        }

        [Key]
        public int idSituacao { get; set; }

        [Column("situacao")]
        [Required]
        [StringLength(45)]
        public string situacao1 { get; set; }

        public bool impredeAtribuicao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<professorsitucacao> professorsitucacao { get; set; }
    }
}
