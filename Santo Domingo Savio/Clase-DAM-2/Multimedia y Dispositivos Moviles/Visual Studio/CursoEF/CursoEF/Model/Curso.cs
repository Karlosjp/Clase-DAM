using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF.Model
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Nombre { get; set; }

        public DateTime Creado { get; set; }
        public DateTime Actualizado { get; set; }

        public List<AlumnoCurso> Alumnos { get; set; }
    }
}
