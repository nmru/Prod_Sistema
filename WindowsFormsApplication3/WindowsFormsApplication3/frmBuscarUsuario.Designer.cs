namespace WindowsFormsApplication3
{
    partial class frmBuscarUsuario
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
            this.components = new System.ComponentModel.Container();
            this.gpbBuscarU = new System.Windows.Forms.GroupBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.pbA = new System.Windows.Forms.PictureBox();
            this.pbN = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAp = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.produccionDataSet2 = new WindowsFormsApplication3.produccionDataSet2();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new WindowsFormsApplication3.produccionDataSet2TableAdapters.usuarioTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbAll = new System.Windows.Forms.CheckBox();
            this.gpbBuscarU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produccionDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbBuscarU
            // 
            this.gpbBuscarU.Controls.Add(this.groupBox1);
            this.gpbBuscarU.Controls.Add(this.btnCancel);
            this.gpbBuscarU.Controls.Add(this.btnOk);
            this.gpbBuscarU.Controls.Add(this.dgvBuscar);
            this.gpbBuscarU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBuscarU.Location = new System.Drawing.Point(17, 24);
            this.gpbBuscarU.Name = "gpbBuscarU";
            this.gpbBuscarU.Size = new System.Drawing.Size(556, 389);
            this.gpbBuscarU.TabIndex = 16;
            this.gpbBuscarU.TabStop = false;
            this.gpbBuscarU.Text = "BuscarUsuario";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(269, 61);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 16);
            this.lblA.TabIndex = 11;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(269, 25);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(0, 16);
            this.lblN.TabIndex = 10;
            // 
            // pbA
            // 
            this.pbA.Location = new System.Drawing.Point(232, 62);
            this.pbA.Name = "pbA";
            this.pbA.Size = new System.Drawing.Size(30, 20);
            this.pbA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbA.TabIndex = 9;
            this.pbA.TabStop = false;
            // 
            // pbN
            // 
            this.pbN.Location = new System.Drawing.Point(232, 25);
            this.pbN.Name = "pbN";
            this.pbN.Size = new System.Drawing.Size(30, 20);
            this.pbN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbN.TabIndex = 8;
            this.pbN.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Apellido:";
            // 
            // txtAp
            // 
            this.txtAp.Location = new System.Drawing.Point(78, 62);
            this.txtAp.Name = "txtAp";
            this.txtAp.Size = new System.Drawing.Size(147, 22);
            this.txtAp.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(465, 348);
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
            this.btnOk.Location = new System.Drawing.Point(13, 348);
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
            this.dgvBuscar.Location = new System.Drawing.Point(13, 164);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.Size = new System.Drawing.Size(527, 166);
            this.dgvBuscar.TabIndex = 3;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(15, 28);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(60, 16);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Nombre:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(443, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(78, 25);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(147, 22);
            this.txtNom.TabIndex = 1;
            // 
            // produccionDataSet2
            // 
            this.produccionDataSet2.DataSetName = "produccionDataSet2";
            this.produccionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.produccionDataSet2;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbAll);
            this.groupBox1.Controls.Add(this.txtAp);
            this.groupBox1.Controls.Add(this.lblA);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.lblN);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.pbA);
            this.groupBox1.Controls.Add(this.lblBuscar);
            this.groupBox1.Controls.Add(this.pbN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 120);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // ckbAll
            // 
            this.ckbAll.AutoSize = true;
            this.ckbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAll.Location = new System.Drawing.Point(78, 96);
            this.ckbAll.Name = "ckbAll";
            this.ckbAll.Size = new System.Drawing.Size(197, 20);
            this.ckbAll.TabIndex = 12;
            this.ckbAll.Text = "Mostrar Todos Los Usuarios";
            this.ckbAll.UseVisualStyleBackColor = true;
            // 
            // frmBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 429);
            this.Controls.Add(this.gpbBuscarU);
            this.Name = "frmBuscarUsuario";
            this.Text = "frmBuscarUsuario";
            this.Load += new System.EventHandler(this.frmBuscarUsuario_Load);
            this.gpbBuscarU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produccionDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbBuscarU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.PictureBox pbA;
        private System.Windows.Forms.PictureBox pbN;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblN;
        private produccionDataSet2 produccionDataSet2;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private produccionDataSet2TableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbAll;
    }
}