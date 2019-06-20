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
    public partial class FrmCrearCategoria : Form
    {
        private home FrmHome;
        public FrmCrearCategoria(home home)
        {
            InitializeComponent();
            this.FrmHome = home;
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            var operaciones = new OperacionesMarcaCategoria();

            if (txtNombre.Text != "")
            {
                var miCategoria = new Categoria
                {
                    Nombre = txtNombre.Text,
                    Estado = 1
                };
                operaciones.CrearCategoria(miCategoria);
                MessageBox.Show("La Categoría " + txtNombre.Text + " fue creada exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } else
            {
                MessageBox.Show("Asegurate de haber llenado todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
