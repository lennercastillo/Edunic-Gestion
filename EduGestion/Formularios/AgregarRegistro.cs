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
    public partial class AgregarRegistros : Form
    {
        CN_Registros negocio = new CN_Registros();
        CN_Estudiantes negocioEstudiantes = new CN_Estudiantes();
        CN_Cursos negocioCursos = new CN_Cursos();
        CN_Estados negocioEstados = new CN_Estados();
        private CE_Registros registroEditar = null;
        public AgregarRegistros(CE_Registros registro = null)
        {
            InitializeComponent();
            EduGestion.FormStyles.ApplyCompactStyle(this);
            registroEditar = registro;
        }

        private void AgregarRegistros_Load(object sender, EventArgs e)
        {
            comboBoxEstudiante.DataSource = negocioEstudiantes.SelectAll();
            comboBoxEstudiante.DisplayMember = "StudentFullName";
            comboBoxEstudiante.ValueMember = "StudentId";

            comboBoxCurso.DataSource = negocioCursos.SelectAll();
            comboBoxCurso.DisplayMember = "CourseName";
            comboBoxCurso.ValueMember = "CourseId";

            comboBoxEstado.DataSource = negocioEstados.SelectAll();
            comboBoxEstado.DisplayMember = "StatusName";
            comboBoxEstado.ValueMember = "StatusId";

            if (registroEditar != null)
            {
                this.Text = "Editar Registro";
                comboBoxEstudiante.SelectedValue = registroEditar.RegistrationStudentId;
                comboBoxCurso.SelectedValue = registroEditar.RegistrationCourseId;
                comboBoxEstado.SelectedValue = registroEditar.RegistrationStatusId;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CE_Registros registro = new CE_Registros();
                registro.RegistrationStudentId = Convert.ToInt32(comboBoxEstudiante.SelectedValue);
                registro.RegistrationCourseId = Convert.ToInt32(comboBoxCurso.SelectedValue);
                registro.RegistrationStatusId = Convert.ToInt32(comboBoxEstado.SelectedValue);

                if (registroEditar != null)
                {
                    registro.RegistrationId = registroEditar.RegistrationId;
                    negocio.Update(registro);
                    MessageBox.Show("Registro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    negocio.Insert(registro);
                    MessageBox.Show("Registro agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
