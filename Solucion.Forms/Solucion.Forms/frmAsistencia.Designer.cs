namespace Solucion.Forms
{
    partial class frmAsistencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAlumno = new System.Windows.Forms.Label();
            this.btnPresente = new System.Windows.Forms.Button();
            this.btnAusente = new System.Windows.Forms.Button();
            this.btnFaltas = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(29, 35);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(46, 17);
            this.lblAlumno.TabIndex = 0;
            this.lblAlumno.Text = "label1";
            // 
            // btnPresente
            // 
            this.btnPresente.Location = new System.Drawing.Point(32, 161);
            this.btnPresente.Name = "btnPresente";
            this.btnPresente.Size = new System.Drawing.Size(162, 50);
            this.btnPresente.TabIndex = 1;
            this.btnPresente.Text = "Presente";
            this.btnPresente.UseVisualStyleBackColor = true;
            this.btnPresente.Click += new System.EventHandler(this.btnPresente_Click);
            // 
            // btnAusente
            // 
            this.btnAusente.Location = new System.Drawing.Point(33, 255);
            this.btnAusente.Name = "btnAusente";
            this.btnAusente.Size = new System.Drawing.Size(161, 50);
            this.btnAusente.TabIndex = 2;
            this.btnAusente.Text = "Ausente";
            this.btnAusente.UseVisualStyleBackColor = true;
            this.btnAusente.Click += new System.EventHandler(this.btnAusente_Click);
            // 
            // btnFaltas
            // 
            this.btnFaltas.Location = new System.Drawing.Point(33, 348);
            this.btnFaltas.Name = "btnFaltas";
            this.btnFaltas.Size = new System.Drawing.Size(161, 52);
            this.btnFaltas.TabIndex = 3;
            this.btnFaltas.Text = "Faltas";
            this.btnFaltas.UseVisualStyleBackColor = true;
            this.btnFaltas.Click += new System.EventHandler(this.btnFaltas_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(32, 81);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 17);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "label1";
            // 
            // frmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnFaltas);
            this.Controls.Add(this.btnAusente);
            this.Controls.Add(this.btnPresente);
            this.Controls.Add(this.lblAlumno);
            this.Name = "frmAsistencia";
            this.Text = "ASISTENCIA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAsistencia_FormClosed);
            this.Load += new System.EventHandler(this.frmAsistencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Button btnPresente;
        private System.Windows.Forms.Button btnAusente;
        private System.Windows.Forms.Button btnFaltas;
        private System.Windows.Forms.Label lblFecha;
    }
}