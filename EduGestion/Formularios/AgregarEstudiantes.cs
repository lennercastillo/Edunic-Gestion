using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using System.Windows.Forms;
using Capa_Negocio;
using System.Windows.Media.Animation;


namespace EduGestion
{
    public partial class AgregarEstudiantes : Form
    {
        CN_Estudiantes negocio = new CN_Estudiantes();
        CN_Estados negocioEstado = new CN_Estados();
        private CE_Estudiantes estudianteEditar = null;
        public AgregarEstudiantes(CE_Estudiantes estuadiante = null)
        {
            InitializeComponent();
            EduGestion.FormStyles.ApplyCompactStyle(this);
            estudianteEditar = estuadiante;
        }

        private void AgregarEstudiantes_Load(object sender, EventArgs e)
        {
            comboBoxEstado.DataSource = negocioEstado.SelectAll();
            comboBoxEstado.DisplayMember = "StatusName";
            comboBoxEstado.ValueMember = "StatusId";

            if (estudianteEditar != null)
            {
                this.Text = "Editar Estudiante";
                textBoxNombre.Text = estudianteEditar.StudentFullName;
                textBoxCorreo.Text = estudianteEditar.StudentEmail;
                textBoxTelefono.Text = estudianteEditar.StudentPhoneNumber;
                dateTimePickerNacimiento.Value = estudianteEditar.StudentBirthDay;
                comboBoxEstado.SelectedValue = estudianteEditar.StudentStatusId;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CE_Estudiantes estudiante = new CE_Estudiantes();
                estudiante.StudentFullName = textBoxNombre.Text;
                estudiante.StudentEmail = textBoxCorreo.Text;
                estudiante.StudentPhoneNumber = textBoxTelefono.Text;
                estudiante.StudentBirthDay = dateTimePickerNacimiento.Value;
                estudiante.StudentStatusId = Convert.ToInt32(comboBoxEstado.SelectedValue);

                if (estudianteEditar != null)
                {
                    
                    estudiante.StudentId = estudianteEditar.StudentId;
                    negocio.Update(estudiante);
                    MessageBox.Show("Estudiante actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    
                    negocio.Insert(estudiante);
                    MessageBox.Show("Estudiante agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
