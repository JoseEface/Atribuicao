namespace Atribuicao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("atribuicao.escola")]
    public partial class escola
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public escola()
        {
            atpc = new HashSet<atpc>();
            professor = new HashSet<professor>();
            turma = new HashSet<turma>();
            telefone = new HashSet<telefone>();
            tipoensino = new HashSet<tipoensino>();
        }

        [Key]
        public int idEscola { get; set; }

        [Required]
        [StringLength(450)]
        public string endereco { get; set; }

        [Required]
        [StringLength(250)]
        public string nome { get; set; }

        public int idCidade { get; set; }

        [StringLength(7)]
        public string CIE { get; set; }

        [StringLength(5)]
        public string UA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<atpc> atpc { get; set; }

        public virtual cidade cidade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<professor> professor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<turma> turma { get; set; }

        public virtual papel papel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<telefone> telefone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tipoensino> tipoensino { get; set; }
    }
}
