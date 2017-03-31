namespace WindowsFormsApplication3
{
    partial class frmBuscarLote
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
            this.gpbBuscarL = new System.Windows.Forms.GroupBox();
            this.lblL = new System.Windows.Forms.Label();
            this.pbL = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.lblNumLote = new System.Windows.Forms.Label();
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.ckbAll = new System.Windows.Forms.CheckBox();
            this.gpbBuscarL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.gpbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbBuscarL
            // 
            this.gpbBuscarL.Controls.Add(this.gpbSearch);
            this.gpbBuscarL.Controls.Add(this.btnCancel);
            this.gpbBuscarL.Controls.Add(this.btnOk);
            this.gpbBuscarL.Controls.Add(this.dgvBuscar);
            this.gpbBuscarL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBuscarL.Location = new System.Drawing.Point(20, 19);
            this.gpbBuscarL.Name = "gpbBuscarL";
            this.gpbBuscarL.Size = new System.Drawing.Size(548, 323);
            this.gpbBuscarL.TabIndex = 3;
            this.gpbBuscarL.TabStop = false;
            this.gpbBuscarL.Text = "Buscar_Lote";
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Location = new System.Drawing.Point(284, 27);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(0, 16);
            this.lblL.TabIndex = 9;
            // 
            // pbL
            // 
            this.pbL.Location = new System.Drawing.Point(251, 25);
            this.pbL.Name = "pbL";
            this.pbL.Size = new System.Drawing.Size(26, 20);
            this.pbL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbL.TabIndex = 8;
            this.pbL.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(451, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cerrar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(23, 274);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Aceptar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Location = new System.Drawing.Point(23, 143);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.Size = new System.Drawing.Size(503, 125);
            this.dgvBuscar.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(422, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtLote
            // 
            this.txtLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote.Location = new System.Drawing.Point(96, 25);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(148, 22);
            this.txtLote.TabIndex = 1;
            // 
            // lblNumLote
            // 
            this.lblNumLote.AutoSize = true;
            this.lblNumLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumLote.Location = new System.Drawing.Point(27, 28);
            this.lblNumLote.Name = "lblNumLote";
            this.lblNumLote.Size = new System.Drawing.Size(71, 16);
            this.lblNumLote.TabIndex = 0;
            this.lblNumLote.Text = "Num. Lote:";
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.ckbAll);
            this.gpbSearch.Controls.Add(this.btnSearch);
            this.gpbSearch.Controls.Add(this.txtLote);
            this.gpbSearch.Controls.Add(this.lblL);
            this.gpbSearch.Controls.Add(this.lblNumLote);
            this.gpbSearch.Controls.Add(this.pbL);
            this.gpbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSearch.Location = new System.Drawing.Point(23, 36);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(503, 88);
            this.gpbSearch.TabIndex = 10;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "Buscar";
            // 
            // ckbAll
            // 
            this.ckbAll.AutoSize = true;
            this.ckbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAll.Location = new System.Drawing.Point(96, 54);
            this.ckbAll.Name = "ckbAll";
            this.ckbAll.Size = new System.Drawing.Size(176, 20);
            this.ckbAll.TabIndex = 10;
            this.ckbAll.Text = "Mostrar Todos Los Lotes";
            this.ckbAll.UseVisualStyleBackColor = true;
            // 
            // frmBuscarLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 367);
            this.Controls.Add(this.gpbBuscarL);
            this.Name = "frmBuscarLote";
            this.Text = "frmBuscarLote";
            this.gpbBuscarL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbBuscarL;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label lblNumLote;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.PictureBox pbL;
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.CheckBox ckbAll;
    }
}