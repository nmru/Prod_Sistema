namespace WindowsFormsApplication3
{
    partial class frmBuscarDevice
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
            this.gpbBuscarD = new System.Windows.Forms.GroupBox();
            this.lblM = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.pbM = new System.Windows.Forms.PictureBox();
            this.pbN = new System.Windows.Forms.PictureBox();
            this.lblMAC = new System.Windows.Forms.Label();
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.lblNumSerie = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.ckbAll = new System.Windows.Forms.CheckBox();
            this.gpbBuscarD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.gpbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbBuscarD
            // 
            this.gpbBuscarD.Controls.Add(this.gpbSearch);
            this.gpbBuscarD.Controls.Add(this.btnCancel);
            this.gpbBuscarD.Controls.Add(this.btnOk);
            this.gpbBuscarD.Controls.Add(this.dgvBuscar);
            this.gpbBuscarD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBuscarD.Location = new System.Drawing.Point(12, 12);
            this.gpbBuscarD.Name = "gpbBuscarD";
            this.gpbBuscarD.Size = new System.Drawing.Size(550, 405);
            this.gpbBuscarD.TabIndex = 17;
            this.gpbBuscarD.TabStop = false;
            this.gpbBuscarD.Text = "Buscar Device";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(291, 60);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(0, 16);
            this.lblM.TabIndex = 11;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(291, 27);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(0, 16);
            this.lblN.TabIndex = 10;
            // 
            // pbM
            // 
            this.pbM.Location = new System.Drawing.Point(257, 60);
            this.pbM.Name = "pbM";
            this.pbM.Size = new System.Drawing.Size(27, 20);
            this.pbM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbM.TabIndex = 9;
            this.pbM.TabStop = false;
            // 
            // pbN
            // 
            this.pbN.Location = new System.Drawing.Point(257, 27);
            this.pbN.Name = "pbN";
            this.pbN.Size = new System.Drawing.Size(27, 20);
            this.pbN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbN.TabIndex = 8;
            this.pbN.TabStop = false;
            // 
            // lblMAC
            // 
            this.lblMAC.AutoSize = true;
            this.lblMAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAC.Location = new System.Drawing.Point(6, 63);
            this.lblMAC.Name = "lblMAC";
            this.lblMAC.Size = new System.Drawing.Size(94, 16);
            this.lblMAC.TabIndex = 7;
            this.lblMAC.Text = "MAC Address:";
            // 
            // txtMAC
            // 
            this.txtMAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAC.Location = new System.Drawing.Point(104, 60);
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(147, 22);
            this.txtMAC.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(454, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cerrar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(17, 359);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Aceptar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Location = new System.Drawing.Point(17, 195);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.Size = new System.Drawing.Size(513, 147);
            this.dgvBuscar.TabIndex = 3;
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSerie.Location = new System.Drawing.Point(22, 26);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(78, 16);
            this.lblNumSerie.TabIndex = 0;
            this.lblNumSerie.Text = "Num_Serie:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(427, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(104, 27);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(147, 22);
            this.txtSerie.TabIndex = 1;
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.ckbAll);
            this.gpbSearch.Controls.Add(this.txtMAC);
            this.gpbSearch.Controls.Add(this.lblM);
            this.gpbSearch.Controls.Add(this.txtSerie);
            this.gpbSearch.Controls.Add(this.lblN);
            this.gpbSearch.Controls.Add(this.btnSearch);
            this.gpbSearch.Controls.Add(this.pbM);
            this.gpbSearch.Controls.Add(this.lblNumSerie);
            this.gpbSearch.Controls.Add(this.pbN);
            this.gpbSearch.Controls.Add(this.lblMAC);
            this.gpbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSearch.Location = new System.Drawing.Point(21, 35);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(508, 128);
            this.gpbSearch.TabIndex = 12;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "Buscar";
            // 
            // ckbAll
            // 
            this.ckbAll.AutoSize = true;
            this.ckbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAll.Location = new System.Drawing.Point(104, 94);
            this.ckbAll.Name = "ckbAll";
            this.ckbAll.Size = new System.Drawing.Size(213, 20);
            this.ckbAll.TabIndex = 12;
            this.ckbAll.Text = "Mostrar Todos los Dispositivos";
            this.ckbAll.UseVisualStyleBackColor = true;
            // 
            // frmBuscarDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 442);
            this.Controls.Add(this.gpbBuscarD);
            this.Name = "frmBuscarDevice";
            this.Text = "frmBuscarDevice";
            this.gpbBuscarD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbBuscarD;
        private System.Windows.Forms.Label lblMAC;
        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.Label lblNumSerie;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.PictureBox pbN;
        private System.Windows.Forms.PictureBox pbM;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.CheckBox ckbAll;
    }
}