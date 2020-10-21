using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEF.Model
{
    public class AlumnoCurso
    {
        [Key,Column(Order = 0)]
        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; }

        [Key, Column(Order = 1)]
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}
