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
    public partial class FrmLogsMarca : Form
    {
        private home FrmHome;
        public FrmLogsMarca(home home)
        {
            InitializeComponent();
            this.FrmHome = home;
            CargarLogs();
        }

        public void CargarLogs()
        {
            var getLog = new OperacionesMarcaLog();
            var dsLogs = new DataSet();

            dsLogs = getLog.ObtenerLogs();

            if (dsLogs.Tables[0].Rows.Count != 0)
            {
                GvLog.DataSource = dsLogs.Tables[0];
                GvLog.Refresh();
            }
            else
            {
                MessageBox.Show("No existen Registros: ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
