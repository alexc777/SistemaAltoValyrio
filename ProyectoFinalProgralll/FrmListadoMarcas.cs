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
    public partial class FrmListadoMarcas : Form
    {
        private home FrmHome;
        public FrmListadoMarcas(home home)
        {
            InitializeComponent();
            this.FrmHome = home;
        }

        public void CargarMarcas()
        {
            var getMarcas = new OperacionesMarcaCategoria();
            var dsMarca = new DataSet();

            dsMarca = getMarcas.ObtenerMarcas();

            if (dsMarca.Tables[0].Rows.Count != 0)
            {
                GvUsuarios.DataSource = dsMarca.Tables[0];
                GvUsuarios.Refresh();
            }
            else
            {
                MessageBox.Show("No existen Marcas: ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmListadoMarcas_Load(object sender, EventArgs e)
        {
            CargarMarcas();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            var operacion = new OperacionesMarcaCategoria();
            var dsMarca = new DataSet();

            if (txtNombre.Text != "")
            {
                dsMarca = operacion.BuscarMarca(txtNombre.Text);

                if (dsMarca.Tables[0].Rows.Count != 0)
                {
                    foreach (DataRow informacion in dsMarca.Tables[0].Rows)
                    {
                        txtIdUser.Text = informacion["Id"].ToString();
                        txtNombre.Text = informacion["Nombre"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No existe la marca: " + txtNombre.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                }
            } else
            {
                MessageBox.Show("Ingresa el Nombre para buscar:", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            var operacione = new OperacionesMarcaCategoria();
            var dsMarca = new DataSet();

            var miMarca = new Marca
            {
                Nombre = txtNombre.Text,
            };

            operacione.EditarMarca(miMarca, int.Parse(txtIdUser.Text));
            CargarMarcas();
        }
    }
}
