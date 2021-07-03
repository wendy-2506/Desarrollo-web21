using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Tu_Nuevo_Trabajo2021.Models
{
    public partial class _10MOCICLOContext : DbContext
    {
        public _10MOCICLOContext()
        {
        }

        public _10MOCICLOContext(DbContextOptions<_10MOCICLOContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<OfertaLaboral> OfertaLaboral { get; set; }
        public virtual DbSet<Postulaciones> Postulaciones { get; set; }
        public virtual DbSet<Postulante> Postulante { get; set; }
        public virtual DbSet<Sugerencias> Sugerencias { get; set; }
        public virtual DbSet<TipoRol> TipoRol { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-1COM54D\\SQLEXPRESS01;database=10MOCICLO;MultipleActiveResultSets=true;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ADMIN");

                entity.Property(e => e.AdminId).HasColumnName("ADMIN_ID");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDOS")
                    .IsFixedLength(true);

                entity.Property(e => e.Nombres)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRES")
                    .IsFixedLength(true);

                entity.HasOne(d => d.AdminNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.AdminId)
                    .HasConstraintName("FK_ADMIN_REFERENCE_USUARIO");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EMPRESA");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION")
                    .IsFixedLength(true);

                entity.Property(e => e.EmpresaId).HasColumnName("EMPRESA_ID");

                entity.Property(e => e.NombreEmpresa)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_EMPRESA")
                    .IsFixedLength(true);

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RAZON_SOCIAL")
                    .IsFixedLength(true);

                entity.Property(e => e.Ruc)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("RUC")
                    .IsFixedLength(true);

                entity.HasOne(d => d.EmpresaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.EmpresaId)
                    .HasConstraintName("FK_EMPRESA_REFERENCE_USUARIO");
            });

            modelBuilder.Entity<OfertaLaboral>(entity =>
            {
                entity.HasKey(e => e.IdOferta);

                entity.ToTable("OFERTA_LABORAL");

                entity.Property(e => e.IdOferta)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_OFERTA");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .IsFixedLength(true);

                entity.Property(e => e.EstadoOferta).HasColumnName("ESTADO_OFERTA");

                entity.Property(e => e.FechaCancelacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CANCELACION");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CREACION");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_FIN");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_INICIO");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.Lugar)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LUGAR")
                    .IsFixedLength(true);

                entity.Property(e => e.PuestoOferta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PUESTO_OFERTA")
                    .IsFixedLength(true);

                entity.Property(e => e.Requisitos)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("REQUISITOS")
                    .IsFixedLength(true);

                entity.Property(e => e.TipoContrato)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_CONTRATO")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.OfertaLaboral)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_OFERTA_L_REFERENCE_USUARIO");
            });

            modelBuilder.Entity<Postulaciones>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("POSTULACIONES");

                entity.Property(e => e.Estado).HasColumnName("ESTADO");

                entity.Property(e => e.FechaCancelado)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_CANCELADO");

                entity.Property(e => e.FechaPostulacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_POSTULACION");

                entity.Property(e => e.IdOferta).HasColumnName("ID_OFERTA");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.HasOne(d => d.IdOfertaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdOferta)
                    .HasConstraintName("FK_POSTULAC_REFERENCE_OFERTA_L");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_POSTULAC_REFERENCE_USUARIO");
            });

            modelBuilder.Entity<Postulante>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("POSTULANTE");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDOS")
                    .IsFixedLength(true);

                entity.Property(e => e.Dni)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("DNI")
                    .IsFixedLength(true);

                entity.Property(e => e.DocumentoCv)
                    .HasColumnType("image")
                    .HasColumnName("DOCUMENTO_CV");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("FECHA_NACIMIENTO");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRES")
                    .IsFixedLength(true);

                entity.Property(e => e.PostulanteId).HasColumnName("POSTULANTE_ID");

                entity.HasOne(d => d.PostulanteNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.PostulanteId)
                    .HasConstraintName("FK_POSTULAN_REFERENCE_USUARIO");
            });

            modelBuilder.Entity<Sugerencias>(entity =>
            {
                entity.HasKey(e => e.IdSugerencia);

                entity.ToTable("SUGERENCIAS");

                entity.Property(e => e.IdSugerencia)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_SUGERENCIA");

                entity.Property(e => e.DescripcionSugerencia)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION_SUGERENCIA")
                    .IsFixedLength(true);

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("FECHA");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                entity.Property(e => e.TituloSugerencia)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TITULO_SUGERENCIA")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Sugerencias)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_SUGERENC_REFERENCE_USUARIO");
            });

            modelBuilder.Entity<TipoRol>(entity =>
            {
                entity.HasKey(e => e.IdRol);

                entity.ToTable("TIPO_ROL");

                entity.Property(e => e.IdRol)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_ROL");

                entity.Property(e => e.NombreRol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_ROL")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("USUARIO");

                entity.Property(e => e.IdUsuario)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_USUARIO");

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CORREO")
                    .IsFixedLength(true);

                entity.Property(e => e.Estado).HasColumnName("ESTADO");

                entity.Property(e => e.IdRol).HasColumnName("ID_ROL");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD")
                    .IsFixedLength(true);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONO")
                    .IsFixedLength(true);

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("FK_USUARIO_REFERENCE_TIPO_ROL");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
