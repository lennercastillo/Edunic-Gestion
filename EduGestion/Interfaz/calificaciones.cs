using Capa_Entidad;
using Capa_Negocio;
using EduGestion.Formularios;
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
    public partial class calificaciones : Form
    {
        CN_Calificaciones negocio = new CN_Calificaciones();

        public calificaciones()
        {
            InitializeComponent();
        }

        private void calificaciones_Load(object sender, EventArgs e)
        {
            CargarDatos();
            UIHelper.AplicarEstiloFormulario(this);
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = negocio.SelectAll();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCalificaciones frm = new AgregarCalificaciones();
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una calificacion para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CE_Calificaciones calificacion = (CE_Calificaciones)dataGridView1.SelectedRows[0].DataBoundItem;
            AgregarCalificaciones frm = new AgregarCalificaciones(calificacion);
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una calificacion para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["calificationId"].Value);

            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar esta calificacion?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    negocio.Delete(id);
                    MessageBox.Show("Calificacion eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
