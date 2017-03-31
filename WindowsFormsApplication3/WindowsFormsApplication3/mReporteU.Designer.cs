namespace WindowsFormsApplication3
{
    partial class mReporteU
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
            this.gpbUbicacion = new System.Windows.Forms.GroupBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cmbIssue = new System.Windows.Forms.ComboBox();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.gpbUbicacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbUbicacion
            // 
            this.gpbUbicacion.Controls.Add(this.btnGenerar);
            this.gpbUbicacion.Controls.Add(this.cmbIssue);
            this.gpbUbicacion.Controls.Add(this.lblUbicacion);
            this.gpbUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbUbicacion.ForeColor = System.Drawing.Color.Blue;
            this.gpbUbicacion.Location = new System.Drawing.Point(12, 32);
            this.gpbUbicacion.Name = "gpbUbicacion";
            this.gpbUbicacion.Size = new System.Drawing.Size(315, 205);
            this.gpbUbicacion.TabIndex = 3;
            this.gpbUbicacion.TabStop = false;
            this.gpbUbicacion.Text = "Reporte por Tipo de Ubicacion";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGenerar.Location = new System.Drawing.Point(68, 133);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(190, 36);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cmbIssue
            // 
            this.cmbIssue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIssue.FormattingEnabled = true;
            this.cmbIssue.Items.AddRange(new object[] {
            "Almacen",
            "Mercado"});
            this.cmbIssue.Location = new System.Drawing.Point(106, 58);
            this.cmbIssue.Name = "cmbIssue";
            this.cmbIssue.Size = new System.Drawing.Size(189, 28);
            this.cmbIssue.TabIndex = 1;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(7, 64);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(72, 16);
            this.lblUbicacion.TabIndex = 0;
            this.lblUbicacion.Text = "Ubicacion:";
            // 
            // mReporteU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 261);
            this.Controls.Add(this.gpbUbicacion);
            this.Name = "mReporteU";
            this.Text = "mReporteU";
            this.gpbUbicacion.ResumeLayout(false);
            this.gpbUbicacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbUbicacion;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cmbIssue;
        private System.Windows.Forms.Label lblUbicacion;
    }
}