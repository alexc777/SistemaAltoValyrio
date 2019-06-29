namespace ProyectoFinalProgralll
{
    partial class FrmLogsMarca
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
            this.GvLog = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // GvLog
            // 
            this.GvLog.BackgroundColor = System.Drawing.Color.DarkRed;
            this.GvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvLog.Location = new System.Drawing.Point(12, 40);
            this.GvLog.Name = "GvLog";
            this.GvLog.Size = new System.Drawing.Size(530, 316);
            this.GvLog.TabIndex = 1;
            // 
            // FrmLogsMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(566, 385);
            this.Controls.Add(this.GvLog);
            this.Name = "FrmLogsMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logs Marca";
            ((System.ComponentModel.ISupportInitialize)(this.GvLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GvLog;
    }
}