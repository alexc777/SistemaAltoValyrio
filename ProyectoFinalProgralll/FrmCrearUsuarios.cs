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
    public partial class FrmCrearUsuarios : Form
    {
        private home FrmHome;
        public FrmCrearUsuarios(home home)
        {
            InitializeComponent();
            this.FrmHome = home;
        }

        private void FrmCrearUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'altoValirioDataSet.Roles' Puede moverla o quitarla según sea necesario.
            this.rolesTableAdapter.Fill(this.altoValirioDataSet.Roles);
            // TODO: esta línea de código carga datos en la tabla 'altoValirioDataSet.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.altoValirioDataSet.Bodega);


        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            var operaciones = new OperacionesUsuario();


            if (txtPass1.Text == txtPass2.Text)
            {
                var miUsuario = new Usuarios
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Correo = txtCorreo.Text,
                    Contrasenia = txtPass1.Text,
                    Id_bodega = Convert.ToInt32(selectBodega.SelectedValue),
                    Id_rol = Convert.ToInt32(selectRol.SelectedValue)
                };

                operaciones.CrearUsuario(miUsuario);
                MessageBox.Show("El Usuario "+ txtCorreo.Text + " fue creado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Clear();
                txtApellido.Clear();
                txtCorreo.Clear();
                txtPass1.Clear();
                txtPass2.Clear();
                    

            } else
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
