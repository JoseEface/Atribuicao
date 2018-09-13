namespace Atribuicao.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AtribuicaoDbContext : DbContext
    {
        public AtribuicaoDbContext()
            : base("name=AtribuicaoDbContext")
        {
        }

        public virtual DbSet<atpc> atpc { get; set; }
        public virtual DbSet<cargahoraria> cargahoraria { get; set; }
        public virtual DbSet<categoria> categoria { get; set; }
        public virtual DbSet<cidade> cidade { get; set; }
        public virtual DbSet<disciplina> disciplina { get; set; }
        public virtual DbSet<escola> escola { get; set; }
        public virtual DbSet<estado> estado { get; set; }
        public virtual DbSet<horario> horario { get; set; }
        public virtual DbSet<horarioatpc> horarioatpc { get; set; }
        public virtual DbSet<horarioaula> horarioaula { get; set; }
        public virtual DbSet<papel> papel { get; set; }
        public virtual DbSet<pessoa> pessoa { get; set; }
        public virtual DbSet<professor> professor { get; set; }
        public virtual DbSet<professorcategoria> professorcategoria { get; set; }
        public virtual DbSet<professorsitucacao> professorsitucacao { get; set; }
        public virtual DbSet<situacao> situacao { get; set; }
        public virtual DbSet<substituicao> substituicao { get; set; }
        public virtual DbSet<substituihorario> substituihorario { get; set; }
        public virtual DbSet<telefone> telefone { get; set; }
        public virtual DbSet<tipoensino> tipoensino { get; set; }
        public virtual DbSet<turma> turma { get; set; }
        public virtual DbSet<turno> turno { get; set; }
        public virtual DbSet<usuariosistema> usuariosistema { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<atpc>()
                .HasMany(e => e.horarioatpc)
                .WithRequired(e => e.atpc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cargahoraria>()
                .HasMany(e => e.professor)
                .WithRequired(e => e.cargahoraria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<categoria>()
                .Property(e => e.letraCategoria)
                .IsUnicode(false);

            modelBuilder.Entity<categoria>()
                .HasMany(e => e.professorcategoria)
                .WithRequired(e => e.categoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cidade>()
                .Property(e => e.nomeCidade)
                .IsUnicode(false);

            modelBuilder.Entity<cidade>()
                .HasMany(e => e.escola)
                .WithRequired(e => e.cidade)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<disciplina>()
                .Property(e => e.nomeDisciplina)
                .IsUnicode(false);

            modelBuilder.Entity<disciplina>()
                .HasMany(e => e.horarioaula)
                .WithRequired(e => e.disciplina)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<disciplina>()
                .HasMany(e => e.professor)
                .WithMany(e => e.disciplina)
                .Map(m => m.ToTable("professordisciplina", "atribuicao").MapLeftKey("idDisciplina").MapRightKey("idProfessor"));

            modelBuilder.Entity<escola>()
                .Property(e => e.endereco)
                .IsUnicode(false);

            modelBuilder.Entity<escola>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<escola>()
                .Property(e => e.CIE)
                .IsUnicode(false);

            modelBuilder.Entity<escola>()
                .Property(e => e.UA)
                .IsUnicode(false);

            modelBuilder.Entity<escola>()
                .HasMany(e => e.atpc)
                .WithRequired(e => e.escola)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<escola>()
                .HasMany(e => e.professor)
                .WithRequired(e => e.escola)
                .HasForeignKey(e => e.sede)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<escola>()
                .HasMany(e => e.turma)
                .WithRequired(e => e.escola)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<escola>()
                .HasOptional(e => e.papel)
                .WithRequired(e => e.escola);

            modelBuilder.Entity<escola>()
                .HasMany(e => e.telefone)
                .WithMany(e => e.escola)
                .Map(m => m.ToTable("escolatelefone", "atribuicao").MapLeftKey("idEscola").MapRightKey("idTelefone"));

            modelBuilder.Entity<estado>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<estado>()
                .Property(e => e.sigla)
                .IsUnicode(false);

            modelBuilder.Entity<estado>()
                .HasMany(e => e.cidade)
                .WithRequired(e => e.estado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<horario>()
                .Property(e => e.diaSemana)
                .IsUnicode(false);

            modelBuilder.Entity<horario>()
                .HasMany(e => e.atpc)
                .WithRequired(e => e.horario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<horario>()
                .HasMany(e => e.horarioaula)
                .WithRequired(e => e.horario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<papel>()
                .Property(e => e.papelUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<papel>()
                .HasMany(e => e.usuariosistema)
                .WithRequired(e => e.papel)
                .HasForeignKey(e => e.userRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.cpf)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.rg)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.telefone)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.celular)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .HasMany(e => e.professor)
                .WithRequired(e => e.pessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<pessoa>()
                .HasMany(e => e.usuariosistema)
                .WithRequired(e => e.pessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<professor>()
                .HasMany(e => e.horarioatpc)
                .WithRequired(e => e.professor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<professor>()
                .HasMany(e => e.horarioaula)
                .WithRequired(e => e.professor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<professor>()
                .HasMany(e => e.professorcategoria)
                .WithRequired(e => e.professor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<professor>()
                .HasMany(e => e.professorsitucacao)
                .WithRequired(e => e.professor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<professorsitucacao>()
                .Property(e => e.observacoes)
                .IsUnicode(false);

            modelBuilder.Entity<situacao>()
                .Property(e => e.situacao1)
                .IsUnicode(false);

            modelBuilder.Entity<situacao>()
                .HasMany(e => e.professorsitucacao)
                .WithRequired(e => e.situacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<substituicao>()
                .HasMany(e => e.substituihorario)
                .WithRequired(e => e.substituicao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<telefone>()
                .Property(e => e.numero)
                .IsUnicode(false);

            modelBuilder.Entity<tipoensino>()
                .Property(e => e.ensino)
                .IsUnicode(false);

            modelBuilder.Entity<tipoensino>()
                .HasMany(e => e.turma)
                .WithRequired(e => e.tipoensino1)
                .HasForeignKey(e => e.tipoEnsino)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tipoensino>()
                .HasMany(e => e.escola)
                .WithMany(e => e.tipoensino)
                .Map(m => m.ToTable("escolatipoensino", "atribuicao").MapLeftKey("idTipoEnsino").MapRightKey("idEscola"));

            modelBuilder.Entity<turma>()
                .Property(e => e.serie)
                .IsUnicode(false);

            modelBuilder.Entity<turma>()
                .HasMany(e => e.horarioaula)
                .WithRequired(e => e.turma)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<turno>()
                .Property(e => e.nomeTurno)
                .IsUnicode(false);

            modelBuilder.Entity<turno>()
                .HasOptional(e => e.turma)
                .WithRequired(e => e.turno);

            modelBuilder.Entity<usuariosistema>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<usuariosistema>()
                .Property(e => e.senha)
                .IsUnicode(false);

            modelBuilder.Entity<usuariosistema>()
                .HasMany(e => e.horarioatpc)
                .WithRequired(e => e.usuariosistema)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<usuariosistema>()
                .HasMany(e => e.horarioaula)
                .WithRequired(e => e.usuariosistema)
                .HasForeignKey(e => e.usuarioAtribuidor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<usuariosistema>()
                .HasMany(e => e.substituicao)
                .WithRequired(e => e.usuariosistema)
                .WillCascadeOnDelete(false);
        }
    }
}
