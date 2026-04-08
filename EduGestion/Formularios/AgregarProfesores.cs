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
    public partial class AgregarProfesores : Form
    {
        CN_Profesores negocio = new CN_Profesores();
        CN_Estados negocioEstados = new CN_Estados();
        private CE_Profesores profesorEditar = null;
        public AgregarProfesores(CE_Profesores profesor = null)
        {
            InitializeComponent();
            EduGestion.FormStyles.ApplyCompactStyle(this);
            profesorEditar = profesor;
        }

        private void AgregarProfesores_Load(object sender, EventArgs e)
        {
            comboBoxEstado.DataSource = negocioEstados.SelectAll();
            comboBoxEstado.DisplayMember = "StatusName";
            comboBoxEstado.ValueMember = "StatusId";

            if (profesorEditar != null)
            {
                this.Text = "Editar Profesor";
                textBoxNombre.Text = profesorEditar.TeacherFullName;
                textBoxCorreo.Text = profesorEditar.TeacherEmail;
                textBoxTelefono.Text = profesorEditar.TeacherPhoneNumber;
                dateTimePickerNacimiento.Value = profesorEditar.TeacherBirthDay;
                comboBoxEstado.SelectedValue = profesorEditar.TeacherStatusId;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CE_Profesores profesor = new CE_Profesores();
                profesor.TeacherFullName = textBoxNombre.Text;
                profesor.TeacherEmail = textBoxCorreo.Text;
                profesor.TeacherPhoneNumber = textBoxTelefono.Text;
                profesor.TeacherBirthDay = dateTimePickerNacimiento.Value;
                profesor.TeacherStatusId = Convert.ToInt32(comboBoxEstado.SelectedValue);

                if (profesorEditar != null)
                {
                    profesor.TeacherId = profesorEditar.TeacherId;
                    negocio.Update(profesor);
                    MessageBox.Show("Profesor actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    negocio.Insert(profesor);
                    MessageBox.Show("Profesor agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
