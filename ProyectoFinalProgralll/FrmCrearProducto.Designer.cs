﻿namespace ProyectoFinalProgralll
{
    partial class FrmCrearProducto
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
            this.Btn_Crear = new System.Windows.Forms.Button();
            this.selectCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.altoValirioDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.altoValirioDataSet1 = new ProyectoFinalProgralll.AltoValirioDataSet1();
            this.label7 = new System.Windows.Forms.Label();
            this.selectMarca = new System.Windows.Forms.ComboBox();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectRefri = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateFechaVence = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.selectEmpaque = new System.Windows.Forms.ComboBox();
            this.empaqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.marcaTableAdapter = new ProyectoFinalProgralll.AltoValirioDataSet1TableAdapters.MarcaTableAdapter();
            this.categoriaTableAdapter = new ProyectoFinalProgralll.AltoValirioDataSet1TableAdapters.CategoriaTableAdapter();
            this.empaqueTableAdapter = new ProyectoFinalProgralll.AltoValirioDataSet1TableAdapters.EmpaqueTableAdapter();
            this.bodegaTableAdapter = new ProyectoFinalProgralll.AltoValirioDataSet1TableAdapters.BodegaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altoValirioDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altoValirioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empaqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Crear
            // 
            this.Btn_Crear.BackColor = System.Drawing.Color.Black;
            this.Btn_Crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Crear.ForeColor = System.Drawing.Color.White;
            this.Btn_Crear.Location = new System.Drawing.Point(107, 238);
            this.Btn_Crear.Name = "Btn_Crear";
            this.Btn_Crear.Size = new System.Drawing.Size(75, 23);
            this.Btn_Crear.TabIndex = 9;
            this.Btn_Crear.Text = "Crear";
            this.Btn_Crear.UseVisualStyleBackColor = false;
            this.Btn_Crear.Click += new System.EventHandler(this.Btn_Crear_Click);
            // 
            // selectCategoria
            // 
            this.selectCategoria.DataSource = this.categoriaBindingSource;
            this.selectCategoria.DisplayMember = "Nombre";
            this.selectCategoria.FormattingEnabled = true;
            this.selectCategoria.Location = new System.Drawing.Point(163, 73);
            this.selectCategoria.Name = "selectCategoria";
            this.selectCategoria.Size = new System.Drawing.Size(111, 21);
            this.selectCategoria.TabIndex = 4;
            this.selectCategoria.ValueMember = "Id";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.altoValirioDataSet1BindingSource;
            // 
            // altoValirioDataSet1BindingSource
            // 
            this.altoValirioDataSet1BindingSource.DataSource = this.altoValirioDataSet1;
            this.altoValirioDataSet1BindingSource.Position = 0;
            // 
            // altoValirioDataSet1
            // 
            this.altoValirioDataSet1.DataSetName = "AltoValirioDataSet1";
            this.altoValirioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(160, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Categoría";
            // 
            // selectMarca
            // 
            this.selectMarca.DataSource = this.marcaBindingSource;
            this.selectMarca.DisplayMember = "Nombre";
            this.selectMarca.FormattingEnabled = true;
            this.selectMarca.Location = new System.Drawing.Point(25, 73);
            this.selectMarca.Name = "selectMarca";
            this.selectMarca.Size = new System.Drawing.Size(111, 21);
            this.selectMarca.TabIndex = 3;
            this.selectMarca.ValueMember = "Id";
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "Marca";
            this.marcaBindingSource.DataSource = this.altoValirioDataSet1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Marca";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(163, 27);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(111, 20);
            this.txtPrecio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(160, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Precio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(25, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(111, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre";
            // 
            // selectRefri
            // 
            this.selectRefri.DisplayMember = "Nombre";
            this.selectRefri.FormattingEnabled = true;
            this.selectRefri.Location = new System.Drawing.Point(25, 126);
            this.selectRefri.Name = "selectRefri";
            this.selectRefri.Size = new System.Drawing.Size(111, 21);
            this.selectRefri.TabIndex = 5;
            this.selectRefri.ValueMember = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Refrigerado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(160, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Fecha Vence";
            // 
            // dateFechaVence
            // 
            this.dateFechaVence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaVence.Location = new System.Drawing.Point(163, 127);
            this.dateFechaVence.Name = "dateFechaVence";
            this.dateFechaVence.Size = new System.Drawing.Size(111, 20);
            this.dateFechaVence.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Tipo Empaque";
            // 
            // selectEmpaque
            // 
            this.selectEmpaque.DataSource = this.empaqueBindingSource;
            this.selectEmpaque.DisplayMember = "Tipo";
            this.selectEmpaque.FormattingEnabled = true;
            this.selectEmpaque.Location = new System.Drawing.Point(25, 180);
            this.selectEmpaque.Name = "selectEmpaque";
            this.selectEmpaque.Size = new System.Drawing.Size(111, 21);
            this.selectEmpaque.TabIndex = 7;
            this.selectEmpaque.ValueMember = "Id";
            // 
            // empaqueBindingSource
            // 
            this.empaqueBindingSource.DataMember = "Empaque";
            this.empaqueBindingSource.DataSource = this.altoValirioDataSet1BindingSource;
            // 
            // bodegaBindingSource
            // 
            this.bodegaBindingSource.DataMember = "Bodega";
            this.bodegaBindingSource.DataSource = this.altoValirioDataSet1BindingSource;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(160, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(161, 180);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(111, 20);
            this.txtCantidad.TabIndex = 8;
            // 
            // marcaTableAdapter
            // 
            this.marcaTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // empaqueTableAdapter
            // 
            this.empaqueTableAdapter.ClearBeforeFill = true;
            // 
            // bodegaTableAdapter
            // 
            this.bodegaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCrearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(305, 282);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.selectEmpaque);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateFechaVence);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectRefri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_Crear);
            this.Controls.Add(this.selectCategoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.selectMarca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "FrmCrearProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Producto";
            this.Load += new System.EventHandler(this.FrmCrearProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altoValirioDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altoValirioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empaqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Crear;
        private System.Windows.Forms.ComboBox selectCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox selectMarca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectRefri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox selectEmpaque;
        private System.Windows.Forms.DateTimePicker dateFechaVence;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantidad;
        private AltoValirioDataSet1 altoValirioDataSet1;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private AltoValirioDataSet1TableAdapters.MarcaTableAdapter marcaTableAdapter;
        private System.Windows.Forms.BindingSource altoValirioDataSet1BindingSource;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private AltoValirioDataSet1TableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.BindingSource empaqueBindingSource;
        private AltoValirioDataSet1TableAdapters.EmpaqueTableAdapter empaqueTableAdapter;
        private System.Windows.Forms.BindingSource bodegaBindingSource;
        private AltoValirioDataSet1TableAdapters.BodegaTableAdapter bodegaTableAdapter;
    }
}