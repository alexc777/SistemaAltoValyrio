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
    public partial class FrmListadoCategorias : Form
    {
        private home FrmHome;
        public FrmListadoCategorias(home home)
        {
            InitializeComponent();
            this.FrmHome = home;
        }

        public void CargarCategorias()
        {
            var geCategorias = new OperacionesMarcaCategoria();
            var dsCate = new DataSet();

            dsCate = geCategorias.ObtenerCategorias();

            if (dsCate.Tables[0].Rows.Count != 0)
            {
                GvCategorias.DataSource = dsCate.Tables[0];
                GvCategorias.Refresh();
            }
            else
            {
                MessageBox.Show("No existen Categorías: ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmListadoCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            var operacione = new OperacionesMarcaCategoria();
            var dsCate = new DataSet();

            var miCate = new Categoria
            {
                Nombre = txtNombre.Text,
            };

            operacione.EditarCategoria(miCate, int.Parse(txtIdUser.Text));
            CargarCategorias();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            var operacion = new OperacionesMarcaCategoria();
            var dsCate = new DataSet();

            if (txtNombre.Text != "")
            {
                dsCate = operacion.BuscarCategoria(txtNombre.Text);

                if (dsCate.Tables[0].Rows.Count != 0)
                {
                    foreach (DataRow informacion in dsCate.Tables[0].Rows)
                    {
                        txtIdUser.Text = informacion["Id"].ToString();
                        txtNombre.Text = informacion["Nombre"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No existe la Categoria: " + txtNombre.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                }
            }
            else
            {
                MessageBox.Show("Ingresa el Nombre para buscar:", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
