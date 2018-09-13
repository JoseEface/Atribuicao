namespace Atribuicao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("atribuicao.horarioatpc")]
    public partial class horarioatpc
    {
        public int idUsuarioSistema { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idProfessor { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idAtpc { get; set; }

        public DateTime inicioAtribuicao { get; set; }

        public DateTime fimAtribuicao { get; set; }

        public DateTime atribuidoEm { get; set; }

        public virtual atpc atpc { get; set; }

        public virtual professor professor { get; set; }

        public virtual usuariosistema usuariosistema { get; set; }
    }
}
