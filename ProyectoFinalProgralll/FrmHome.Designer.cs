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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearBodegasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trasladarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMovimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosPorBodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuariosToolStripMenuItem,
            this.crearBodegasToolStripMenuItem,
            this.listadoUsuariosToolStripMenuItem,
            this.listadoMarcasToolStripMenuItem,
            this.listadoCategoriasToolStripMenuItem});
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
            // listadoUsuariosToolStripMenuItem
            // 
            this.listadoUsuariosToolStripMenuItem.Name = "listadoUsuariosToolStripMenuItem";
            this.listadoUsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listadoUsuariosToolStripMenuItem.Text = "Listado Usuarios";
            this.listadoUsuariosToolStripMenuItem.Click += new System.EventHandler(this.listadoUsuariosToolStripMenuItem_Click);
            // 
            // listadoMarcasToolStripMenuItem
            // 
            this.listadoMarcasToolStripMenuItem.Name = "listadoMarcasToolStripMenuItem";
            this.listadoMarcasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listadoMarcasToolStripMenuItem.Text = "Listado Marcas";
            this.listadoMarcasToolStripMenuItem.Click += new System.EventHandler(this.listadoMarcasToolStripMenuItem_Click);
            // 
            // listadoCategoriasToolStripMenuItem
            // 
            this.listadoCategoriasToolStripMenuItem.Name = "listadoCategoriasToolStripMenuItem";
            this.listadoCategoriasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listadoCategoriasToolStripMenuItem.Text = "Listado Categorias";
            this.listadoCategoriasToolStripMenuItem.Click += new System.EventHandler(this.listadoCategoriasToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearProductoToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // crearProductoToolStripMenuItem
            // 
            this.crearProductoToolStripMenuItem.Name = "crearProductoToolStripMenuItem";
            this.crearProductoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearProductoToolStripMenuItem.Text = "Crear Producto";
            this.crearProductoToolStripMenuItem.Click += new System.EventHandler(this.crearProductoToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearMarcaToolStripMenuItem});
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.marcaToolStripMenuItem.Text = "Marca";
            // 
            // crearMarcaToolStripMenuItem
            // 
            this.crearMarcaToolStripMenuItem.Name = "crearMarcaToolStripMenuItem";
            this.crearMarcaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearMarcaToolStripMenuItem.Text = "Crear Marca";
            this.crearMarcaToolStripMenuItem.Click += new System.EventHandler(this.crearMarcaToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCategoriaToolStripMenuItem});
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.categoriaToolStripMenuItem.Text = "Categoría";
            // 
            // crearCategoriaToolStripMenuItem
            // 
            this.crearCategoriaToolStripMenuItem.Name = "crearCategoriaToolStripMenuItem";
            this.crearCategoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearCategoriaToolStripMenuItem.Text = "Crear Categoría";
            this.crearCategoriaToolStripMenuItem.Click += new System.EventHandler(this.crearCategoriaToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trasladarProductoToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // trasladarProductoToolStripMenuItem
            // 
            this.trasladarProductoToolStripMenuItem.Name = "trasladarProductoToolStripMenuItem";
            this.trasladarProductoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.trasladarProductoToolStripMenuItem.Text = "Trasladar Producto";
            this.trasladarProductoToolStripMenuItem.Click += new System.EventHandler(this.trasladarProductoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verMovimientosToolStripMenuItem,
            this.productosPorBodegaToolStripMenuItem,
            this.filtrarProductosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // verMovimientosToolStripMenuItem
            // 
            this.verMovimientosToolStripMenuItem.Name = "verMovimientosToolStripMenuItem";
            this.verMovimientosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.verMovimientosToolStripMenuItem.Text = "Ver Movimientos";
            this.verMovimientosToolStripMenuItem.Click += new System.EventHandler(this.verMovimientosToolStripMenuItem_Click);
            // 
            // productosPorBodegaToolStripMenuItem
            // 
            this.productosPorBodegaToolStripMenuItem.Name = "productosPorBodegaToolStripMenuItem";
            this.productosPorBodegaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.productosPorBodegaToolStripMenuItem.Text = "Productos por Bodega";
            this.productosPorBodegaToolStripMenuItem.Click += new System.EventHandler(this.productosPorBodegaToolStripMenuItem_Click);
            // 
            // filtrarProductosToolStripMenuItem
            // 
            this.filtrarProductosToolStripMenuItem.Name = "filtrarProductosToolStripMenuItem";
            this.filtrarProductosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.filtrarProductosToolStripMenuItem.Text = "Filtrar Productos";
            this.filtrarProductosToolStripMenuItem.Click += new System.EventHandler(this.filtrarProductosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(623, 387);
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
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearMarcaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trasladarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMovimientosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosPorBodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoCategoriasToolStripMenuItem;
    }
}