namespace WindowsFormsApplication3
{
    partial class mEtapaF
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
            this.lblFTermino = new System.Windows.Forms.Label();
            this.lblfInicio = new System.Windows.Forms.Label();
            this.lblEtapa = new System.Windows.Forms.Label();
            this.dtpF2 = new System.Windows.Forms.DateTimePicker();
            this.dtpF1 = new System.Windows.Forms.DateTimePicker();
            this.cmbEtapa = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.gpbEtapaF.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbEtapaF
            // 
            this.gpbEtapaF.Controls.Add(this.lblFTermino);
            this.gpbEtapaF.Controls.Add(this.lblfInicio);
            this.gpbEtapaF.Controls.Add(this.lblEtapa);
            this.gpbEtapaF.Controls.Add(this.dtpF2);
            this.gpbEtapaF.Controls.Add(this.dtpF1);
            this.gpbEtapaF.Controls.Add(this.cmbEtapa);
            this.gpbEtapaF.Controls.Add(this.btnGenerar);
            this.gpbEtapaF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpbEtapaF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEtapaF.ForeColor = System.Drawing.Color.Blue;
            this.gpbEtapaF.Location = new System.Drawing.Point(29, 31);
            this.gpbEtapaF.Name = "gpbEtapaF";
            this.gpbEtapaF.Size = new System.Drawing.Size(353, 237);
            this.gpbEtapaF.TabIndex = 0;
            this.gpbEtapaF.TabStop = false;
            this.gpbEtapaF.Text = "Reportes de Etapa por Fechas";
            // 
            // lblFTermino
            // 
            this.lblFTermino.AutoSize = true;
            this.lblFTermino.Location = new System.Drawing.Point(0, 128);
            this.lblFTermino.Name = "lblFTermino";
            this.lblFTermino.Size = new System.Drawing.Size(133, 20);
            this.lblFTermino.TabIndex = 6;
            this.lblFTermino.Text = "Fecha Termino:";
            // 
            // lblfInicio
            // 
            this.lblfInicio.AutoSize = true;
            this.lblfInicio.Location = new System.Drawing.Point(21, 95);
            this.lblfInicio.Name = "lblfInicio";
            this.lblfInicio.Size = new System.Drawing.Size(112, 20);
            this.lblfInicio.TabIndex = 5;
            this.lblfInicio.Text = "Fecha Inicio:";
            // 
            // lblEtapa
            // 
            this.lblEtapa.AutoSize = true;
            this.lblEtapa.Location = new System.Drawing.Point(71, 62);
            this.lblEtapa.Name = "lblEtapa";
            this.lblEtapa.Size = new System.Drawing.Size(62, 20);
            this.lblEtapa.TabIndex = 4;
            this.lblEtapa.Text = "Etapa:";
            // 
            // dtpF2
            // 
            this.dtpF2.Location = new System.Drawing.Point(139, 122);
            this.dtpF2.Name = "dtpF2";
            this.dtpF2.Size = new System.Drawing.Size(200, 26);
            this.dtpF2.TabIndex = 3;
            // 
            // dtpF1
            // 
            this.dtpF1.Location = new System.Drawing.Point(139, 89);
            this.dtpF1.Name = "dtpF1";
            this.dtpF1.Size = new System.Drawing.Size(200, 26);
            this.dtpF1.TabIndex = 2;
            // 
            // cmbEtapa
            // 
            this.cmbEtapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEtapa.FormattingEnabled = true;
            this.cmbEtapa.Items.AddRange(new object[] {
            "Firmado",
            "Pruebas"});
            this.cmbEtapa.Location = new System.Drawing.Point(139, 54);
            this.cmbEtapa.Name = "cmbEtapa";
            this.cmbEtapa.Size = new System.Drawing.Size(200, 28);
            this.cmbEtapa.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGenerar.Location = new System.Drawing.Point(90, 182);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(194, 38);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // mEtapaF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 297);
            this.Controls.Add(this.gpbEtapaF);
            this.Name = "mEtapaF";
            this.Text = "mEtapaF";
            this.gpbEtapaF.ResumeLayout(false);
            this.gpbEtapaF.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbEtapaF;
        private System.Windows.Forms.Label lblFTermino;
        private System.Windows.Forms.Label lblfInicio;
        private System.Windows.Forms.Label lblEtapa;
        private System.Windows.Forms.DateTimePicker dtpF2;
        private System.Windows.Forms.DateTimePicker dtpF1;
        private System.Windows.Forms.ComboBox cmbEtapa;
        private System.Windows.Forms.Button btnGenerar;
    }
}