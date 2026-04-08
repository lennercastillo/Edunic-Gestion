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
    public partial class AgregarMatriculas : Form
    {
        CN_Registros negocio = new CN_Registros();
        CN_Estudiantes negocioEstudiantes = new CN_Estudiantes();
        CN_Cursos negocioCursos = new CN_Cursos();
        CN_Estados negocioEstados = new CN_Estados();
        private CE_Registros registroEditar = null;
        public AgregarMatriculas(CE_Registros registro = null)
        {
            InitializeComponent();
            EduGestion.FormStyles.ApplyCompactStyle(this);
            this.registroEditar = registro;
        }

        private void AgregarMatricula_Load(object sender, EventArgs e)
        {
            comboBoxEstudiante.DataSource = negocioEstudiantes.SelectAll();
            comboBoxEstudiante.DisplayMember = "StudentFullName";
            comboBoxEstudiante.ValueMember = "StudentId";

            checkedListBoxCursos.DataSource = negocioCursos.SelectAll();
            checkedListBoxCursos.DisplayMember = "CourseName";
            checkedListBoxCursos.ValueMember = "CourseId";

            comboBoxEstado.DataSource = negocioEstados.SelectAll();
            comboBoxEstado.DisplayMember = "StatusName";
            comboBoxEstado.ValueMember = "StatusId";

            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkedListBoxCursos.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Seleccione al menos un curso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int estudianteId = Convert.ToInt32(comboBoxEstudiante.SelectedValue);
                int estadoId = Convert.ToInt32(comboBoxEstado.SelectedValue);
                int cursosInsertados = 0;

                foreach (CE_Cursos curso in checkedListBoxCursos.CheckedItems)
                {
                    try
                    {
                        CE_Registros registro = new CE_Registros();
                        registro.RegistrationStudentId = estudianteId;
                        registro.RegistrationCourseId = curso.CourseId;
                        registro.RegistrationStatusId = estadoId;
                        negocio.Insert(registro);
                        cursosInsertados++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Curso {curso.CourseName}: {ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                if (cursosInsertados > 0)
                {
                    MessageBox.Show($"{cursosInsertados} registro(s) agregado(s) correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
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
