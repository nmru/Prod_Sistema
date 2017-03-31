namespace WindowsFormsApplication3
{
    partial class frmProd_Etapa
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
            this.gpbEvaluacion = new System.Windows.Forms.GroupBox();
            this.lblN = new System.Windows.Forms.Label();
            this.pbN = new System.Windows.Forms.PictureBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbIssue = new System.Windows.Forms.ComboBox();
            this.lblIssue = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbEtapa = new System.Windows.Forms.ComboBox();
            this.lblEtapa = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblSerial = new System.Windows.Forms.Label();
            this.tpsMain = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.gpbEvaluacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbN)).BeginInit();
            this.tpsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbEvaluacion
            // 
            this.gpbEvaluacion.Controls.Add(this.lblN);
            this.gpbEvaluacion.Controls.Add(this.pbN);
            this.gpbEvaluacion.Controls.Add(this.cmbStatus);
            this.gpbEvaluacion.Controls.Add(this.lblStatus);
            this.gpbEvaluacion.Controls.Add(this.cmbIssue);
            this.gpbEvaluacion.Controls.Add(this.lblIssue);
            this.gpbEvaluacion.Controls.Add(this.dtpFecha);
            this.gpbEvaluacion.Controls.Add(this.lblFecha);
            this.gpbEvaluacion.Controls.Add(this.cmbEtapa);
            this.gpbEvaluacion.Controls.Add(this.lblEtapa);
            this.gpbEvaluacion.Controls.Add(this.txtSerie);
            this.gpbEvaluacion.Controls.Add(this.lblSerial);
            this.gpbEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEvaluacion.Location = new System.Drawing.Point(12, 26);
            this.gpbEvaluacion.Name = "gpbEvaluacion";
            this.gpbEvaluacion.Size = new System.Drawing.Size(540, 178);
            this.gpbEvaluacion.TabIndex = 5;
            this.gpbEvaluacion.TabStop = false;
            this.gpbEvaluacion.Text = "Datos Evaluacion";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(292, 27);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(0, 20);
            this.lblN.TabIndex = 13;
            // 
            // pbN
            // 
            this.pbN.Location = new System.Drawing.Point(259, 27);
            this.pbN.Name = "pbN";
            this.pbN.Size = new System.Drawing.Size(26, 20);
            this.pbN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbN.TabIndex = 12;
            this.pbN.TabStop = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Enabled = false;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pendiente",
            "Iniciado",
            "Terminado"});
            this.cmbStatus.Location = new System.Drawing.Point(103, 133);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(150, 24);
            this.cmbStatus.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(57, 141);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 16);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status:";
            // 
            // cmbIssue
            // 
            this.cmbIssue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIssue.Enabled = false;
            this.cmbIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIssue.FormattingEnabled = true;
            this.cmbIssue.Items.AddRange(new object[] {
            "Firmado",
            "Etiquetado",
            "Ninguno"});
            this.cmbIssue.Location = new System.Drawing.Point(103, 106);
            this.cmbIssue.Name = "cmbIssue";
            this.cmbIssue.Size = new System.Drawing.Size(150, 24);
            this.cmbIssue.TabIndex = 9;
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssue.Location = new System.Drawing.Point(57, 114);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(43, 16);
            this.lblIssue.TabIndex = 8;
            this.lblIssue.Text = "Issue:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(103, 80);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(150, 22);
            this.dtpFecha.TabIndex = 7;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(52, 86);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 16);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha:";
            // 
            // cmbEtapa
            // 
            this.cmbEtapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEtapa.Enabled = false;
            this.cmbEtapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEtapa.FormattingEnabled = true;
            this.cmbEtapa.Items.AddRange(new object[] {
            "Etiquetado",
            "Maquinado",
            "Firmado",
            "Prueba"});
            this.cmbEtapa.Location = new System.Drawing.Point(103, 53);
            this.cmbEtapa.Name = "cmbEtapa";
            this.cmbEtapa.Size = new System.Drawing.Size(150, 24);
            this.cmbEtapa.TabIndex = 5;
            // 
            // lblEtapa
            // 
            this.lblEtapa.AutoSize = true;
            this.lblEtapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtapa.Location = new System.Drawing.Point(54, 61);
            this.lblEtapa.Name = "lblEtapa";
            this.lblEtapa.Size = new System.Drawing.Size(47, 16);
            this.lblEtapa.TabIndex = 4;
            this.lblEtapa.Text = "Etapa:";
            // 
            // txtSerie
            // 
            this.txtSerie.Enabled = false;
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(103, 27);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(150, 22);
            this.txtSerie.TabIndex = 1;
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerial.Location = new System.Drawing.Point(30, 34);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(77, 16);
            this.lblSerial.TabIndex = 0;
            this.lblSerial.Text = "Num. Serie:";
            // 
            // tpsMain
            // 
            this.tpsMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tpsMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnBuscar,
            this.btnActualizar,
            this.btnEliminar,
            this.btnSalir});
            this.tpsMain.Location = new System.Drawing.Point(0, 228);
            this.tpsMain.Name = "tpsMain";
            this.tpsMain.Size = new System.Drawing.Size(564, 25);
            this.tpsMain.TabIndex = 4;
            this.tpsMain.Text = "Main";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::WindowsFormsApplication3.Properties.Resources._new;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(66, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = global::WindowsFormsApplication3.Properties.Resources.save;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::WindowsFormsApplication3.Properties.Resources.search2;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(66, 22);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Image = global::WindowsFormsApplication3.Properties.Resources.refresh;
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(84, 22);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = global::WindowsFormsApplication3.Properties.Resources.delete21;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::WindowsFormsApplication3.Properties.Resources.cancel;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmProd_Etapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 253);
            this.Controls.Add(this.gpbEvaluacion);
            this.Controls.Add(this.tpsMain);
            this.Name = "frmProd_Etapa";
            this.Text = "frmProd_Etapa";
            this.Load += new System.EventHandler(this.frmProd_Etapa_Load);
            this.gpbEvaluacion.ResumeLayout(false);
            this.gpbEvaluacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbN)).EndInit();
            this.tpsMain.ResumeLayout(false);
            this.tpsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbEvaluacion;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbIssue;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbEtapa;
        private System.Windows.Forms.Label lblEtapa;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.ToolStrip tpsMain;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.PictureBox pbN;
    }
}