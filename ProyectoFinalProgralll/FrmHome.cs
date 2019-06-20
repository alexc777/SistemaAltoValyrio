﻿using System;
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

            if (Form1.miId == 1)
            {
                adminToolStripMenuItem.Enabled = true;
                adminToolStripMenuItem.Visible = true;
            }
            else if (Form1.miId == 2)
            {
                productosToolStripMenuItem.Enabled = true;
                productosToolStripMenuItem.Visible = true;
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
    }
}
