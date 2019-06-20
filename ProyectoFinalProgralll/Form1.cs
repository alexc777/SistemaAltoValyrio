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
    public partial class Form1 : Form
    {
        public int miId = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dsUsuario = new DataSet();
            var operacion = new Login();

            dsUsuario = operacion.LoginUsuario(txtCorreo.Text, txtCotrasenia.Text);


            if (dsUsuario.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show("Usuario Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                miId = ReturnIdRol(dsUsuario);
                using (var mhome = new home(this))
                {
                    mhome.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int ReturnIdRol(DataSet usuario)
        {
            var dsRol = usuario;
            string strIdRol = "";
            int idRol = 0;

            if (dsRol.Tables[0].Rows.Count != 0)
            {
                foreach (DataRow idCafe in dsRol.Tables[0].Rows)
                {
                    strIdRol = idCafe["Id_rol"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Id rol no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            idRol = int.Parse(strIdRol);

            return idRol;
        }
    }
}
