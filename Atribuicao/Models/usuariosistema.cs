namespace Atribuicao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("atribuicao.usuariosistema")]
    public partial class usuariosistema
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuariosistema()
        {
            horarioatpc = new HashSet<horarioatpc>();
            horarioaula = new HashSet<horarioaula>();
            substituicao = new HashSet<substituicao>();
        }

        [Key]
        public int idUsuarioSistema { get; set; }

        [Required]
        [StringLength(45)]
        public string login { get; set; }

        [Required]
        [StringLength(64)]
        public string senha { get; set; }

        public int userRole { get; set; }

        public bool ativo { get; set; }

        public int idPessoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<horarioatpc> horarioatpc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<horarioaula> horarioaula { get; set; }

        public virtual papel papel { get; set; }

        public virtual pessoa pessoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<substituicao> substituicao { get; set; }
    }
}
