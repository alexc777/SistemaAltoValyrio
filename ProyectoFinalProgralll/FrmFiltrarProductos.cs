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
    public partial class FrmFiltrarProductos : Form
    {
        private home FrmHome;
        public FrmFiltrarProductos(home home)
        {
            InitializeComponent();
            this.FrmHome = home;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void selectBodega_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmFiltrarProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'altoValirioDataSet1.Marca' Puede moverla o quitarla según sea necesario.
            this.marcaTableAdapter.Fill(this.altoValirioDataSet1.Marca);
            // TODO: esta línea de código carga datos en la tabla 'altoValirioDataSet1.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.altoValirioDataSet1.Categoria);
            // TODO: esta línea de código carga datos en la tabla 'altoValirioDataSet1.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.altoValirioDataSet1.Bodega);
            CargarProductos();

        }

        public void CargarProductos()
        {
            var getProductos = new OperacionesReportes();
            var dsProductos = new DataSet();

            dsProductos = getProductos.ObtenerProductos();

            if (dsProductos.Tables[0].Rows.Count != 0)
            {
                GvProductosBodega.DataSource = dsProductos.Tables[0];
                GvProductosBodega.Refresh();
            }
            else
            {
                MessageBox.Show("No hay registro de productos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            var bodega = Convert.ToInt32(selectBodega.SelectedValue);
            var categoria = Convert.ToInt32(selectCategoria.SelectedValue);
            var marca = Convert.ToInt32(selectMarca.SelectedValue);

            if (bodega != 0 && categoria != 0 && marca != 0)
            {
                CargarProductos(marca,categoria,bodega);
            }else
            {
                MessageBox.Show("Otro filtro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void CargarProductos(int idBodega)
        {
            var getProductosBo = new OperacionesReportes();
            var dsProductosBo = new DataSet();

            dsProductosBo = getProductosBo.ObtenerProductos(idBodega);

            if (dsProductosBo.Tables[0].Rows.Count != 0)
            {
                GvProductosBodega.DataSource = dsProductosBo.Tables[0];
                GvProductosBodega.Refresh();
            }
            else
            {
                MessageBox.Show("No hay registro de productos en esta bodega", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void CargarProductosCate(int categoria)
        {
            var getProductosBo = new OperacionesReportes();
            var dsProductosBo = new DataSet();

            dsProductosBo = getProductosBo.ObtenerProductosCategorias(categoria);

            if (dsProductosBo.Tables[0].Rows.Count != 0)
            {
                GvProductosBodega.DataSource = dsProductosBo.Tables[0];
                GvProductosBodega.Refresh();
            }
            else
            {
                MessageBox.Show("No hay registro de productos con esta categoría", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void CargarProductosMarca(int marca)
        {
            var getProductosBo = new OperacionesReportes();
            var dsProductosBo = new DataSet();

            dsProductosBo = getProductosBo.ObtenerProductosMarca(marca);

            if (dsProductosBo.Tables[0].Rows.Count != 0)
            {
                GvProductosBodega.DataSource = dsProductosBo.Tables[0];
                GvProductosBodega.Refresh();
            }
            else
            {
                MessageBox.Show("No hay registro de productos con esta marca", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void CargarProductos(int Id_marca, int Id_Categoria, int Id_bodega)
        {
            var getProductosBo = new OperacionesReportes();
            var dsProductosBo = new DataSet();

            dsProductosBo = getProductosBo.ObtenerProductos(Id_marca, Id_Categoria, Id_bodega);

            if (dsProductosBo.Tables[0].Rows.Count != 0)
            {
                GvProductosBodega.DataSource = dsProductosBo.Tables[0];
                GvProductosBodega.Refresh();
            }
            else
            {
                MessageBox.Show("No hay registro de productos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
