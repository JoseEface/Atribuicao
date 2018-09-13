namespace Atribuicao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("atribuicao.atpc")]
    public partial class atpc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public atpc()
        {
            horarioatpc = new HashSet<horarioatpc>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idAtpc { get; set; }

        public int idHorario { get; set; }

        public int idEscola { get; set; }

        public virtual escola escola { get; set; }

        public virtual horario horario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<horarioatpc> horarioatpc { get; set; }
    }
}
