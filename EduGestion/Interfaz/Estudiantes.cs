using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Dato;
using Capa_Entidad;
using Capa_Negocio;
using System.Windows.Forms;



namespace EduGestion
{
    public partial class Estudiantes : Form
    {

        CN_Estudiantes negocio = new CN_Estudiantes();
        public Estudiantes()
        {
            InitializeComponent();
        }

        private void Estudiantes_Load(object sender, EventArgs e)
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
            AgregarEstudiantes frm = new AgregarEstudiantes();
            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciones un estudiante para eliminar.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["StudentId"].Value);

            DialogResult resultado = MessageBox.Show("Estas seguro de eliminar este estudiantes?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {

                try
                {
                    negocio.Delete(id);
                    MessageBox.Show("Estudiant eliminado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un estudiante para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CE_Estudiantes estudiante = (CE_Estudiantes)dataGridView1.SelectedRows[0].DataBoundItem;
            AgregarEstudiantes frm = new AgregarEstudiantes(estudiante);
            frm.ShowDialog();
            CargarDatos();
        }
    }
}

