namespace Atribuicao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("atribuicao.horario")]
    public partial class horario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public horario()
        {
            atpc = new HashSet<atpc>();
            horarioaula = new HashSet<horarioaula>();
        }

        [Key]
        public int idHorario { get; set; }

        public TimeSpan horarioInicio { get; set; }

        public TimeSpan horarioFim { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string diaSemana { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<atpc> atpc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<horarioaula> horarioaula { get; set; }
    }
}
