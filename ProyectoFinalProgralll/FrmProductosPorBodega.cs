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
    public partial class FrmProductosPorBodega : Form
    {
        private home FrmHome;
        public FrmProductosPorBodega(home home)
        {
            InitializeComponent();
            this.FrmHome = home;
        }

        private void FrmProductosPorBodega_Load(object sender, EventArgs e)
        {
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

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            CargarProductos(Convert.ToInt32(selectBodega.SelectedValue));
        }
    }
}
