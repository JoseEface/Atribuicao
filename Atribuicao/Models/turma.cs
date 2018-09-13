namespace Atribuicao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("atribuicao.turma")]
    public partial class turma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public turma()
        {
            horarioaula = new HashSet<horarioaula>();
        }

        [Key]
        public int idTurma { get; set; }

        [Required]
        [StringLength(50)]
        public string serie { get; set; }

        public int idEscola { get; set; }

        public int tipoEnsino { get; set; }

        public int idTurno { get; set; }

        public virtual escola escola { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<horarioaula> horarioaula { get; set; }

        public virtual tipoensino tipoensino1 { get; set; }

        public virtual turno turno { get; set; }
    }
}
