namespace WindowsFormsApplication3
{
    partial class frmLote
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
            this.gpbLote = new System.Windows.Forms.GroupBox();
            this.lblU = new System.Windows.Forms.Label();
            this.lblL = new System.Windows.Forms.Label();
            this.cmbSLote = new System.Windows.Forms.ComboBox();
            this.pbU = new System.Windows.Forms.PictureBox();
            this.pbL = new System.Windows.Forms.PictureBox();
            this.lblSLote = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.txtNumLote = new System.Windows.Forms.TextBox();
            this.lblNumLote = new System.Windows.Forms.Label();
            this.tspMain = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.gpbLote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbL)).BeginInit();
            this.tspMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbLote
            // 
            this.gpbLote.Controls.Add(this.lblU);
            this.gpbLote.Controls.Add(this.lblL);
            this.gpbLote.Controls.Add(this.cmbSLote);
            this.gpbLote.Controls.Add(this.pbU);
            this.gpbLote.Controls.Add(this.pbL);
            this.gpbLote.Controls.Add(this.lblSLote);
            this.gpbLote.Controls.Add(this.txtUbicacion);
            this.gpbLote.Controls.Add(this.lblUbicacion);
            this.gpbLote.Controls.Add(this.txtNumLote);
            this.gpbLote.Controls.Add(this.lblNumLote);
            this.gpbLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbLote.Location = new System.Drawing.Point(33, 32);
            this.gpbLote.Margin = new System.Windows.Forms.Padding(4);
            this.gpbLote.Name = "gpbLote";
            this.gpbLote.Padding = new System.Windows.Forms.Padding(4);
            this.gpbLote.Size = new System.Drawing.Size(533, 174);
            this.gpbLote.TabIndex = 5;
            this.gpbLote.TabStop = false;
            this.gpbLote.Text = "Datos Lote";
            // 
            // lblU
            // 
            this.lblU.AutoSize = true;
            this.lblU.Location = new System.Drawing.Point(356, 73);
            this.lblU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblU.Name = "lblU";
            this.lblU.Size = new System.Drawing.Size(0, 20);
            this.lblU.TabIndex = 10;
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Location = new System.Drawing.Point(356, 41);
            this.lblL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(0, 20);
            this.lblL.TabIndex = 9;
            // 
            // cmbSLote
            // 
            this.cmbSLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSLote.Enabled = false;
            this.cmbSLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSLote.FormattingEnabled = true;
            this.cmbSLote.Items.AddRange(new object[] {
            "Iniciado",
            "Terminado",
            "Pendiente"});
            this.cmbSLote.Location = new System.Drawing.Point(104, 106);
            this.cmbSLote.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSLote.Name = "cmbSLote";
            this.cmbSLote.Size = new System.Drawing.Size(192, 24);
            this.cmbSLote.TabIndex = 8;
            // 
            // pbU
            // 
            this.pbU.Location = new System.Drawing.Point(305, 73);
            this.pbU.Margin = new System.Windows.Forms.Padding(4);
            this.pbU.Name = "pbU";
            this.pbU.Size = new System.Drawing.Size(41, 25);
            this.pbU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbU.TabIndex = 7;
            this.pbU.TabStop = false;
            // 
            // pbL
            // 
            this.pbL.Location = new System.Drawing.Point(305, 41);
            this.pbL.Margin = new System.Windows.Forms.Padding(4);
            this.pbL.Name = "pbL";
            this.pbL.Size = new System.Drawing.Size(41, 25);
            this.pbL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbL.TabIndex = 6;
            this.pbL.TabStop = false;
            // 
            // lblSLote
            // 
            this.lblSLote.AutoSize = true;
            this.lblSLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLote.Location = new System.Drawing.Point(21, 106);
            this.lblSLote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSLote.Name = "lblSLote";
            this.lblSLote.Size = new System.Drawing.Size(77, 16);
            this.lblSLote.TabIndex = 4;
            this.lblSLote.Text = "Status Lote:";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Enabled = false;
            this.txtUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicacion.Location = new System.Drawing.Point(103, 73);
            this.txtUbicacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(193, 22);
            this.txtUbicacion.TabIndex = 3;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(29, 70);
            this.lblUbicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(72, 16);
            this.lblUbicacion.TabIndex = 2;
            this.lblUbicacion.Text = "Ubicacion:";
            // 
            // txtNumLote
            // 
            this.txtNumLote.Enabled = false;
            this.txtNumLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumLote.Location = new System.Drawing.Point(103, 41);
            this.txtNumLote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumLote.Name = "txtNumLote";
            this.txtNumLote.Size = new System.Drawing.Size(193, 22);
            this.txtNumLote.TabIndex = 1;
            // 
            // lblNumLote
            // 
            this.lblNumLote.AutoSize = true;
            this.lblNumLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumLote.Location = new System.Drawing.Point(12, 38);
            this.lblNumLote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumLote.Name = "lblNumLote";
            this.lblNumLote.Size = new System.Drawing.Size(88, 16);
            this.lblNumLote.TabIndex = 0;
            this.lblNumLote.Text = "Numero Lote:";
            // 
            // tspMain
            // 
            this.tspMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnBuscar,
            this.btnActualizar,
            this.btnEliminar,
            this.btnCancelar});
            this.tspMain.Location = new System.Drawing.Point(0, 226);
            this.tspMain.Name = "tspMain";
            this.tspMain.Size = new System.Drawing.Size(605, 25);
            this.tspMain.TabIndex = 4;
            this.tspMain.Text = "Main";
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
            // btnCancelar
            // 
            this.btnCancelar.Image = global::WindowsFormsApplication3.Properties.Resources.cancel;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(53, 22);
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 251);
            this.Controls.Add(this.gpbLote);
            this.Controls.Add(this.tspMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLote";
            this.Text = "frmLote";
            this.Load += new System.EventHandler(this.frmLote_Load);
            this.gpbLote.ResumeLayout(false);
            this.gpbLote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbL)).EndInit();
            this.tspMain.ResumeLayout(false);
            this.tspMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbLote;
        private System.Windows.Forms.Label lblSLote;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.TextBox txtNumLote;
        private System.Windows.Forms.Label lblNumLote;
        private System.Windows.Forms.ToolStrip tspMain;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.PictureBox pbU;
        private System.Windows.Forms.PictureBox pbL;
        private System.Windows.Forms.ComboBox cmbSLote;
        private System.Windows.Forms.Label lblU;
        private System.Windows.Forms.Label lblL;
    }
}