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
    public partial class FrmListadoUsuarios : Form
    {
        private home FrmHome;

        public FrmListadoUsuarios(home home)
        {
            InitializeComponent();
            this.FrmHome = home;
        }

        private void FrmListadoUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        public void CargarUsuarios()
        {
            var getUsers = new OperacionesUsuario();
            var dsUsers = new DataSet();

            dsUsers = getUsers.ObtenerUsuarios();

            if (dsUsers.Tables[0].Rows.Count != 0)
            {
                GvUsuarios.DataSource = dsUsers.Tables[0];
                GvUsuarios.Refresh();
            }
            else
            {
                MessageBox.Show("No existen Usuarios: ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            var operacion = new OperacionesUsuario();
            var dsUsuario = new DataSet();

            if (txtCorreo.Text != "")
            {
                dsUsuario = operacion.BuscarUsuario(txtCorreo.Text);

                if (dsUsuario.Tables[0].Rows.Count != 0)
                {
                    LlenarCamposFormulario(dsUsuario);
                }
                else
                {
                    MessageBox.Show("No existe el usuario con el correo: " + txtCorreo.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCorreo.Clear();
                }
            }
            else if (txtNombre.Text != "")
            {
                dsUsuario = operacion.BuscarUsuarioNombre(txtNombre.Text);

                if (dsUsuario.Tables[0].Rows.Count != 0)
                {
                    LlenarCamposFormularioNom(dsUsuario);
                }
                else
                {
                    MessageBox.Show("No existe el usuario con el Nombre: " + txtNombre.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCorreo.Clear();
                }
            }
            else if (txtNombre.Text != "" && txtCorreo.Text != "")
            {
                MessageBox.Show("Solo puedes buscar por Nombre o Correo por separado:", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Ingresa el Nombre o Correo para buscar:", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LlenarCamposFormulario(DataSet dsUsuario)
        {
            foreach (DataRow informacion in dsUsuario.Tables[0].Rows)
            {
                txtNombre.Text = informacion["Nombre"].ToString();
                txtApellido.Text = informacion["Apellido"].ToString();
                txtPass1.Text = informacion["Contrasenia"].ToString();
            }
        }

        private void LlenarCamposFormularioNom(DataSet dsUsuario)
        {
            foreach (DataRow informacion in dsUsuario.Tables[0].Rows)
            {
                txtCorreo.Text = informacion["Correo"].ToString();
                txtApellido.Text = informacion["Apellido"].ToString();
                txtPass1.Text = informacion["Contrasenia"].ToString();
            }
        }

        /*
         *  SELECT Productos.Nombre, Productos.Precio, Marca.Nombre as 'Marca', Categoria.Nombre as 'Categoria', Productos.Refrigerado, 
            Productos.Fecha_vence as 'Vence', Empaque.Tipo as 'Tipo Empaque',Productos.Cantidad FROM Productos
            INNER JOIN Marca ON Productos.Id_marca = Marca.Id
            INNER JOIN Categoria ON Productos.Id_categoria = Categoria.Id
            INNER JOIN Empaque ON Productos.TipoEmpaque = Empaque.Id

        SELECT * FROM Productos ORDER BY Productos.Fecha_creo ASC
         * 
         */
    }
}
