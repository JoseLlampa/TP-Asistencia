using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Curso
    {
        private List<Alumno> _alumnos;

        public List<Alumno> Cursos { get => _alumnos; set => _alumnos = value; }

        public Curso()
        {
            this.Cursos = new List<Alumno>();
        }


        public void AgregarAlumno(Alumno alumno)
        {
            this._alumnos.Add(alumno);

        }

        public void EliminarAlumno(Alumno alumno)
        {
            this._alumnos.Remove(alumno);
        }

        
    }
}
