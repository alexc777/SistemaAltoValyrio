using ProyectoFinalProgralll.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalProgralll
{
    public partial class FrmCrearProducto : Form
    {
        private home FrmHome;
        public FrmCrearProducto(home home)
        {
            InitializeComponent();
            this.FrmHome = home;
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            var operaciones = new OperacionesProductos();
            int EstadoRefri = 0;

            //Para vitacora
            int IdUsuario = FrmHome.IdUsuario;

            if (selectRefri.Text == "No")
            {
                EstadoRefri = 1;
            }
            else if (selectRefri.Text == "Si")
            {
                EstadoRefri = 2;
            }

            var miProducto = new Productos
            {
                Nombre = txtNombre.Text,
                Precio = double.Parse(txtPrecio.Text),
                Id_marca = Convert.ToInt32(selectMarca.SelectedValue),
                Id_categoria = Convert.ToInt32(selectCategoria.SelectedValue),
                Refrigerado = EstadoRefri,
                Fecha_vence = dateFechaVence.Value,
                TipoEmpaque = Convert.ToInt32(selectEmpaque.SelectedValue),
                Fecha_creo = DateTime.Now,
                Cantidad = int.Parse(txtCantidad.Text)
            };

            operaciones.CrearProducto(miProducto);
            int Id = operaciones.idProdCrate;
            MessageBox.Show("El Producto " + txtNombre.Text + " fue creado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();

            var miHubicacion = new HubicacionProducto
            {
                Id_producto = Id,
                Id_bodega = Convert.ToInt32(selectBodega.SelectedValue),
                Fecha = DateTime.Now
            };
            operaciones.GuardarHubiProducto(miHubicacion);
            MessageBox.Show("Hubicación guardada " + Id + " exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FrmCrearProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'altoValirioDataSet1.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.altoValirioDataSet1.Bodega);
            // TODO: esta línea de código carga datos en la tabla 'altoValirioDataSet1.Empaque' Puede moverla o quitarla según sea necesario.
            this.empaqueTableAdapter.Fill(this.altoValirioDataSet1.Empaque);
            // TODO: esta línea de código carga datos en la tabla 'altoValirioDataSet1.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.altoValirioDataSet1.Categoria);
            // TODO: esta línea de código carga datos en la tabla 'altoValirioDataSet1.Marca' Puede moverla o quitarla según sea necesario.
            this.marcaTableAdapter.Fill(this.altoValirioDataSet1.Marca);
            dateFechaVence.Format = DateTimePickerFormat.Custom;
            dateFechaVence.CustomFormat = "dd-MM-yyyy HH:mm:ss";

            List<object> ListRefri = new List<object>();
            ListRefri.Add("Si");
            ListRefri.Add("No");
            selectRefri.DataSource = ListRefri;
        }
    }
}
