namespace Atribuicao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("atribuicao.pessoa")]
    public partial class pessoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pessoa()
        {
            professor = new HashSet<professor>();
            usuariosistema = new HashSet<usuariosistema>();
        }

        [Key]
        public int idPessoa { get; set; }

        [Required]
        [StringLength(11)]
        public string cpf { get; set; }

        [Required]
        [StringLength(10)]
        public string rg { get; set; }

        [Required]
        [StringLength(250)]
        public string nome { get; set; }

        [StringLength(250)]
        public string email { get; set; }

        [StringLength(15)]
        public string telefone { get; set; }

        [Required]
        [StringLength(15)]
        public string celular { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<professor> professor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<usuariosistema> usuariosistema { get; set; }
    }
}
