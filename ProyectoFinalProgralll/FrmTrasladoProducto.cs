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
    public partial class FrmTrasladoProducto : Form
    {
        private home FrmHome;
        public FrmTrasladoProducto(home home)
        {
            InitializeComponent();
            this.FrmHome = home;
        }

        private void FrmTrasladoProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'altoValirioDataSet1.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.altoValirioDataSet1.Bodega);
            // TODO: esta línea de código carga datos en la tabla 'altoValirioDataSet1.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.altoValirioDataSet1.Categoria);
            groupBox1.Visible = false;
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            var producto = ProductoCategoria();
            LlenarCamposFormulario(producto);
            groupBox1.Enabled = true;
            groupBox1.Visible = true;
        }

        public DataSet ProductoCategoria()
        {
            var operaciones = new OperacionesProductos();
            var dsProducto = new DataSet();

            dsProducto = operaciones.ProductoCategoria(Convert.ToInt32(selectCategoria.SelectedValue));

            if (dsProducto.Tables[0].Rows.Count != 0)
            {
                return dsProducto;
            }
            else
            {
                MessageBox.Show("No existen Productos con esta categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdProducto.Clear();
                txtNombre.Clear();
                txtCantidad.Clear();
                return dsProducto;
            }
        }

        private void LlenarCamposFormulario(DataSet dsProducto)
        {
            foreach (DataRow informacion in dsProducto.Tables[0].Rows)
            {
                txtIdProducto.Text = informacion["Id"].ToString();
                txtNombre.Text = informacion["Nombre"].ToString();
                txtCantidad.Text = informacion["Cantidad"].ToString();
            }
        }

        private void Btn_Trasladar_Click(object sender, EventArgs e)
        {
            var operaciones = new OperacionesProductos();
            int stock = int.Parse(txtCantidad.Text);
            int canActual = 0;
            int idUsuarioOpero = FrmHome.IdUsuario;
            if (txtCanTraslado.Text != "")
            {
                int canTras = int.Parse(txtCanTraslado.Text);

                if (stock >= canTras)
                {
                    canActual = stock - canTras;

                    var miProdBodega = new ProductoBodega
                    {
                        Id_producto = int.Parse(txtIdProducto.Text),
                        Id_bodega = Convert.ToInt32(selectBodega.SelectedValue),
                        Cantidad_inicial = canTras,
                        Cantidad_actual = canTras,
                    };

                    operaciones.TrasladarProducto(miProdBodega);
                    int idTraslado = operaciones.IdTraslado;

                    var miBitacora = new Vitacora
                    {
                        Id_usuario = idUsuarioOpero,
                        Tipo_operacion = "Ingreso",
                        Fecha = DateTime.Now,
                        Id_productoBodega = idTraslado
                    };

                    operaciones.RegistroBitacora(miBitacora);

                    operaciones.ActualizarProductoTraslado(int.Parse(txtIdProducto.Text), canActual);

                    MessageBox.Show("Traslado Exitoso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdProducto.Clear();
                    txtNombre.Clear();
                    txtCantidad.Clear();
                    txtCanTraslado.Clear();
                    groupBox1.Visible = false;
                }
                else
                {
                    MessageBox.Show("Estas excediendo la cantidad disponible", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
