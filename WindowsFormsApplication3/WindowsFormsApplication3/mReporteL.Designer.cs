namespace WindowsFormsApplication3
{
    partial class mReporteL
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
            this.gpbDevice = new System.Windows.Forms.GroupBox();
            this.lblS = new System.Windows.Forms.Label();
            this.lblL = new System.Windows.Forms.Label();
            this.pbS = new System.Windows.Forms.PictureBox();
            this.pbL = new System.Windows.Forms.PictureBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.gpbDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbL)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDevice
            // 
            this.gpbDevice.Controls.Add(this.lblS);
            this.gpbDevice.Controls.Add(this.lblL);
            this.gpbDevice.Controls.Add(this.pbS);
            this.gpbDevice.Controls.Add(this.pbL);
            this.gpbDevice.Controls.Add(this.lblSerie);
            this.gpbDevice.Controls.Add(this.txtSerie);
            this.gpbDevice.Controls.Add(this.lblLote);
            this.gpbDevice.Controls.Add(this.txtLote);
            this.gpbDevice.Controls.Add(this.btnGenerar);
            this.gpbDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDevice.ForeColor = System.Drawing.Color.Blue;
            this.gpbDevice.Location = new System.Drawing.Point(22, 24);
            this.gpbDevice.Name = "gpbDevice";
            this.gpbDevice.Size = new System.Drawing.Size(519, 201);
            this.gpbDevice.TabIndex = 1;
            this.gpbDevice.TabStop = false;
            this.gpbDevice.Text = "Reporte por Lote o Dispositivo";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(324, 87);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(0, 20);
            this.lblS.TabIndex = 11;
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Location = new System.Drawing.Point(324, 45);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(0, 20);
            this.lblL.TabIndex = 10;
            // 
            // pbS
            // 
            this.pbS.Location = new System.Drawing.Point(287, 87);
            this.pbS.Name = "pbS";
            this.pbS.Size = new System.Drawing.Size(30, 26);
            this.pbS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbS.TabIndex = 9;
            this.pbS.TabStop = false;
            // 
            // pbL
            // 
            this.pbL.Location = new System.Drawing.Point(287, 45);
            this.pbL.Name = "pbL";
            this.pbL.Size = new System.Drawing.Size(30, 26);
            this.pbL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbL.TabIndex = 8;
            this.pbL.TabStop = false;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.ForeColor = System.Drawing.Color.Blue;
            this.lblSerie.Location = new System.Drawing.Point(59, 93);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(77, 16);
            this.lblSerie.TabIndex = 7;
            this.lblSerie.Text = "Num. Serie:";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(136, 87);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(144, 26);
            this.txtSerie.TabIndex = 6;
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLote.ForeColor = System.Drawing.Color.Blue;
            this.lblLote.Location = new System.Drawing.Point(65, 48);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(71, 16);
            this.lblLote.TabIndex = 5;
            this.lblLote.Text = "Num. Lote:";
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(136, 45);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(144, 26);
            this.txtLote.TabIndex = 4;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGenerar.Location = new System.Drawing.Point(145, 143);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(205, 39);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // mReporteL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 247);
            this.Controls.Add(this.gpbDevice);
            this.Name = "mReporteL";
            this.Text = "mReporteL";
            this.gpbDevice.ResumeLayout(false);
            this.gpbDevice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDevice;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.PictureBox pbS;
        private System.Windows.Forms.PictureBox pbL;
        private System.Windows.Forms.Label lblS;
    }
}