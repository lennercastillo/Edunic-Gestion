using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduGestion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }


        private Form FormularioActivo = null;

        private void AbrirFormularioHijo(Form formulariohijo) 
        {
            if (FormularioActivo != null) 
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulariohijo;
            formulariohijo.TopLevel = false;
            formulariohijo.FormBorderStyle = FormBorderStyle.None;
            formulariohijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formulariohijo);
            panelContenedor.Tag = formulariohijo;
            formulariohijo.BringToFront();
            formulariohijo.Show();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Principal());
        }

        private void btnMatriculas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Matriculas());
        }

        private void BtnCalificaciones_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new calificaciones());
        }

        private void BtnRegistros_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Registros());
        }

        private void BtnCursos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Cursos());
        }

        private void BtnPagos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Pagos());
        }

        private void BtnProfesores_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Profesores());
        }

        private void BtnEstudiantes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Estudiantes());
        }
    }


}
