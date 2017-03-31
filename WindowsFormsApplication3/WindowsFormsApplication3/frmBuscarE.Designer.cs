namespace WindowsFormsApplication3
{
    partial class frmBuscarE
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
            this.gpbBuscarE = new System.Windows.Forms.GroupBox();
            this.lblS = new System.Windows.Forms.Label();
            this.pbS = new System.Windows.Forms.PictureBox();
            this.cmbEtapa = new System.Windows.Forms.ComboBox();
            this.lblEtapa = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.lblSerie = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.ckbAll = new System.Windows.Forms.CheckBox();
            this.gpbBuscarE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.gpbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbBuscarE
            // 
            this.gpbBuscarE.Controls.Add(this.gpbSearch);
            this.gpbBuscarE.Controls.Add(this.btnCancel);
            this.gpbBuscarE.Controls.Add(this.btnOk);
            this.gpbBuscarE.Controls.Add(this.dgvBuscar);
            this.gpbBuscarE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBuscarE.Location = new System.Drawing.Point(25, 12);
            this.gpbBuscarE.Name = "gpbBuscarE";
            this.gpbBuscarE.Size = new System.Drawing.Size(587, 378);
            this.gpbBuscarE.TabIndex = 19;
            this.gpbBuscarE.TabStop = false;
            this.gpbBuscarE.Text = "Buscar Etapa";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(292, 22);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(0, 16);
            this.lblS.TabIndex = 10;
            // 
            // pbS
            // 
            this.pbS.Location = new System.Drawing.Point(261, 22);
            this.pbS.Name = "pbS";
            this.pbS.Size = new System.Drawing.Size(24, 20);
            this.pbS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbS.TabIndex = 9;
            this.pbS.TabStop = false;
            // 
            // cmbEtapa
            // 
            this.cmbEtapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEtapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEtapa.FormattingEnabled = true;
            this.cmbEtapa.Items.AddRange(new object[] {
            "Etiquetado",
            "Maquinado",
            "Firmado",
            "Prueba"});
            this.cmbEtapa.Location = new System.Drawing.Point(107, 50);
            this.cmbEtapa.Name = "cmbEtapa";
            this.cmbEtapa.Size = new System.Drawing.Size(147, 24);
            this.cmbEtapa.TabIndex = 8;
            // 
            // lblEtapa
            // 
            this.lblEtapa.AutoSize = true;
            this.lblEtapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtapa.Location = new System.Drawing.Point(60, 53);
            this.lblEtapa.Name = "lblEtapa";
            this.lblEtapa.Size = new System.Drawing.Size(47, 16);
            this.lblEtapa.TabIndex = 7;
            this.lblEtapa.Text = "Etapa:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(463, 326);
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
            this.btnOk.Location = new System.Drawing.Point(83, 326);
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
            this.dgvBuscar.Location = new System.Drawing.Point(41, 177);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.Size = new System.Drawing.Size(503, 134);
            this.dgvBuscar.TabIndex = 3;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(30, 28);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(77, 16);
            this.lblSerie.TabIndex = 0;
            this.lblSerie.Text = "Num. Serie:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(437, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(107, 22);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(147, 22);
            this.txtSerie.TabIndex = 1;
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.ckbAll);
            this.gpbSearch.Controls.Add(this.cmbEtapa);
            this.gpbSearch.Controls.Add(this.lblS);
            this.gpbSearch.Controls.Add(this.txtSerie);
            this.gpbSearch.Controls.Add(this.pbS);
            this.gpbSearch.Controls.Add(this.btnSearch);
            this.gpbSearch.Controls.Add(this.lblSerie);
            this.gpbSearch.Controls.Add(this.lblEtapa);
            this.gpbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSearch.Location = new System.Drawing.Point(41, 32);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(503, 115);
            this.gpbSearch.TabIndex = 11;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "Buscar";
            // 
            // ckbAll
            // 
            this.ckbAll.AutoSize = true;
            this.ckbAll.Location = new System.Drawing.Point(104, 82);
            this.ckbAll.Name = "ckbAll";
            this.ckbAll.Size = new System.Drawing.Size(182, 20);
            this.ckbAll.TabIndex = 11;
            this.ckbAll.Text = "Mostrar Todas las Etapas";
            this.ckbAll.UseVisualStyleBackColor = true;
            // 
            // frmBuscarE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 408);
            this.Controls.Add(this.gpbBuscarE);
            this.Name = "frmBuscarE";
            this.Text = "frmBuscarE";
            this.gpbBuscarE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbBuscarE;
        private System.Windows.Forms.ComboBox cmbEtapa;
        private System.Windows.Forms.Label lblEtapa;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.PictureBox pbS;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.CheckBox ckbAll;
    }
}