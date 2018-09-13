namespace Atribuicao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("atribuicao.professorsitucacao")]
    public partial class professorsitucacao
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idProfessor { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idSituacao { get; set; }

        public DateTime dataInicio { get; set; }

        public DateTime? dataFim { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime dataCadastro { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string observacoes { get; set; }

        public virtual professor professor { get; set; }

        public virtual situacao situacao { get; set; }
    }
}
