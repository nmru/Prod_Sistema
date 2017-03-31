namespace WindowsFormsApplication3
{
    partial class mReporteI
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
            this.gpbIssue = new System.Windows.Forms.GroupBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cmbIssue = new System.Windows.Forms.ComboBox();
            this.lblIssue = new System.Windows.Forms.Label();
            this.gpbIssue.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbIssue
            // 
            this.gpbIssue.Controls.Add(this.btnGenerar);
            this.gpbIssue.Controls.Add(this.cmbIssue);
            this.gpbIssue.Controls.Add(this.lblIssue);
            this.gpbIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbIssue.ForeColor = System.Drawing.Color.Blue;
            this.gpbIssue.Location = new System.Drawing.Point(27, 12);
            this.gpbIssue.Name = "gpbIssue";
            this.gpbIssue.Size = new System.Drawing.Size(315, 205);
            this.gpbIssue.TabIndex = 2;
            this.gpbIssue.TabStop = false;
            this.gpbIssue.Text = "Reporte por Tipo de Issue";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGenerar.Location = new System.Drawing.Point(68, 133);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(190, 36);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cmbIssue
            // 
            this.cmbIssue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIssue.FormattingEnabled = true;
            this.cmbIssue.Items.AddRange(new object[] {
            "Firmado",
            "Pruebas"});
            this.cmbIssue.Location = new System.Drawing.Point(106, 58);
            this.cmbIssue.Name = "cmbIssue";
            this.cmbIssue.Size = new System.Drawing.Size(189, 28);
            this.cmbIssue.TabIndex = 1;
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssue.Location = new System.Drawing.Point(7, 64);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(93, 16);
            this.lblIssue.TabIndex = 0;
            this.lblIssue.Text = "Tipo de Issue:";
            // 
            // mReporteI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 237);
            this.Controls.Add(this.gpbIssue);
            this.Name = "mReporteI";
            this.Text = "mReporteI";
            this.gpbIssue.ResumeLayout(false);
            this.gpbIssue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbIssue;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cmbIssue;
        private System.Windows.Forms.Label lblIssue;
    }
}