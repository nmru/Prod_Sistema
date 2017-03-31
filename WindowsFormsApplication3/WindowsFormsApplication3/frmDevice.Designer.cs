namespace WindowsFormsApplication3
{
    partial class frmDevice
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
            this.gpbProd = new System.Windows.Forms.GroupBox();
            this.lblL = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.pbLote = new System.Windows.Forms.PictureBox();
            this.pbMAC = new System.Windows.Forms.PictureBox();
            this.pbNumSerie = new System.Windows.Forms.PictureBox();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.lblMAC = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblSerial = new System.Windows.Forms.Label();
            this.tspMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.lblDisp = new System.Windows.Forms.Label();
            this.cmbDisp = new System.Windows.Forms.ComboBox();
            this.gpbProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNumSerie)).BeginInit();
            this.tspMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbProd
            // 
            this.gpbProd.Controls.Add(this.cmbDisp);
            this.gpbProd.Controls.Add(this.lblDisp);
            this.gpbProd.Controls.Add(this.lblL);
            this.gpbProd.Controls.Add(this.lblM);
            this.gpbProd.Controls.Add(this.lblSerie);
            this.gpbProd.Controls.Add(this.pbLote);
            this.gpbProd.Controls.Add(this.pbMAC);
            this.gpbProd.Controls.Add(this.pbNumSerie);
            this.gpbProd.Controls.Add(this.txtLote);
            this.gpbProd.Controls.Add(this.lblLote);
            this.gpbProd.Controls.Add(this.txtMAC);
            this.gpbProd.Controls.Add(this.lblMAC);
            this.gpbProd.Controls.Add(this.txtSerie);
            this.gpbProd.Controls.Add(this.lblSerial);
            this.gpbProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProd.Location = new System.Drawing.Point(29, 25);
            this.gpbProd.Name = "gpbProd";
            this.gpbProd.Size = new System.Drawing.Size(452, 183);
            this.gpbProd.TabIndex = 3;
            this.gpbProd.TabStop = false;
            this.gpbProd.Text = "Datos Dispositivos";
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Location = new System.Drawing.Point(266, 107);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(0, 20);
            this.lblL.TabIndex = 13;
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(266, 72);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(0, 20);
            this.lblM.TabIndex = 12;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(266, 48);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(0, 20);
            this.lblSerie.TabIndex = 11;
            // 
            // pbLote
            // 
            this.pbLote.Location = new System.Drawing.Point(233, 102);
            this.pbLote.Name = "pbLote";
            this.pbLote.Size = new System.Drawing.Size(26, 19);
            this.pbLote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLote.TabIndex = 10;
            this.pbLote.TabStop = false;
            // 
            // pbMAC
            // 
            this.pbMAC.Location = new System.Drawing.Point(233, 72);
            this.pbMAC.Name = "pbMAC";
            this.pbMAC.Size = new System.Drawing.Size(26, 19);
            this.pbMAC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMAC.TabIndex = 9;
            this.pbMAC.TabStop = false;
            // 
            // pbNumSerie
            // 
            this.pbNumSerie.Location = new System.Drawing.Point(233, 42);
            this.pbNumSerie.Name = "pbNumSerie";
            this.pbNumSerie.Size = new System.Drawing.Size(26, 19);
            this.pbNumSerie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNumSerie.TabIndex = 8;
            this.pbNumSerie.TabStop = false;
            // 
            // txtLote
            // 
            this.txtLote.Enabled = false;
            this.txtLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote.Location = new System.Drawing.Point(107, 102);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(119, 22);
            this.txtLote.TabIndex = 7;
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLote.Location = new System.Drawing.Point(32, 102);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(72, 16);
            this.lblLote.TabIndex = 6;
            this.lblLote.Text = "Num_Lote:";
            // 
            // txtMAC
            // 
            this.txtMAC.Enabled = false;
            this.txtMAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAC.Location = new System.Drawing.Point(107, 72);
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(119, 22);
            this.txtMAC.TabIndex = 5;
            // 
            // lblMAC
            // 
            this.lblMAC.AutoSize = true;
            this.lblMAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAC.Location = new System.Drawing.Point(6, 72);
            this.lblMAC.Name = "lblMAC";
            this.lblMAC.Size = new System.Drawing.Size(98, 16);
            this.lblMAC.TabIndex = 4;
            this.lblMAC.Text = "MAC_Address:";
            // 
            // txtSerie
            // 
            this.txtSerie.Enabled = false;
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(107, 42);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(119, 22);
            this.txtSerie.TabIndex = 3;
            this.txtSerie.TextChanged += new System.EventHandler(this.txtSerie_TextChanged);
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerial.Location = new System.Drawing.Point(26, 42);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(78, 16);
            this.lblSerial.TabIndex = 2;
            this.lblSerial.Text = "Num_Serie:";
            // 
            // tspMenu
            // 
            this.tspMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnBuscar,
            this.btnActualizar,
            this.btnEliminar,
            this.btnCancelar});
            this.tspMenu.Location = new System.Drawing.Point(0, 235);
            this.tspMenu.Name = "tspMenu";
            this.tspMenu.Size = new System.Drawing.Size(508, 25);
            this.tspMenu.TabIndex = 2;
            this.tspMenu.Text = "Acciones";
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
            // lblDisp
            // 
            this.lblDisp.AutoSize = true;
            this.lblDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisp.Location = new System.Drawing.Point(6, 136);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(98, 16);
            this.lblDisp.TabIndex = 14;
            this.lblDisp.Text = "Disponibilidad:";
            // 
            // cmbDisp
            // 
            this.cmbDisp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisp.Enabled = false;
            this.cmbDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDisp.FormattingEnabled = true;
            this.cmbDisp.Items.AddRange(new object[] {
            "Disponible",
            "No Disponible",
            "En Revision"});
            this.cmbDisp.Location = new System.Drawing.Point(107, 136);
            this.cmbDisp.Name = "cmbDisp";
            this.cmbDisp.Size = new System.Drawing.Size(119, 24);
            this.cmbDisp.TabIndex = 15;
            // 
            // frmDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 260);
            this.Controls.Add(this.gpbProd);
            this.Controls.Add(this.tspMenu);
            this.Name = "frmDevice";
            this.Text = "frmDevice";
            this.Load += new System.EventHandler(this.frmDevice_Load);
            this.gpbProd.ResumeLayout(false);
            this.gpbProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNumSerie)).EndInit();
            this.tspMenu.ResumeLayout(false);
            this.tspMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbProd;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.Label lblMAC;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.ToolStrip tspMenu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.PictureBox pbLote;
        private System.Windows.Forms.PictureBox pbMAC;
        private System.Windows.Forms.PictureBox pbNumSerie;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.ComboBox cmbDisp;
        private System.Windows.Forms.Label lblDisp;
    }
}