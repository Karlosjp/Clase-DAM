namespace CursoEF.Migrations
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CursoEF.Model.EfcursoContex>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EfcursoContex context)
        {

            context.Alumno.AddOrUpdate(
              new Alumno { Nombre = "Andrew", Apellido = "Peters", Actualizado = DateTime.Now, Creado = DateTime.Now },
              new Alumno { Nombre = "Marcos", Apellido = "Gomez", Actualizado = DateTime.Now, Creado = DateTime.Now }
            );

            context.Curso.AddOrUpdate(
              new Curso { Nombre = "Curso 1", Actualizado = DateTime.Now, Creado = DateTime.Now },
              new Curso { Nombre = "Curso 2", Actualizado = DateTime.Now, Creado = DateTime.Now },
              new Curso { Nombre = "Curso 3", Actualizado = DateTime.Now, Creado = DateTime.Now }
            );
        }
    }
}
