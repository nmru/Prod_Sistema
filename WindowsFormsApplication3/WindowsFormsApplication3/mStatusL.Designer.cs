namespace WindowsFormsApplication3
{
    partial class mStatusL
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
            this.gpbStatusL = new System.Windows.Forms.GroupBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.gpbStatusL.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbStatusL
            // 
            this.gpbStatusL.Controls.Add(this.btnGenerar);
            this.gpbStatusL.Controls.Add(this.cmbStatus);
            this.gpbStatusL.Controls.Add(this.lblUbicacion);
            this.gpbStatusL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbStatusL.ForeColor = System.Drawing.Color.Blue;
            this.gpbStatusL.Location = new System.Drawing.Point(12, 26);
            this.gpbStatusL.Name = "gpbStatusL";
            this.gpbStatusL.Size = new System.Drawing.Size(315, 205);
            this.gpbStatusL.TabIndex = 4;
            this.gpbStatusL.TabStop = false;
            this.gpbStatusL.Text = "Reporte por Status de Lote";
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
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pendiente",
            "Iniciado",
            "Terminado"});
            this.cmbStatus.Location = new System.Drawing.Point(106, 58);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(189, 28);
            this.cmbStatus.TabIndex = 1;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(7, 64);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(77, 16);
            this.lblUbicacion.TabIndex = 0;
            this.lblUbicacion.Text = "Status Lote:";
            // 
            // mStatusL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 251);
            this.Controls.Add(this.gpbStatusL);
            this.Name = "mStatusL";
            this.Text = "mStatusL";
            this.gpbStatusL.ResumeLayout(false);
            this.gpbStatusL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbStatusL;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblUbicacion;
    }
}