namespace ProyectoFinalProgralll
{
    partial class FrmProductosPorBodega
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.selectBodega = new System.Windows.Forms.ComboBox();
            this.bodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.altoValirioDataSet1 = new ProyectoFinalProgralll.AltoValirioDataSet1();
            this.GvProductosBodega = new System.Windows.Forms.DataGridView();
            this.bodegaTableAdapter = new ProyectoFinalProgralll.AltoValirioDataSet1TableAdapters.BodegaTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altoValirioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvProductosBodega)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnFiltrar);
            this.groupBox1.Controls.Add(this.selectBodega);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar Por Bodega";
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.BackColor = System.Drawing.Color.Black;
            this.BtnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrar.Location = new System.Drawing.Point(42, 47);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(75, 23);
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
            this.selectBodega.Location = new System.Drawing.Point(7, 20);
            this.selectBodega.Name = "selectBodega";
            this.selectBodega.Size = new System.Drawing.Size(143, 21);
            this.selectBodega.TabIndex = 0;
            this.selectBodega.ValueMember = "Id";
            // 
            // bodegaBindingSource
            // 
            this.bodegaBindingSource.DataMember = "Bodega";
            this.bodegaBindingSource.DataSource = this.altoValirioDataSet1;
            // 
            // altoValirioDataSet1
            // 
            this.altoValirioDataSet1.DataSetName = "AltoValirioDataSet1";
            this.altoValirioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GvProductosBodega
            // 
            this.GvProductosBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvProductosBodega.Location = new System.Drawing.Point(182, 13);
            this.GvProductosBodega.Name = "GvProductosBodega";
            this.GvProductosBodega.Size = new System.Drawing.Size(606, 271);
            this.GvProductosBodega.TabIndex = 1;
            // 
            // bodegaTableAdapter
            // 
            this.bodegaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmProductosPorBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 299);
            this.Controls.Add(this.GvProductosBodega);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProductosPorBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos por Bodega";
            this.Load += new System.EventHandler(this.FrmProductosPorBodega_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altoValirioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvProductosBodega)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.ComboBox selectBodega;
        private System.Windows.Forms.DataGridView GvProductosBodega;
        private AltoValirioDataSet1 altoValirioDataSet1;
        private System.Windows.Forms.BindingSource bodegaBindingSource;
        private AltoValirioDataSet1TableAdapters.BodegaTableAdapter bodegaTableAdapter;
    }
}