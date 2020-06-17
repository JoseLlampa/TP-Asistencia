using Solucion.LibreriaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion.Forms
{
    public partial class frmAsistencia : Form
    {
        private Curso _curso;
        public frmAsistencia(Curso cur)
        {
            _curso = cur;
            InitializeComponent();
        }

        private void btnPresente_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFaltas_Click(object sender, EventArgs e)
        {

        }

        public void btnAusente_Click(object sender, EventArgs e)
        {
          //  Alumno.SumarFalta();
        }

        private void frmAsistencia_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {

        }
    }
}
