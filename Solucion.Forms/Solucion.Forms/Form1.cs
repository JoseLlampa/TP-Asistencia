using Solucion.LibreriaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion.Forms
{
    public partial class Form1 : Form
    {
        public Curso _curso;
        public Form1(Curso cur)
        {
            _curso = cur;
            InitializeComponent();
        }

        public void origendatos()
        {
            Alumno al1 = new Alumno("Mauro", 0);
            Alumno al2 = new Alumno("Gaspar", 0);
            Alumno al3 = new Alumno("Andres", 0);

            _curso.AgregarAlumno(al1);
            _curso.AgregarAlumno(al2);
            _curso.AgregarAlumno(al3);

            dataGridView1.DataSource = _curso.Cursos;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            origendatos();

            DataGridViewButtonColumn btnclm = new DataGridViewButtonColumn();
            btnclm.Name = "Asistencia";

            dataGridView1.Columns.Add(btnclm);
        }

        public void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Asistencia")
            {
                frmAsistencia cur = new frmAsistencia(this._curso);
                cur.Owner = this;
                cur.Show();
                
            }
        }
    }
}
