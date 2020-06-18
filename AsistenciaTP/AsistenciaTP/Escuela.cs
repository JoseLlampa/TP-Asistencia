using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaTP
{
    public class Escuela
    {
        private string _nombreEscuela;
        private List<Docentes> _docentes;
        private List<Alumno> _alumnos;

        public string NombreEscuela { get => _nombreEscuela; set => _nombreEscuela = value; }
        public List<Docentes> Docentes { get => _docentes; set => _docentes = value; }
        public List<Alumno> Alumnos { get => _alumnos; set => _alumnos = value; }
    }
}
