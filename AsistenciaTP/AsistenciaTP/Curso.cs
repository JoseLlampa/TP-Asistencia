using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaTP
{
    public class Curso
    {
        private int _año;
        private int _division;
        private string _turno;

        public int Año { get => _año; set => _año = value; }
        public int Division { get => _division; set => _division = value; }
        public string Turno { get => _turno; set => _turno = value; }
    }
}
