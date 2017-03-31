namespace WindowsFormsApplication3
{
    partial class frmBuscarReposicion
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
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.ckbAll = new System.Windows.Forms.CheckBox();
            this.txtAuto = new System.Windows.Forms.TextBox();
            this.lbla = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pba = new System.Windows.Forms.PictureBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.lblAutoriza = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.gpbReposicion.SuspendLayout();
            this.gpbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbReposicion
            // 
            this.gpbReposicion.Controls.Add(this.gpbSearch);
            this.gpbReposicion.Controls.Add(this.btnCerrar);
            this.gpbReposicion.Controls.Add(this.btnAceptar);
            this.gpbReposicion.Controls.Add(this.dgvBuscar);
            this.gpbReposicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbReposicion.Location = new System.Drawing.Point(19, 31);
            this.gpbReposicion.Name = "gpbReposicion";
            this.gpbReposicion.Size = new System.Drawing.Size(712, 465);
            this.gpbReposicion.TabIndex = 0;
            this.gpbReposicion.TabStop = false;
            this.gpbReposicion.Text = "Buscar Reposicion";
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.ckbAll);
            this.gpbSearch.Controls.Add(this.txtAuto);
            this.gpbSearch.Controls.Add(this.lbla);
            this.gpbSearch.Controls.Add(this.btnSearch);
            this.gpbSearch.Controls.Add(this.pba);
            this.gpbSearch.Controls.Add(this.lblMotivo);
            this.gpbSearch.Controls.Add(this.cmbMotivo);
            this.gpbSearch.Controls.Add(this.lblAutoriza);
            this.gpbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSearch.Location = new System.Drawing.Point(21, 31);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(661, 131);
            this.gpbSearch.TabIndex = 12;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "Buscar";
            // 
            // ckbAll
            // 
            this.ckbAll.AutoSize = true;
            this.ckbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAll.Location = new System.Drawing.Point(91, 94);
            this.ckbAll.Name = "ckbAll";
            this.ckbAll.Size = new System.Drawing.Size(216, 20);
            this.ckbAll.TabIndex = 12;
            this.ckbAll.Text = "Mostrar Todas la Reposiciones";
            this.ckbAll.UseVisualStyleBackColor = true;
            // 
            // txtAuto
            // 
            this.txtAuto.Location = new System.Drawing.Point(91, 53);
            this.txtAuto.Name = "txtAuto";
            this.txtAuto.Size = new System.Drawing.Size(174, 22);
            this.txtAuto.TabIndex = 9;
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(310, 53);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(0, 16);
            this.lbla.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(580, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pba
            // 
            this.pba.Location = new System.Drawing.Point(271, 53);
            this.pba.Name = "pba";
            this.pba.Size = new System.Drawing.Size(32, 19);
            this.pba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pba.TabIndex = 10;
            this.pba.TabStop = false;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(38, 29);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(51, 16);
            this.lblMotivo.TabIndex = 6;
            this.lblMotivo.Text = "Motivo:";
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
            this.cmbMotivo.Location = new System.Drawing.Point(91, 25);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(174, 24);
            this.cmbMotivo.TabIndex = 7;
            // 
            // lblAutoriza
            // 
            this.lblAutoriza.AutoSize = true;
            this.lblAutoriza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoriza.Location = new System.Drawing.Point(29, 54);
            this.lblAutoriza.Name = "lblAutoriza";
            this.lblAutoriza.Size = new System.Drawing.Size(59, 16);
            this.lblAutoriza.TabIndex = 8;
            this.lblAutoriza.Text = "Autorizó:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(607, 430);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(21, 430);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Location = new System.Drawing.Point(21, 187);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.Size = new System.Drawing.Size(661, 219);
            this.dgvBuscar.TabIndex = 0;
            // 
            // frmBuscarReposicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 521);
            this.Controls.Add(this.gpbReposicion);
            this.Name = "frmBuscarReposicion";
            this.Text = "frmBuscarReposicion";
            this.gpbReposicion.ResumeLayout(false);
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbReposicion;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtAuto;
        private System.Windows.Forms.Label lblAutoriza;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.PictureBox pba;
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.CheckBox ckbAll;
    }
}