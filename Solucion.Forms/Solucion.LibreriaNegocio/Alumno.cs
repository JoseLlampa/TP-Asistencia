using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Alumno
    {
        private string _nombre;
        private double _falta;

        public string Nombre { get => _nombre; set => _nombre = value; }
        private double Falta { get => _falta; set => _falta = value; }
        
        public Alumno(string nom, double falt)
        {
            this._nombre = nom;
            this._falta = falt;
        }

        public void SumarFalta()
        {
            this.Falta = this.Falta + 1;
        }

        

    }
}
