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
    public partial class AgregarCalificaciones : Form
    {
        CN_Calificaciones negocio = new CN_Calificaciones();
        CN_Registros negocioRegistros = new CN_Registros();
        CN_Estados negocioEstados = new CN_Estados();
        private CE_Calificaciones calificacionEditar = null;
        public AgregarCalificaciones(CE_Calificaciones calificacion = null)
        {
            InitializeComponent();
            EduGestion.FormStyles.ApplyCompactStyle(this);
            calificacionEditar = calificacion;
        }

        private void AgregarCalificaciones_Load(object sender, EventArgs e)
        {
            comboBoxRegistro.DataSource = negocioRegistros.SelectAll();
            comboBoxRegistro.DisplayMember = "StudentFullName";
            comboBoxRegistro.ValueMember = "RegistrationId";

            comboBoxEstado.DataSource = negocioEstados.SelectAll();
            comboBoxEstado.DisplayMember = "StatusName";
            comboBoxEstado.ValueMember = "StatusId";

            if (calificacionEditar != null)
            {
                this.Text = "Editar Calificacion";
                comboBoxRegistro.SelectedValue = calificacionEditar.CalificationRegistrationId;
                textBoxNota.Text = calificacionEditar.CalificationScore.ToString();
                comboBoxEstado.SelectedValue = calificacionEditar.CalificationStatusId;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CE_Calificaciones calificacion = new CE_Calificaciones();
                calificacion.CalificationRegistrationId = Convert.ToInt32(comboBoxRegistro.SelectedValue);
                calificacion.CalificationScore = Convert.ToDecimal(textBoxNota.Text);
                calificacion.CalificationStatusId = Convert.ToInt32(comboBoxEstado.SelectedValue);

                if (calificacionEditar != null)
                {
                    calificacion.CalificationId = calificacionEditar.CalificationId;
                    negocio.Update(calificacion);
                    MessageBox.Show("Calificacion actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    negocio.Insert(calificacion);
                    MessageBox.Show("Calificacion agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
