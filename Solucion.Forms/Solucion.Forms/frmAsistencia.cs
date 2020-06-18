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

        public void btnAusente_Click(object sender, EventArgs e)
        {
            //Se quiere utilizar el metodo "SumarFalta" del alumno "al" seleccionado en "dataGridView1"
            Alumno al = (Alumno)Solucion.Forms.Form1.dataGridView1.SelectedRow;
            al.SumarFalta();
        }

        private void btnPresente_Click(object sender, EventArgs e)
        {

        }

        private void btnFaltas_Click(object sender, EventArgs e)
        {

        }

        private void frmAsistencia_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {

        }

        private void lblAlumno_Click(object sender, EventArgs e)
        {

        }

        private void frmAsistencia_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
