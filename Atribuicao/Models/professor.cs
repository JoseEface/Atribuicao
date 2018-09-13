namespace Atribuicao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("atribuicao.professor")]
    public partial class professor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public professor()
        {
            horarioatpc = new HashSet<horarioatpc>();
            horarioaula = new HashSet<horarioaula>();
            professorcategoria = new HashSet<professorcategoria>();
            professorsitucacao = new HashSet<professorsitucacao>();
            disciplina = new HashSet<disciplina>();
        }

        [Key]
        public int idProfessor { get; set; }

        public float classificacao { get; set; }

        public int sede { get; set; }

        public int idPessoa { get; set; }

        public int idCargaHoraria { get; set; }

        public bool ativo { get; set; }

        public virtual cargahoraria cargahoraria { get; set; }

        public virtual escola escola { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<horarioatpc> horarioatpc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<horarioaula> horarioaula { get; set; }

        public virtual pessoa pessoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<professorcategoria> professorcategoria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<professorsitucacao> professorsitucacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<disciplina> disciplina { get; set; }
    }
}
