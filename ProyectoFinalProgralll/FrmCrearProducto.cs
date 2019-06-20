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
    public partial class FrmCrearProducto : Form
    {
        private home FrmHome;
        public FrmCrearProducto(home home)
        {
            InitializeComponent();
            this.FrmHome = home;
        }

        //https://stackoverflow.com/questions/13711358/datetime-picker-c-sharp-format
    }
}
