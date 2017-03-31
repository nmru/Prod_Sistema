namespace WindowsFormsApplication3
{
    partial class frmUsuario
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
            this.gpbUsuario = new System.Windows.Forms.GroupBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblAr = new System.Windows.Forms.Label();
            this.pbP = new System.Windows.Forms.PictureBox();
            this.pbAr = new System.Windows.Forms.PictureBox();
            this.lblc = new System.Windows.Forms.Label();
            this.pbC = new System.Windows.Forms.PictureBox();
            this.lblU = new System.Windows.Forms.Label();
            this.pbU = new System.Windows.Forms.PictureBox();
            this.lblA = new System.Windows.Forms.Label();
            this.pbA = new System.Windows.Forms.PictureBox();
            this.lblN = new System.Windows.Forms.Label();
            this.pbN = new System.Windows.Forms.PictureBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.txtAp = new System.Windows.Forms.TextBox();
            this.lblAp = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tspMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.gpbUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbN)).BeginInit();
            this.tspMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbUsuario
            // 
            this.gpbUsuario.Controls.Add(this.cmbRol);
            this.gpbUsuario.Controls.Add(this.lblRol);
            this.gpbUsuario.Controls.Add(this.lblP);
            this.gpbUsuario.Controls.Add(this.lblAr);
            this.gpbUsuario.Controls.Add(this.pbP);
            this.gpbUsuario.Controls.Add(this.pbAr);
            this.gpbUsuario.Controls.Add(this.lblc);
            this.gpbUsuario.Controls.Add(this.pbC);
            this.gpbUsuario.Controls.Add(this.lblU);
            this.gpbUsuario.Controls.Add(this.pbU);
            this.gpbUsuario.Controls.Add(this.lblA);
            this.gpbUsuario.Controls.Add(this.pbA);
            this.gpbUsuario.Controls.Add(this.lblN);
            this.gpbUsuario.Controls.Add(this.pbN);
            this.gpbUsuario.Controls.Add(this.lblPuesto);
            this.gpbUsuario.Controls.Add(this.txtPuesto);
            this.gpbUsuario.Controls.Add(this.txtAp);
            this.gpbUsuario.Controls.Add(this.lblAp);
            this.gpbUsuario.Controls.Add(this.txtNom);
            this.gpbUsuario.Controls.Add(this.lblNom);
            this.gpbUsuario.Controls.Add(this.txtArea);
            this.gpbUsuario.Controls.Add(this.txtPass);
            this.gpbUsuario.Controls.Add(this.txtUsuario);
            this.gpbUsuario.Controls.Add(this.lblArea);
            this.gpbUsuario.Controls.Add(this.lblPass);
            this.gpbUsuario.Controls.Add(this.lblUsuario);
            this.gpbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbUsuario.Location = new System.Drawing.Point(36, 25);
            this.gpbUsuario.Name = "gpbUsuario";
            this.gpbUsuario.Size = new System.Drawing.Size(446, 260);
            this.gpbUsuario.TabIndex = 3;
            this.gpbUsuario.TabStop = false;
            this.gpbUsuario.Text = "Datos_Usuario";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Enabled = false;
            this.cmbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Administrador",
            "Observador"});
            this.cmbRol.Location = new System.Drawing.Point(100, 213);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(132, 24);
            this.cmbRol.TabIndex = 26;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(61, 213);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(33, 17);
            this.lblRol.TabIndex = 25;
            this.lblRol.Text = "Rol:";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(272, 183);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(0, 20);
            this.lblP.TabIndex = 24;
            // 
            // lblAr
            // 
            this.lblAr.AutoSize = true;
            this.lblAr.Location = new System.Drawing.Point(272, 152);
            this.lblAr.Name = "lblAr";
            this.lblAr.Size = new System.Drawing.Size(0, 20);
            this.lblAr.TabIndex = 23;
            // 
            // pbP
            // 
            this.pbP.Location = new System.Drawing.Point(239, 183);
            this.pbP.Name = "pbP";
            this.pbP.Size = new System.Drawing.Size(26, 20);
            this.pbP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbP.TabIndex = 22;
            this.pbP.TabStop = false;
            // 
            // pbAr
            // 
            this.pbAr.Location = new System.Drawing.Point(239, 152);
            this.pbAr.Name = "pbAr";
            this.pbAr.Size = new System.Drawing.Size(26, 20);
            this.pbAr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAr.TabIndex = 21;
            this.pbAr.TabStop = false;
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(275, 129);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(0, 20);
            this.lblc.TabIndex = 20;
            // 
            // pbC
            // 
            this.pbC.Location = new System.Drawing.Point(239, 123);
            this.pbC.Name = "pbC";
            this.pbC.Size = new System.Drawing.Size(26, 19);
            this.pbC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbC.TabIndex = 19;
            this.pbC.TabStop = false;
            // 
            // lblU
            // 
            this.lblU.AutoSize = true;
            this.lblU.Location = new System.Drawing.Point(272, 97);
            this.lblU.Name = "lblU";
            this.lblU.Size = new System.Drawing.Size(0, 20);
            this.lblU.TabIndex = 18;
            // 
            // pbU
            // 
            this.pbU.Location = new System.Drawing.Point(239, 94);
            this.pbU.Name = "pbU";
            this.pbU.Size = new System.Drawing.Size(26, 20);
            this.pbU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbU.TabIndex = 17;
            this.pbU.TabStop = false;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(272, 70);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 20);
            this.lblA.TabIndex = 16;
            // 
            // pbA
            // 
            this.pbA.Location = new System.Drawing.Point(239, 65);
            this.pbA.Name = "pbA";
            this.pbA.Size = new System.Drawing.Size(26, 20);
            this.pbA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbA.TabIndex = 15;
            this.pbA.TabStop = false;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(272, 42);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(0, 20);
            this.lblN.TabIndex = 14;
            // 
            // pbN
            // 
            this.pbN.Location = new System.Drawing.Point(239, 37);
            this.pbN.Name = "pbN";
            this.pbN.Size = new System.Drawing.Size(26, 20);
            this.pbN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbN.TabIndex = 13;
            this.pbN.TabStop = false;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(38, 183);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(56, 17);
            this.lblPuesto.TabIndex = 12;
            this.lblPuesto.Text = "Puesto:";
            // 
            // txtPuesto
            // 
            this.txtPuesto.Enabled = false;
            this.txtPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuesto.Location = new System.Drawing.Point(100, 183);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(132, 23);
            this.txtPuesto.TabIndex = 11;
            // 
            // txtAp
            // 
            this.txtAp.Enabled = false;
            this.txtAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAp.Location = new System.Drawing.Point(100, 65);
            this.txtAp.Name = "txtAp";
            this.txtAp.Size = new System.Drawing.Size(132, 23);
            this.txtAp.TabIndex = 10;
            // 
            // lblAp
            // 
            this.lblAp.AutoSize = true;
            this.lblAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAp.Location = new System.Drawing.Point(37, 65);
            this.lblAp.Name = "lblAp";
            this.lblAp.Size = new System.Drawing.Size(62, 17);
            this.lblAp.TabIndex = 9;
            this.lblAp.Text = "Apellido:";
            // 
            // txtNom
            // 
            this.txtNom.Enabled = false;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(100, 37);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(132, 23);
            this.txtNom.TabIndex = 8;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(37, 37);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(62, 17);
            this.lblNom.TabIndex = 7;
            this.lblNom.Text = "Nombre:";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(100, 152);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(132, 23);
            this.txtArea.TabIndex = 5;
            // 
            // txtPass
            // 
            this.txtPass.Enabled = false;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(100, 123);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(132, 23);
            this.txtPass.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(100, 94);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(132, 23);
            this.txtUsuario.TabIndex = 3;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(52, 152);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 17);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(14, 123);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(85, 17);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(1, 97);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(98, 17);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Nom. Usuario:";
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
            this.tspMenu.Location = new System.Drawing.Point(0, 312);
            this.tspMenu.Name = "tspMenu";
            this.tspMenu.Size = new System.Drawing.Size(515, 25);
            this.tspMenu.TabIndex = 2;
            this.tspMenu.Text = "Acciones";
            // 
            // btnNuevo
            // 
            this.btnNuevo.CheckOnClick = true;
            this.btnNuevo.Image = global::WindowsFormsApplication3.Properties.Resources._new;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(66, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.CheckOnClick = true;
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
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 337);
            this.Controls.Add(this.gpbUsuario);
            this.Controls.Add(this.tspMenu);
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.gpbUsuario.ResumeLayout(false);
            this.gpbUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbN)).EndInit();
            this.tspMenu.ResumeLayout(false);
            this.tspMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbUsuario;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.TextBox txtAp;
        private System.Windows.Forms.Label lblAp;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ToolStrip tspMenu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.PictureBox pbC;
        private System.Windows.Forms.Label lblU;
        private System.Windows.Forms.PictureBox pbU;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.PictureBox pbA;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.PictureBox pbN;
        private System.Windows.Forms.PictureBox pbAr;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblAr;
        private System.Windows.Forms.PictureBox pbP;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblRol;
    }
}