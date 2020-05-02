using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaTP
{
    public class Alumno
    {
        private int _registro;
        private List<Falta> _faltas;
        private double _ausencia;

        public int Registro { get => _registro; set => _registro = value; }
        public List<Falta> Faltas { get => _faltas; set => _faltas = value; }
        public double Ausencia { get => _ausencia; set => _ausencia = value; }

        
    }
}
