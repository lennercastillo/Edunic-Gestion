using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduGestion.Formularios
{
    public partial class AgregarCursos : Form
    {
        CN_Cursos negocio = new CN_Cursos();
        CN_Estados negocioEstados = new CN_Estados();
        private CE_Cursos cursoEditar = null;
        public AgregarCursos(CE_Cursos curso = null)
        {
            InitializeComponent();
            EduGestion.FormStyles.ApplyCompactStyle(this);
            cursoEditar = curso;
        }

        private void AgregarCursos_Load(object sender, EventArgs e)
        {
            comboBoxEstado.DataSource = negocioEstados.SelectAll();
            comboBoxEstado.DisplayMember = "StatusName";
            comboBoxEstado.ValueMember = "StatusId";

            if (cursoEditar != null)
            {
                this.Text = "Editar Curso";
                textBoxNombre.Text = cursoEditar.CourseName;
                textBoxDescripcion.Text = cursoEditar.CourseDescription;
                comboBoxEstado.SelectedValue = cursoEditar.CourseStatusId;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CE_Cursos curso = new CE_Cursos();
                curso.CourseName = textBoxNombre.Text;
                curso.CourseDescription = textBoxDescripcion.Text;
                curso.CourseStatusId = Convert.ToInt32(comboBoxEstado.SelectedValue);

                if (cursoEditar != null)
                {
                    curso.CourseId = cursoEditar.CourseId;
                    negocio.Update(curso);
                    MessageBox.Show("Curso actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    negocio.Insert(curso);
                    MessageBox.Show("Curso agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
