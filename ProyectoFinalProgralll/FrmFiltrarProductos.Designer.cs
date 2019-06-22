namespace ProyectoFinalProgralll
{
    partial class FrmFiltrarProductos
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
            this.components = new System.ComponentModel.Container();
            this.GvProductosBodega = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectMarca = new System.Windows.Forms.ComboBox();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.altoValirioDataSet1 = new ProyectoFinalProgralll.AltoValirioDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.selectCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.selectBodega = new System.Windows.Forms.ComboBox();
            this.bodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bodegaTableAdapter = new ProyectoFinalProgralll.AltoValirioDataSet1TableAdapters.BodegaTableAdapter();
            this.categoriaTableAdapter = new ProyectoFinalProgralll.AltoValirioDataSet1TableAdapters.CategoriaTableAdapter();
            this.marcaTableAdapter = new ProyectoFinalProgralll.AltoValirioDataSet1TableAdapters.MarcaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GvProductosBodega)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altoValirioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GvProductosBodega
            // 
            this.GvProductosBodega.BackgroundColor = System.Drawing.Color.DarkRed;
            this.GvProductosBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvProductosBodega.Location = new System.Drawing.Point(182, 12);
            this.GvProductosBodega.Name = "GvProductosBodega";
            this.GvProductosBodega.Size = new System.Drawing.Size(606, 271);
            this.GvProductosBodega.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.selectMarca);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.selectCategoria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnFiltrar);
            this.groupBox1.Controls.Add(this.selectBodega);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 271);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Marca";
            // 
            // selectMarca
            // 
            this.selectMarca.DataSource = this.marcaBindingSource;
            this.selectMarca.DisplayMember = "Nombre";
            this.selectMarca.FormattingEnabled = true;
            this.selectMarca.Location = new System.Drawing.Point(5, 139);
            this.selectMarca.Name = "selectMarca";
            this.selectMarca.Size = new System.Drawing.Size(143, 21);
            this.selectMarca.TabIndex = 5;
            this.selectMarca.ValueMember = "Id";
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "Marca";
            this.marcaBindingSource.DataSource = this.altoValirioDataSet1;
            // 
            // altoValirioDataSet1
            // 
            this.altoValirioDataSet1.DataSetName = "AltoValirioDataSet1";
            this.altoValirioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoría";
            // 
            // selectCategoria
            // 
            this.selectCategoria.DataSource = this.categoriaBindingSource;
            this.selectCategoria.DisplayMember = "Nombre";
            this.selectCategoria.FormattingEnabled = true;
            this.selectCategoria.Location = new System.Drawing.Point(5, 87);
            this.selectCategoria.Name = "selectCategoria";
            this.selectCategoria.Size = new System.Drawing.Size(143, 21);
            this.selectCategoria.TabIndex = 3;
            this.selectCategoria.ValueMember = "Id";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.altoValirioDataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bodega";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.BackColor = System.Drawing.Color.Black;
            this.BtnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrar.Location = new System.Drawing.Point(36, 202);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(81, 34);
            this.BtnFiltrar.TabIndex = 1;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = false;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // selectBodega
            // 
            this.selectBodega.DataSource = this.bodegaBindingSource;
            this.selectBodega.DisplayMember = "Nombre";
            this.selectBodega.FormattingEnabled = true;
            this.selectBodega.Location = new System.Drawing.Point(5, 38);
            this.selectBodega.Name = "selectBodega";
            this.selectBodega.Size = new System.Drawing.Size(143, 21);
            this.selectBodega.TabIndex = 0;
            this.selectBodega.ValueMember = "Id";
            this.selectBodega.SelectedIndexChanged += new System.EventHandler(this.selectBodega_SelectedIndexChanged);
            // 
            // bodegaBindingSource
            // 
            this.bodegaBindingSource.DataMember = "Bodega";
            this.bodegaBindingSource.DataSource = this.altoValirioDataSet1;
            // 
            // bodegaTableAdapter
            // 
            this.bodegaTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // marcaTableAdapter
            // 
            this.marcaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmFiltrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 307);
            this.Controls.Add(this.GvProductosBodega);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmFiltrarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtrar Productos";
            this.Load += new System.EventHandler(this.FrmFiltrarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvProductosBodega)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altoValirioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GvProductosBodega;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.ComboBox selectBodega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectCategoria;
        private AltoValirioDataSet1 altoValirioDataSet1;
        private System.Windows.Forms.BindingSource bodegaBindingSource;
        private AltoValirioDataSet1TableAdapters.BodegaTableAdapter bodegaTableAdapter;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private AltoValirioDataSet1TableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private AltoValirioDataSet1TableAdapters.MarcaTableAdapter marcaTableAdapter;
    }
}