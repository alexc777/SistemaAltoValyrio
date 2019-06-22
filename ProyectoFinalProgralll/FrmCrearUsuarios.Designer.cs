namespace ProyectoFinalProgralll
{
    partial class FrmCrearUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.selectBodega = new System.Windows.Forms.ComboBox();
            this.bodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.altoValirioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.altoValirioDataSet = new ProyectoFinalProgralll.AltoValirioDataSet();
            this.selectRol = new System.Windows.Forms.ComboBox();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_Crear = new System.Windows.Forms.Button();
            this.bodegaTableAdapter = new ProyectoFinalProgralll.AltoValirioDataSetTableAdapters.BodegaTableAdapter();
            this.rolesTableAdapter = new ProyectoFinalProgralll.AltoValirioDataSetTableAdapters.RolesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altoValirioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altoValirioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(27, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(111, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(165, 45);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(111, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(162, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(27, 100);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(111, 20);
            this.txtCorreo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo";
            // 
            // txtPass1
            // 
            this.txtPass1.Location = new System.Drawing.Point(165, 100);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.PasswordChar = '*';
            this.txtPass1.Size = new System.Drawing.Size(111, 20);
            this.txtPass1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(162, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña";
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(27, 154);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.PasswordChar = '*';
            this.txtPass2.Size = new System.Drawing.Size(249, 20);
            this.txtPass2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Confirmar Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bodega";
            // 
            // selectBodega
            // 
            this.selectBodega.DataSource = this.bodegaBindingSource;
            this.selectBodega.DisplayMember = "Nombre";
            this.selectBodega.FormattingEnabled = true;
            this.selectBodega.Location = new System.Drawing.Point(27, 213);
            this.selectBodega.Name = "selectBodega";
            this.selectBodega.Size = new System.Drawing.Size(111, 21);
            this.selectBodega.TabIndex = 11;
            this.selectBodega.ValueMember = "Id";
            // 
            // bodegaBindingSource
            // 
            this.bodegaBindingSource.DataMember = "Bodega";
            this.bodegaBindingSource.DataSource = this.altoValirioDataSetBindingSource;
            // 
            // altoValirioDataSetBindingSource
            // 
            this.altoValirioDataSetBindingSource.DataSource = this.altoValirioDataSet;
            this.altoValirioDataSetBindingSource.Position = 0;
            // 
            // altoValirioDataSet
            // 
            this.altoValirioDataSet.DataSetName = "AltoValirioDataSet";
            this.altoValirioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectRol
            // 
            this.selectRol.DataSource = this.rolesBindingSource;
            this.selectRol.DisplayMember = "Nombre";
            this.selectRol.FormattingEnabled = true;
            this.selectRol.Location = new System.Drawing.Point(165, 213);
            this.selectRol.Name = "selectRol";
            this.selectRol.Size = new System.Drawing.Size(111, 21);
            this.selectRol.TabIndex = 13;
            this.selectRol.ValueMember = "Id";
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.altoValirioDataSetBindingSource;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(162, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Rol de Usuario";
            // 
            // Btn_Crear
            // 
            this.Btn_Crear.BackColor = System.Drawing.Color.Black;
            this.Btn_Crear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Crear.ForeColor = System.Drawing.Color.White;
            this.Btn_Crear.Location = new System.Drawing.Point(107, 270);
            this.Btn_Crear.Name = "Btn_Crear";
            this.Btn_Crear.Size = new System.Drawing.Size(75, 23);
            this.Btn_Crear.TabIndex = 14;
            this.Btn_Crear.Text = "Crear";
            this.Btn_Crear.UseVisualStyleBackColor = false;
            this.Btn_Crear.Click += new System.EventHandler(this.Btn_Crear_Click);
            // 
            // bodegaTableAdapter
            // 
            this.bodegaTableAdapter.ClearBeforeFill = true;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCrearUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(302, 321);
            this.Controls.Add(this.Btn_Crear);
            this.Controls.Add(this.selectRol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.selectBodega);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPass1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "FrmCrearUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Usurios";
            this.Load += new System.EventHandler(this.FrmCrearUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altoValirioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altoValirioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox selectBodega;
        private System.Windows.Forms.ComboBox selectRol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_Crear;
        private System.Windows.Forms.BindingSource altoValirioDataSetBindingSource;
        private AltoValirioDataSet altoValirioDataSet;
        private System.Windows.Forms.BindingSource bodegaBindingSource;
        private AltoValirioDataSetTableAdapters.BodegaTableAdapter bodegaTableAdapter;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private AltoValirioDataSetTableAdapters.RolesTableAdapter rolesTableAdapter;
    }
}