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
    public partial class FrmMovimientos : Form
    {
        private home FrmHome;
        public FrmMovimientos(home home)
        {
            InitializeComponent();
            this.FrmHome = home;
        }

        private void FrmMovimientos_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        public void CargarUsuarios()
        {
            var getMovimientos = new OperacionesBitacora();
            var dsBita = new DataSet();

            dsBita = getMovimientos.ObtenerMovimientos();

            if (dsBita.Tables[0].Rows.Count != 0)
            {
                GvMovimientos.DataSource = dsBita.Tables[0];
                GvMovimientos.Refresh();
            }
            else
            {
                MessageBox.Show("No existen Movimientos: ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
