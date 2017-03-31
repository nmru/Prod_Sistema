namespace WindowsFormsApplication3
{
    partial class mReporteRep
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
            this.gpbReposicion = new System.Windows.Forms.GroupBox();
            this.lblct = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.pba = new System.Windows.Forms.PictureBox();
            this.pbcte = new System.Windows.Forms.PictureBox();
            this.pbc = new System.Windows.Forms.PictureBox();
            this.txtCte = new System.Windows.Forms.TextBox();
            this.lblCte = new System.Windows.Forms.Label();
            this.txtCanal = new System.Windows.Forms.TextBox();
            this.lblCanal = new System.Windows.Forms.Label();
            this.txtAuto = new System.Windows.Forms.TextBox();
            this.lblAutoriza = new System.Windows.Forms.Label();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.gpbReposicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbc)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbReposicion
            // 
            this.gpbReposicion.Controls.Add(this.lblct);
            this.gpbReposicion.Controls.Add(this.lblc);
            this.gpbReposicion.Controls.Add(this.lbla);
            this.gpbReposicion.Controls.Add(this.pba);
            this.gpbReposicion.Controls.Add(this.pbcte);
            this.gpbReposicion.Controls.Add(this.pbc);
            this.gpbReposicion.Controls.Add(this.txtCte);
            this.gpbReposicion.Controls.Add(this.lblCte);
            this.gpbReposicion.Controls.Add(this.txtCanal);
            this.gpbReposicion.Controls.Add(this.lblCanal);
            this.gpbReposicion.Controls.Add(this.txtAuto);
            this.gpbReposicion.Controls.Add(this.lblAutoriza);
            this.gpbReposicion.Controls.Add(this.cmbMotivo);
            this.gpbReposicion.Controls.Add(this.lblMotivo);
            this.gpbReposicion.Controls.Add(this.btnGenerar);
            this.gpbReposicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbReposicion.ForeColor = System.Drawing.Color.Blue;
            this.gpbReposicion.Location = new System.Drawing.Point(21, 34);
            this.gpbReposicion.Name = "gpbReposicion";
            this.gpbReposicion.Size = new System.Drawing.Size(570, 265);
            this.gpbReposicion.TabIndex = 0;
            this.gpbReposicion.TabStop = false;
            this.gpbReposicion.Text = "Reporte por Motivo/ Autorizacion/ Canal / Cte";
            // 
            // lblct
            // 
            this.lblct.AutoSize = true;
            this.lblct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblct.Location = new System.Drawing.Point(361, 145);
            this.lblct.Name = "lblct";
            this.lblct.Size = new System.Drawing.Size(0, 16);
            this.lblct.TabIndex = 19;
            this.lblct.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc.Location = new System.Drawing.Point(361, 113);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(0, 16);
            this.lblc.TabIndex = 18;
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.Location = new System.Drawing.Point(362, 81);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(0, 16);
            this.lbla.TabIndex = 17;
            // 
            // pba
            // 
            this.pba.Location = new System.Drawing.Point(313, 81);
            this.pba.Name = "pba";
            this.pba.Size = new System.Drawing.Size(42, 26);
            this.pba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pba.TabIndex = 16;
            this.pba.TabStop = false;
            // 
            // pbcte
            // 
            this.pbcte.Location = new System.Drawing.Point(313, 145);
            this.pbcte.Name = "pbcte";
            this.pbcte.Size = new System.Drawing.Size(42, 26);
            this.pbcte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcte.TabIndex = 15;
            this.pbcte.TabStop = false;
            // 
            // pbc
            // 
            this.pbc.Location = new System.Drawing.Point(313, 113);
            this.pbc.Name = "pbc";
            this.pbc.Size = new System.Drawing.Size(42, 26);
            this.pbc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbc.TabIndex = 14;
            this.pbc.TabStop = false;
            // 
            // txtCte
            // 
            this.txtCte.Location = new System.Drawing.Point(133, 145);
            this.txtCte.Name = "txtCte";
            this.txtCte.Size = new System.Drawing.Size(174, 26);
            this.txtCte.TabIndex = 13;
            // 
            // lblCte
            // 
            this.lblCte.AutoSize = true;
            this.lblCte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCte.Location = new System.Drawing.Point(65, 145);
            this.lblCte.Name = "lblCte";
            this.lblCte.Size = new System.Drawing.Size(62, 20);
            this.lblCte.TabIndex = 12;
            this.lblCte.Text = "Cliente:";
            // 
            // txtCanal
            // 
            this.txtCanal.Location = new System.Drawing.Point(133, 113);
            this.txtCanal.Name = "txtCanal";
            this.txtCanal.Size = new System.Drawing.Size(174, 26);
            this.txtCanal.TabIndex = 11;
            // 
            // lblCanal
            // 
            this.lblCanal.AutoSize = true;
            this.lblCanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanal.Location = new System.Drawing.Point(73, 113);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(54, 20);
            this.lblCanal.TabIndex = 10;
            this.lblCanal.Text = "Canal:";
            // 
            // txtAuto
            // 
            this.txtAuto.Location = new System.Drawing.Point(133, 81);
            this.txtAuto.Name = "txtAuto";
            this.txtAuto.Size = new System.Drawing.Size(174, 26);
            this.txtAuto.TabIndex = 9;
            // 
            // lblAutoriza
            // 
            this.lblAutoriza.AutoSize = true;
            this.lblAutoriza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoriza.Location = new System.Drawing.Point(55, 81);
            this.lblAutoriza.Name = "lblAutoriza";
            this.lblAutoriza.Size = new System.Drawing.Size(72, 20);
            this.lblAutoriza.TabIndex = 8;
            this.lblAutoriza.Text = "Autorizó:";
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Items.AddRange(new object[] {
            "Cambio de Modelo",
            "Falla de Equipo",
            "Cancelacion Canal",
            "Termino Contrato"});
            this.cmbMotivo.Location = new System.Drawing.Point(133, 47);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(174, 28);
            this.cmbMotivo.TabIndex = 7;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(68, 47);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(59, 20);
            this.lblMotivo.TabIndex = 6;
            this.lblMotivo.Text = "Motivo:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGenerar.Location = new System.Drawing.Point(122, 197);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(155, 34);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // mReporteRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 335);
            this.Controls.Add(this.gpbReposicion);
            this.Name = "mReporteRep";
            this.Text = "mReporteRep";
            this.gpbReposicion.ResumeLayout(false);
            this.gpbReposicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbReposicion;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtAuto;
        private System.Windows.Forms.Label lblAutoriza;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtCte;
        private System.Windows.Forms.Label lblCte;
        private System.Windows.Forms.TextBox txtCanal;
        private System.Windows.Forms.Label lblCanal;
        private System.Windows.Forms.Label lblct;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.PictureBox pba;
        private System.Windows.Forms.PictureBox pbcte;
        private System.Windows.Forms.PictureBox pbc;
    }
}