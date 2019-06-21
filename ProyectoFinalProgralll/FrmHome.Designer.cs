namespace ProyectoFinalProgralll
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearBodegasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.categoriaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuariosToolStripMenuItem,
            this.crearBodegasToolStripMenuItem,
            this.listadoUsuariosToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // crearUsuariosToolStripMenuItem
            // 
            this.crearUsuariosToolStripMenuItem.Name = "crearUsuariosToolStripMenuItem";
            this.crearUsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearUsuariosToolStripMenuItem.Text = "Crear Usuarios";
            this.crearUsuariosToolStripMenuItem.Click += new System.EventHandler(this.crearUsuariosToolStripMenuItem_Click);
            // 
            // crearBodegasToolStripMenuItem
            // 
            this.crearBodegasToolStripMenuItem.Name = "crearBodegasToolStripMenuItem";
            this.crearBodegasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearBodegasToolStripMenuItem.Text = "Crear Bodegas";
            this.crearBodegasToolStripMenuItem.Click += new System.EventHandler(this.crearBodegasToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearProductoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.buscarProductoToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // crearProductoToolStripMenuItem
            // 
            this.crearProductoToolStripMenuItem.Name = "crearProductoToolStripMenuItem";
            this.crearProductoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.crearProductoToolStripMenuItem.Text = "Crear Producto";
            this.crearProductoToolStripMenuItem.Click += new System.EventHandler(this.crearProductoToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.editarToolStripMenuItem.Text = "Editar Producto";
            // 
            // buscarProductoToolStripMenuItem
            // 
            this.buscarProductoToolStripMenuItem.Name = "buscarProductoToolStripMenuItem";
            this.buscarProductoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.buscarProductoToolStripMenuItem.Text = "Buscar Producto";
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearMarcaToolStripMenuItem,
            this.buscarMarcaToolStripMenuItem,
            this.editarMarcaToolStripMenuItem,
            this.eliminarMarcaToolStripMenuItem});
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.marcaToolStripMenuItem.Text = "Marca";
            // 
            // crearMarcaToolStripMenuItem
            // 
            this.crearMarcaToolStripMenuItem.Name = "crearMarcaToolStripMenuItem";
            this.crearMarcaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.crearMarcaToolStripMenuItem.Text = "Crear Marca";
            this.crearMarcaToolStripMenuItem.Click += new System.EventHandler(this.crearMarcaToolStripMenuItem_Click);
            // 
            // buscarMarcaToolStripMenuItem
            // 
            this.buscarMarcaToolStripMenuItem.Name = "buscarMarcaToolStripMenuItem";
            this.buscarMarcaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.buscarMarcaToolStripMenuItem.Text = "Buscar Marca";
            // 
            // editarMarcaToolStripMenuItem
            // 
            this.editarMarcaToolStripMenuItem.Name = "editarMarcaToolStripMenuItem";
            this.editarMarcaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.editarMarcaToolStripMenuItem.Text = "Editar Marca";
            // 
            // eliminarMarcaToolStripMenuItem
            // 
            this.eliminarMarcaToolStripMenuItem.Name = "eliminarMarcaToolStripMenuItem";
            this.eliminarMarcaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.eliminarMarcaToolStripMenuItem.Text = "Eliminar Marca";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCategoriaToolStripMenuItem,
            this.buscarCategoriaToolStripMenuItem,
            this.editarCategoriaToolStripMenuItem,
            this.eliminarCategoriaToolStripMenuItem});
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.categoriaToolStripMenuItem.Text = "Categoría";
            // 
            // crearCategoriaToolStripMenuItem
            // 
            this.crearCategoriaToolStripMenuItem.Name = "crearCategoriaToolStripMenuItem";
            this.crearCategoriaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.crearCategoriaToolStripMenuItem.Text = "Crear Categoría";
            this.crearCategoriaToolStripMenuItem.Click += new System.EventHandler(this.crearCategoriaToolStripMenuItem_Click);
            // 
            // buscarCategoriaToolStripMenuItem
            // 
            this.buscarCategoriaToolStripMenuItem.Name = "buscarCategoriaToolStripMenuItem";
            this.buscarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.buscarCategoriaToolStripMenuItem.Text = "Buscar Categoría";
            // 
            // editarCategoriaToolStripMenuItem
            // 
            this.editarCategoriaToolStripMenuItem.Name = "editarCategoriaToolStripMenuItem";
            this.editarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.editarCategoriaToolStripMenuItem.Text = "Editar Categoría";
            // 
            // eliminarCategoriaToolStripMenuItem
            // 
            this.eliminarCategoriaToolStripMenuItem.Name = "eliminarCategoriaToolStripMenuItem";
            this.eliminarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.eliminarCategoriaToolStripMenuItem.Text = "Eliminar Categoría";
            // 
            // listadoUsuariosToolStripMenuItem
            // 
            this.listadoUsuariosToolStripMenuItem.Name = "listadoUsuariosToolStripMenuItem";
            this.listadoUsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listadoUsuariosToolStripMenuItem.Text = "Listado Usuarios";
            this.listadoUsuariosToolStripMenuItem.Click += new System.EventHandler(this.listadoUsuariosToolStripMenuItem_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 387);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Sistema Alto Valirio";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem crearUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearBodegasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProductoToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarMarcaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoUsuariosToolStripMenuItem;
    }
}