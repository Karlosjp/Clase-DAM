namespace CursoEF.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class EfcursoContex : DbContext
    {
        public DbSet<Alumno> Alumno { get; set; }
        public DbSet<AlumnoCurso> AlumnoCurso { get; set; }
        public DbSet<Curso> Curso { get; set; }

        public EfcursoContex()
            : base("name=EfcursoContex")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            #region Alumno
            modelBuilder.Entity<Alumno>().Property(x => x.Nombre).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Alumno>().Property(x => x.Apellido).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Alumno>().Property(x => x.Creado).IsRequired();
            modelBuilder.Entity<Alumno>().Property(x => x.Actualizado).IsRequired();
            #endregion

            #region AlumnoCurso
            modelBuilder.Entity<AlumnoCurso>().HasKey(x => new { x.AlumnoId, x.CursoId });
            #endregion

            #region Curso
            modelBuilder.Entity<Curso>().Property(x => x.Nombre).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Curso>().Property(x => x.Actualizado).IsRequired();
            modelBuilder.Entity<Curso>().Property(x => x.Creado).IsRequired();
            #endregion

        }

    }
}