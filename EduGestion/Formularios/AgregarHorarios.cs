using System;
using System.Windows.Forms;

namespace EduGestion.Formularios
{
    public partial class AgregarHorarios : Form
    {
        public AgregarHorarios()
        {
            InitializeComponent();
            EduGestion.FormStyles.ApplyCompactStyle(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // TODO: Implement save logic
            MessageBox.Show("Horario guardado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
