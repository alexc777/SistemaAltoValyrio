using ProyectoFinalProgralll.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalProgralll
{
    public partial class FrmCrearBodegas : Form
    {
        private home FrmHome;
        public FrmCrearBodegas(home home)
        {
            InitializeComponent();
            this.FrmHome = home;
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            var operaciones = new OperacionesBodega();

            if (txtNombre.Text != "" && txtDireccion.Text != "")
            {
                var miBodega = new Bodega
                {
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text,
                    Estado = 1
                };
                operaciones.CrearBodega(miBodega);
                MessageBox.Show("La Bodega " + txtNombre.Text + " fue creada exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Clear();
                txtDireccion.Clear();
            } else
            {
                MessageBox.Show("Asegurate de haber llenado todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
