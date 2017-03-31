namespace WindowsFormsApplication3
{
    partial class mReporteF
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
            this.gpbEtapaF = new System.Windows.Forms.GroupBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbEtapa = new System.Windows.Forms.ComboBox();
            this.lblEtapa = new System.Windows.Forms.Label();
            this.gpbEtapaF.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbEtapaF
            // 
            this.gpbEtapaF.Controls.Add(this.btnGenerar);
            this.gpbEtapaF.Controls.Add(this.dtpFecha);
            this.gpbEtapaF.Controls.Add(this.lblFecha);
            this.gpbEtapaF.Controls.Add(this.cmbEtapa);
            this.gpbEtapaF.Controls.Add(this.lblEtapa);
            this.gpbEtapaF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEtapaF.ForeColor = System.Drawing.Color.Blue;
            this.gpbEtapaF.Location = new System.Drawing.Point(12, 25);
            this.gpbEtapaF.Name = "gpbEtapaF";
            this.gpbEtapaF.Size = new System.Drawing.Size(340, 203);
            this.gpbEtapaF.TabIndex = 1;
            this.gpbEtapaF.TabStop = false;
            this.gpbEtapaF.Text = "Reporte por Etapa / Fecha";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGenerar.Location = new System.Drawing.Point(82, 139);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(200, 38);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(92, 85);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(206, 26);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(36, 85);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 16);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // cmbEtapa
            // 
            this.cmbEtapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEtapa.FormattingEnabled = true;
            this.cmbEtapa.Items.AddRange(new object[] {
            "Etiquetado",
            "Maquinado",
            "Firmado",
            "Pruebas"});
            this.cmbEtapa.Location = new System.Drawing.Point(92, 44);
            this.cmbEtapa.Name = "cmbEtapa";
            this.cmbEtapa.Size = new System.Drawing.Size(206, 28);
            this.cmbEtapa.TabIndex = 1;
            // 
            // lblEtapa
            // 
            this.lblEtapa.AutoSize = true;
            this.lblEtapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtapa.Location = new System.Drawing.Point(38, 50);
            this.lblEtapa.Name = "lblEtapa";
            this.lblEtapa.Size = new System.Drawing.Size(47, 16);
            this.lblEtapa.TabIndex = 0;
            this.lblEtapa.Text = "Etapa:";
            // 
            // mReporteF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 252);
            this.Controls.Add(this.gpbEtapaF);
            this.Name = "mReporteF";
            this.Text = "Form1";
            this.gpbEtapaF.ResumeLayout(false);
            this.gpbEtapaF.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbEtapaF;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbEtapa;
        private System.Windows.Forms.Label lblEtapa;
    }
}

