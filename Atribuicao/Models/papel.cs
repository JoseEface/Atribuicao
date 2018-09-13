namespace Atribuicao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("atribuicao.papel")]
    public partial class papel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public papel()
        {
            usuariosistema = new HashSet<usuariosistema>();
        }

        [Key]
        public int idRole { get; set; }

        [Required]
        [StringLength(20)]
        public string papelUsuario { get; set; }

        public int? idEscola { get; set; }

        public virtual escola escola { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<usuariosistema> usuariosistema { get; set; }
    }
}
