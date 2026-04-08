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
    public partial class AgregarPagos : Form
    {
        CN_Pagos negocio = new CN_Pagos();
        CN_Estudiantes negocioEstudiantes = new CN_Estudiantes();
        CN_Estados negocioEstados = new CN_Estados();
        private CE_Pagos pagoEditar = null;
        public AgregarPagos(CE_Pagos pago = null)
        {
            InitializeComponent();
            EduGestion.FormStyles.ApplyCompactStyle(this);
            pagoEditar = pago;
        }

        private void AgregarPagos_Load(object sender, EventArgs e)
        {
            comboBoxEstudiante.DataSource = negocioEstudiantes.SelectAll();
            comboBoxEstudiante.DisplayMember = "StudentFullName";
            comboBoxEstudiante.ValueMember = "StudentId";

            comboBoxEstado.DataSource = negocioEstados.SelectAll();
            comboBoxEstado.DisplayMember = "StatusName";
            comboBoxEstado.ValueMember = "StatusId";

            if (pagoEditar != null)
            {
                this.Text = "Editar Pago";
                comboBoxEstudiante.SelectedValue = pagoEditar.PaymentStudentId;
                textBoxMonto.Text = pagoEditar.PaymentAmount.ToString();
                comboBoxEstado.SelectedValue = pagoEditar.PaymentStatusId;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CE_Pagos pago = new CE_Pagos();
                pago.PaymentStudentId = Convert.ToInt32(comboBoxEstudiante.SelectedValue);
                pago.PaymentAmount = Convert.ToDecimal(textBoxMonto.Text);
                pago.PaymentStatusId = Convert.ToInt32(comboBoxEstado.SelectedValue);

                if (pagoEditar != null)
                {
                    pago.PaymentId = pagoEditar.PaymentId;
                    negocio.Update(pago);
                    MessageBox.Show("Pago actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    negocio.Insert(pago);
                    MessageBox.Show("Pago agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
