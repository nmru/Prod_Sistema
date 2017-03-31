namespace WindowsFormsApplication3
{
    partial class Main
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
            this.gpbReportes = new System.Windows.Forms.GroupBox();
            this.tpsExit = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.tpsReportes2 = new System.Windows.Forms.ToolStrip();
            this.btnReporteUb = new System.Windows.Forms.ToolStripButton();
            this.btnReportSL = new System.Windows.Forms.ToolStripButton();
            this.btnReportePF = new System.Windows.Forms.ToolStripButton();
            this.tpsReportes = new System.Windows.Forms.ToolStrip();
            this.btnrIssues = new System.Windows.Forms.ToolStripButton();
            this.btnLote = new System.Windows.Forms.ToolStripButton();
            this.btnEtapa = new System.Windows.Forms.ToolStripButton();
            this.btnReporteR = new System.Windows.Forms.ToolStripButton();
            this.gpbAdmon = new System.Windows.Forms.GroupBox();
            this.tspAdmon = new System.Windows.Forms.ToolStrip();
            this.btnUsuario = new System.Windows.Forms.ToolStripButton();
            this.tpsDevice = new System.Windows.Forms.ToolStripButton();
            this.btnLotes = new System.Windows.Forms.ToolStripButton();
            this.btnEvalaucion = new System.Windows.Forms.ToolStripButton();
            this.btnReposicion = new System.Windows.Forms.ToolStripButton();
            this.gpbReportes.SuspendLayout();
            this.tpsExit.SuspendLayout();
            this.tpsReportes2.SuspendLayout();
            this.tpsReportes.SuspendLayout();
            this.gpbAdmon.SuspendLayout();
            this.tspAdmon.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbReportes
            // 
            this.gpbReportes.Controls.Add(this.tpsExit);
            this.gpbReportes.Controls.Add(this.tpsReportes2);
            this.gpbReportes.Controls.Add(this.tpsReportes);
            this.gpbReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbReportes.Location = new System.Drawing.Point(22, 118);
            this.gpbReportes.Name = "gpbReportes";
            this.gpbReportes.Size = new System.Drawing.Size(469, 129);
            this.gpbReportes.TabIndex = 3;
            this.gpbReportes.TabStop = false;
            this.gpbReportes.Text = "Reportes";
            // 
            // tpsExit
            // 
            this.tpsExit.Dock = System.Windows.Forms.DockStyle.None;
            this.tpsExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpsExit.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tpsExit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir});
            this.tpsExit.Location = new System.Drawing.Point(397, 102);
            this.tpsExit.Name = "tpsExit";
            this.tpsExit.Size = new System.Drawing.Size(69, 27);
            this.tpsExit.TabIndex = 2;
            this.tpsExit.Text = "tspSalir";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::WindowsFormsApplication3.Properties.Resources.exit;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(57, 24);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tpsReportes2
            // 
            this.tpsReportes2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReporteUb,
            this.btnReportSL,
            this.btnReportePF});
            this.tpsReportes2.Location = new System.Drawing.Point(3, 45);
            this.tpsReportes2.Name = "tpsReportes2";
            this.tpsReportes2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tpsReportes2.Size = new System.Drawing.Size(463, 25);
            this.tpsReportes2.TabIndex = 1;
            this.tpsReportes2.Text = "toolStrip1";
            // 
            // btnReporteUb
            // 
            this.btnReporteUb.Image = global::WindowsFormsApplication3.Properties.Resources.report;
            this.btnReporteUb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReporteUb.Name = "btnReporteUb";
            this.btnReporteUb.Size = new System.Drawing.Size(124, 22);
            this.btnReporteUb.Text = "Reporte Ubicacion";
            this.btnReporteUb.ToolTipText = "btnReporte";
            this.btnReporteUb.Click += new System.EventHandler(this.btnReporteUb_Click);
            // 
            // btnReportSL
            // 
            this.btnReportSL.Image = global::WindowsFormsApplication3.Properties.Resources.report;
            this.btnReportSL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportSL.Name = "btnReportSL";
            this.btnReportSL.Size = new System.Drawing.Size(106, 22);
            this.btnReportSL.Text = "Reporte S. Lote";
            this.btnReportSL.Click += new System.EventHandler(this.btnReportSL_Click);
            // 
            // btnReportePF
            // 
            this.btnReportePF.Image = global::WindowsFormsApplication3.Properties.Resources.report;
            this.btnReportePF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportePF.Name = "btnReportePF";
            this.btnReportePF.Size = new System.Drawing.Size(128, 22);
            this.btnReportePF.Text = "Reporte Evaluacion";
            this.btnReportePF.Click += new System.EventHandler(this.btnReportePF_Click);
            // 
            // tpsReportes
            // 
            this.tpsReportes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnrIssues,
            this.btnLote,
            this.btnEtapa,
            this.btnReporteR});
            this.tpsReportes.Location = new System.Drawing.Point(3, 20);
            this.tpsReportes.Name = "tpsReportes";
            this.tpsReportes.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tpsReportes.Size = new System.Drawing.Size(463, 25);
            this.tpsReportes.Stretch = true;
            this.tpsReportes.TabIndex = 0;
            this.tpsReportes.Text = "Reporte Issue";
            // 
            // btnrIssues
            // 
            this.btnrIssues.Image = global::WindowsFormsApplication3.Properties.Resources.report;
            this.btnrIssues.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnrIssues.Name = "btnrIssues";
            this.btnrIssues.Size = new System.Drawing.Size(102, 22);
            this.btnrIssues.Text = "Reporte Issues";
            this.btnrIssues.Click += new System.EventHandler(this.btnrIssues_Click);
            // 
            // btnLote
            // 
            this.btnLote.Image = global::WindowsFormsApplication3.Properties.Resources.report;
            this.btnLote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLote.Name = "btnLote";
            this.btnLote.Size = new System.Drawing.Size(99, 22);
            this.btnLote.Text = "Reporte Lotes";
            this.btnLote.Click += new System.EventHandler(this.btnLote_Click);
            // 
            // btnEtapa
            // 
            this.btnEtapa.Image = global::WindowsFormsApplication3.Properties.Resources.report;
            this.btnEtapa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEtapa.Name = "btnEtapa";
            this.btnEtapa.Size = new System.Drawing.Size(100, 22);
            this.btnEtapa.Text = "Reporte Etapa";
            this.btnEtapa.Click += new System.EventHandler(this.btnEtapa_Click);
            // 
            // btnReporteR
            // 
            this.btnReporteR.Image = global::WindowsFormsApplication3.Properties.Resources.report;
            this.btnReporteR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReporteR.Name = "btnReporteR";
            this.btnReporteR.Size = new System.Drawing.Size(129, 22);
            this.btnReporteR.Text = "Reporte Reposicion";
            this.btnReporteR.Click += new System.EventHandler(this.btnReporteR_Click);
            // 
            // gpbAdmon
            // 
            this.gpbAdmon.Controls.Add(this.tspAdmon);
            this.gpbAdmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAdmon.Location = new System.Drawing.Point(25, 28);
            this.gpbAdmon.Name = "gpbAdmon";
            this.gpbAdmon.Size = new System.Drawing.Size(466, 84);
            this.gpbAdmon.TabIndex = 2;
            this.gpbAdmon.TabStop = false;
            this.gpbAdmon.Text = "Administracion de Datos";
            // 
            // tspAdmon
            // 
            this.tspAdmon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tspAdmon.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tspAdmon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUsuario,
            this.tpsDevice,
            this.btnLotes,
            this.btnEvalaucion,
            this.btnReposicion});
            this.tspAdmon.Location = new System.Drawing.Point(3, 20);
            this.tspAdmon.Name = "tspAdmon";
            this.tspAdmon.Size = new System.Drawing.Size(460, 61);
            this.tspAdmon.TabIndex = 0;
            this.tspAdmon.Text = "toolStrip1";
            // 
            // btnUsuario
            // 
            this.btnUsuario.Image = global::WindowsFormsApplication3.Properties.Resources.user;
            this.btnUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(81, 58);
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // tpsDevice
            // 
            this.tpsDevice.Image = global::WindowsFormsApplication3.Properties.Resources.router;
            this.tpsDevice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tpsDevice.Name = "tpsDevice";
            this.tpsDevice.Size = new System.Drawing.Size(76, 58);
            this.tpsDevice.Text = "Devices";
            this.tpsDevice.Click += new System.EventHandler(this.tpsDevice_Click);
            // 
            // btnLotes
            // 
            this.btnLotes.Image = global::WindowsFormsApplication3.Properties.Resources.pack;
            this.btnLotes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLotes.Name = "btnLotes";
            this.btnLotes.Size = new System.Drawing.Size(64, 58);
            this.btnLotes.Text = "Lotes";
            this.btnLotes.ToolTipText = "Lotes";
            this.btnLotes.Click += new System.EventHandler(this.btnLotes_Click);
            // 
            // btnEvalaucion
            // 
            this.btnEvalaucion.Image = global::WindowsFormsApplication3.Properties.Resources.eval;
            this.btnEvalaucion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEvalaucion.Name = "btnEvalaucion";
            this.btnEvalaucion.Size = new System.Drawing.Size(93, 58);
            this.btnEvalaucion.Text = "Evaluacion";
            this.btnEvalaucion.Click += new System.EventHandler(this.btnEvalaucion_Click);
            // 
            // btnReposicion
            // 
            this.btnReposicion.Image = global::WindowsFormsApplication3.Properties.Resources.replace1;
            this.btnReposicion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReposicion.Name = "btnReposicion";
            this.btnReposicion.Size = new System.Drawing.Size(105, 58);
            this.btnReposicion.Text = "Reposiciones";
            this.btnReposicion.Click += new System.EventHandler(this.btnReposicion_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 274);
            this.Controls.Add(this.gpbReportes);
            this.Controls.Add(this.gpbAdmon);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.gpbReportes.ResumeLayout(false);
            this.gpbReportes.PerformLayout();
            this.tpsExit.ResumeLayout(false);
            this.tpsExit.PerformLayout();
            this.tpsReportes2.ResumeLayout(false);
            this.tpsReportes2.PerformLayout();
            this.tpsReportes.ResumeLayout(false);
            this.tpsReportes.PerformLayout();
            this.gpbAdmon.ResumeLayout(false);
            this.gpbAdmon.PerformLayout();
            this.tspAdmon.ResumeLayout(false);
            this.tspAdmon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbReportes;
        private System.Windows.Forms.ToolStrip tpsReportes;
        private System.Windows.Forms.ToolStripButton btnrIssues;
        private System.Windows.Forms.ToolStripButton btnLote;
        private System.Windows.Forms.ToolStripButton btnEtapa;
        private System.Windows.Forms.GroupBox gpbAdmon;
        private System.Windows.Forms.ToolStrip tspAdmon;
        private System.Windows.Forms.ToolStripButton btnUsuario;
        private System.Windows.Forms.ToolStripButton tpsDevice;
        private System.Windows.Forms.ToolStripButton btnLotes;
        private System.Windows.Forms.ToolStripButton btnEvalaucion;
        private System.Windows.Forms.ToolStrip tpsReportes2;
        private System.Windows.Forms.ToolStripButton btnReporteUb;
        private System.Windows.Forms.ToolStripButton btnReportePF;
        private System.Windows.Forms.ToolStripButton btnReportSL;
        private System.Windows.Forms.ToolStripButton btnReporteR;
        private System.Windows.Forms.ToolStripButton btnReposicion;
        private System.Windows.Forms.ToolStrip tpsExit;
        private System.Windows.Forms.ToolStripButton btnSalir;
    }
}