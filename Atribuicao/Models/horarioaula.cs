namespace Atribuicao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("atribuicao.horarioaula")]
    public partial class horarioaula
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idProfessor { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idDisciplina { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idTurma { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idHorario { get; set; }

        public DateTime inicioAtribuicao { get; set; }

        public DateTime fimAtribuicao { get; set; }

        public int usuarioAtribuidor { get; set; }

        public DateTime atribuidoEm { get; set; }

        public virtual disciplina disciplina { get; set; }

        public virtual horario horario { get; set; }

        public virtual professor professor { get; set; }

        public virtual turma turma { get; set; }

        public virtual usuariosistema usuariosistema { get; set; }
    }
}
