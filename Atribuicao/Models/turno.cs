namespace Atribuicao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("atribuicao.turno")]
    public partial class turno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idTurno { get; set; }

        [Required]
        [StringLength(45)]
        public string nomeTurno { get; set; }

        public virtual turma turma { get; set; }
    }
}
