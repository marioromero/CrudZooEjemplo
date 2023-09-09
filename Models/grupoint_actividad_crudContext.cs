using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CrudZooEjemplo.Models
{
    public partial class grupoint_actividad_crudContext : DbContext
    {
        public grupoint_actividad_crudContext()
        {
        }

        public grupoint_actividad_crudContext(DbContextOptions<grupoint_actividad_crudContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Avestruz> Avestruces { get; set; } = null!;
        public virtual DbSet<Cebra> Cebras { get; set; } = null!;
        public virtual DbSet<Elefante> Elefantes { get; set; } = null!;
        public virtual DbSet<Hipopotamo> Hipopotamos { get; set; } = null!;
        public virtual DbSet<Jirafa> Jirafas { get; set; } = null!;
        public virtual DbSet<Koala> Koalas { get; set; } = null!;
        public virtual DbSet<Leon> Leones { get; set; } = null!;
        public virtual DbSet<Lobo> Lobos { get; set; } = null!;
        public virtual DbSet<Mono> Monos { get; set; } = null!;
        public virtual DbSet<Pantera> Panteras { get; set; } = null!;
        public virtual DbSet<Tiburon> Tiburones { get; set; } = null!;
        public virtual DbSet<Tigre> Tigres { get; set; } = null!;
        public virtual DbSet<Tipo> Tipos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=104.194.9.141;port=3306;user=grupoint_user_cftsa;password=contraseña;database=grupoint_actividad_crud", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.6.15-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");

            modelBuilder.Entity<Avestruz>(entity =>
            {
                entity.ToTable("avestruces");

                entity.HasIndex(e => e.TipoId, "tipo_id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Apodo)
                    .HasMaxLength(50)
                    .HasColumnName("apodo");

                entity.Property(e => e.EdadIngreso)
                    .HasColumnType("int(11)")
                    .HasColumnName("edad_ingreso");

                entity.Property(e => e.EsPeligroso).HasColumnName("es_peligroso");

                entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");

                entity.Property(e => e.TipoId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tipo_id");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Avestruces)
                    .HasForeignKey(d => d.TipoId)
                    .HasConstraintName("avestruces_ibfk_1");
            });

            modelBuilder.Entity<Cebra>(entity =>
            {
                entity.ToTable("cebras");

                entity.HasIndex(e => e.TipoId, "tipo_id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Apodo)
                    .HasMaxLength(50)
                    .HasColumnName("apodo");

                entity.Property(e => e.EdadIngreso)
                    .HasColumnType("int(11)")
                    .HasColumnName("edad_ingreso");

                entity.Property(e => e.EsPeligroso).HasColumnName("es_peligroso");

                entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");

                entity.Property(e => e.TipoId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tipo_id");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Cebras)
                    .HasForeignKey(d => d.TipoId)
                    .HasConstraintName("cebras_ibfk_1");
            });

            modelBuilder.Entity<Elefante>(entity =>
            {
                entity.ToTable("elefantes");

                entity.HasIndex(e => e.TipoId, "tipo_id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Apodo)
                    .HasMaxLength(50)
                    .HasColumnName("apodo");

                entity.Property(e => e.EdadIngreso)
                    .HasColumnType("int(11)")
                    .HasColumnName("edad_ingreso");

                entity.Property(e => e.EsPeligroso).HasColumnName("es_peligroso");

                entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");

                entity.Property(e => e.TipoId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tipo_id");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Elefantes)
                    .HasForeignKey(d => d.TipoId)
                    .HasConstraintName("elefantes_ibfk_1");
            });

            modelBuilder.Entity<Hipopotamo>(entity =>
            {
                entity.ToTable("hipopotamos");

                entity.HasIndex(e => e.TipoId, "tipo_id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Apodo)
                    .HasMaxLength(50)
                    .HasColumnName("apodo");

                entity.Property(e => e.EdadIngreso)
                    .HasColumnType("int(11)")
                    .HasColumnName("edad_ingreso");

                entity.Property(e => e.EsPeligroso).HasColumnName("es_peligroso");

                entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");

                entity.Property(e => e.TipoId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tipo_id");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Hipopotamos)
                    .HasForeignKey(d => d.TipoId)
                    .HasConstraintName("hipopotamos_ibfk_1");
            });

            modelBuilder.Entity<Jirafa>(entity =>
            {
                entity.ToTable("jirafas");

                entity.HasIndex(e => e.TipoId, "tipo_id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Apodo)
                    .HasMaxLength(50)
                    .HasColumnName("apodo");

                entity.Property(e => e.EdadIngreso)
                    .HasColumnType("int(11)")
                    .HasColumnName("edad_ingreso");

                entity.Property(e => e.EsPeligroso).HasColumnName("es_peligroso");

                entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");

                entity.Property(e => e.TipoId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tipo_id");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Jirafas)
                    .HasForeignKey(d => d.TipoId)
                    .HasConstraintName("jirafas_ibfk_1");
            });

            modelBuilder.Entity<Koala>(entity =>
            {
                entity.ToTable("koalas");

                entity.HasIndex(e => e.TipoId, "tipo_id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Apodo)
                    .HasMaxLength(50)
                    .HasColumnName("apodo");

                entity.Property(e => e.EdadIngreso)
                    .HasColumnType("int(11)")
                    .HasColumnName("edad_ingreso");

                entity.Property(e => e.EsPeligroso).HasColumnName("es_peligroso");

                entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");

                entity.Property(e => e.TipoId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tipo_id");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Koalas)
                    .HasForeignKey(d => d.TipoId)
                    .HasConstraintName("koalas_ibfk_1");
            });

            modelBuilder.Entity<Leon>(entity =>
            {
                entity.ToTable("leones");

                entity.HasIndex(e => e.TipoId, "tipo_id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Apodo)
                    .HasMaxLength(50)
                    .HasColumnName("apodo");

                entity.Property(e => e.EdadIngreso)
                    .HasColumnType("int(11)")
                    .HasColumnName("edad_ingreso");

                entity.Property(e => e.EsPeligroso).HasColumnName("es_peligroso");

                entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");

                entity.Property(e => e.TipoId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tipo_id");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Leones)
                    .HasForeignKey(d => d.TipoId)
                    .HasConstraintName("leones_ibfk_1");
            });

            modelBuilder.Entity<Lobo>(entity =>
            {
                entity.ToTable("lobos");

                entity.HasIndex(e => e.TipoId, "tipo_id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Apodo)
                    .HasMaxLength(50)
                    .HasColumnName("apodo");

                entity.Property(e => e.EdadIngreso)
                    .HasColumnType("int(11)")
                    .HasColumnName("edad_ingreso");

                entity.Property(e => e.EsPeligroso).HasColumnName("es_peligroso");

                entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");

                entity.Property(e => e.TipoId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tipo_id");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Lobos)
                    .HasForeignKey(d => d.TipoId)
                    .HasConstraintName("lobos_ibfk_1");
            });

            modelBuilder.Entity<Mono>(entity =>
            {
                entity.ToTable("monos");

                entity.HasIndex(e => e.TipoId, "tipo_id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Apodo)
                    .HasMaxLength(50)
                    .HasColumnName("apodo");

                entity.Property(e => e.EdadIngreso)
                    .HasColumnType("int(11)")
                    .HasColumnName("edad_ingreso");

                entity.Property(e => e.EsPeligroso).HasColumnName("es_peligroso");

                entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");

                entity.Property(e => e.TipoId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tipo_id");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Monos)
                    .HasForeignKey(d => d.TipoId)
                    .HasConstraintName("monos_ibfk_1");
            });

            modelBuilder.Entity<Pantera>(entity =>
            {
                entity.ToTable("panteras");

                entity.HasIndex(e => e.TipoId, "tipo_id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Apodo)
                    .HasMaxLength(50)
                    .HasColumnName("apodo");

                entity.Property(e => e.EdadIngreso)
                    .HasColumnType("int(11)")
                    .HasColumnName("edad_ingreso");

                entity.Property(e => e.EsPeligroso).HasColumnName("es_peligroso");

                entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");

                entity.Property(e => e.TipoId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tipo_id");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Panteras)
                    .HasForeignKey(d => d.TipoId)
                    .HasConstraintName("panteras_ibfk_1");
            });

            modelBuilder.Entity<Tiburon>(entity =>
            {
                entity.ToTable("tiburones");

                entity.HasIndex(e => e.TipoId, "tipo_id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Apodo)
                    .HasMaxLength(50)
                    .HasColumnName("apodo");

                entity.Property(e => e.EdadIngreso)
                    .HasColumnType("int(11)")
                    .HasColumnName("edad_ingreso");

                entity.Property(e => e.EsPeligroso).HasColumnName("es_peligroso");

                entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");

                entity.Property(e => e.TipoId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tipo_id");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Tiburones)
                    .HasForeignKey(d => d.TipoId)
                    .HasConstraintName("tiburones_ibfk_1");
            });

            modelBuilder.Entity<Tigre>(entity =>
            {
                entity.ToTable("tigres");

                entity.HasIndex(e => e.TipoId, "tipo_id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Apodo)
                    .HasMaxLength(50)
                    .HasColumnName("apodo");

                entity.Property(e => e.EdadIngreso)
                    .HasColumnType("int(11)")
                    .HasColumnName("edad_ingreso");

                entity.Property(e => e.EsPeligroso).HasColumnName("es_peligroso");

                entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");

                entity.Property(e => e.TipoId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tipo_id");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Tigres)
                    .HasForeignKey(d => d.TipoId)
                    .HasConstraintName("tigres_ibfk_1");
            });

            modelBuilder.Entity<Tipo>(entity =>
            {
                entity.ToTable("tipos");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .HasColumnName("descripcion");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
