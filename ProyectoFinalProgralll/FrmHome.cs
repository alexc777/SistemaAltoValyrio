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
    public partial class home : Form
    {
        private Form1 Form1;
        public int IdUsuario = 0;
        public home(Form1 form1)
        {
            InitializeComponent();
            this.Form1 = form1;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            adminToolStripMenuItem.Visible = false;
            productosToolStripMenuItem.Visible = false;
            marcaToolStripMenuItem.Visible = false;
            categoriaToolStripMenuItem.Visible = false;
            reportesToolStripMenuItem.Visible = false;

            IdUsuario = Form1.IdUsuario;

            if (Form1.miId == 1)
            {
                adminToolStripMenuItem.Enabled = true;
                adminToolStripMenuItem.Visible = true;
                reportesToolStripMenuItem.Enabled = true;
                reportesToolStripMenuItem.Visible = true;
            }
            else if (Form1.miId == 2)
            {
                productosToolStripMenuItem.Enabled = true;
                productosToolStripMenuItem.Visible = true;

                marcaToolStripMenuItem.Enabled = true;
                marcaToolStripMenuItem.Visible = true;

                categoriaToolStripMenuItem.Enabled = true;
                categoriaToolStripMenuItem.Visible = true;
            }
           
        }

        private void crearUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var usuario = new FrmCrearUsuarios(this))
            {
                usuario.ShowDialog();
            }
        }

        private void crearBodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var bodega = new FrmCrearBodegas(this))
            {
                bodega.ShowDialog();
            }
        }

        private void crearMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var marca = new FrmCrearMarca(this))
            {
                marca.ShowDialog();
            }
        }

        private void crearCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var categoria = new FrmCrearCategoria(this))
            {
                categoria.ShowDialog();
            }
        }

        private void crearProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var producto = new FrmCrearProducto(this))
            {
                producto.ShowDialog();
            }
        }

        private void listadoUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var list = new FrmListadoUsuarios(this))
            {
                list.ShowDialog();
            }
        }

        private void trasladarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var tras = new FrmTrasladoProducto(this))
            {
                tras.ShowDialog();
            }
        }

        private void verMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var movimiento = new FrmMovimientos(this))
            {
                movimiento.ShowDialog();
            }
        }

        private void productosPorBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var proBodega = new FrmProductosPorBodega(this))
            {
                proBodega.ShowDialog();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var login = new Form1())
            {
                this.Close();
                login.ShowDialog();
            }
        }

        private void filtrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var filtros = new FrmFiltrarProductos(this))
            {
                filtros.ShowDialog();
            }
        }

        private void listadoMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var marca = new FrmListadoMarcas(this))
            {
                marca.ShowDialog();
            }
        }

        private void listadoCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var categoria = new FrmListadoCategorias(this))
            {
                categoria.ShowDialog();
            }
        }

        private void logsAccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var log = new FrmLogs(this))
            {
                log.ShowDialog();
            }
        }

        private void logUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var logu = new FrmLogUsuarios(this))
            {
                logu.ShowDialog();
            }
        }

        private void logMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var logm = new FrmLogsMarca(this))
            {
                logm.ShowDialog();
            }
        }
    }
}
