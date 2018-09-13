namespace Atribuicao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("atribuicao.professorcategoria")]
    public partial class professorcategoria
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idCategoria { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idProfessor { get; set; }

        public DateTime? inicioContrato { get; set; }

        public DateTime? fimContrato { get; set; }

        public virtual categoria categoria { get; set; }

        public virtual professor professor { get; set; }
    }
}
