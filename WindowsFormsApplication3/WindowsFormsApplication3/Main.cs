using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmUsuario Buscar = new frmUsuario();
            Buscar.Show();
        }

        private void tpsDevice_Click(object sender, EventArgs e)
        {
            frmDevice Buscar = new frmDevice();
            Buscar.Show();
        }

        private void btnLotes_Click(object sender, EventArgs e)
        {
            frmLote Buscar = new frmLote();
            Buscar.Show();
        }

        private void btnEvalaucion_Click(object sender, EventArgs e)
        {
            frmProd_Etapa Buscar = new frmProd_Etapa();
            Buscar.Show();
        }

        private void btnrIssues_Click(object sender, EventArgs e)
        {
            mReporteI Buscar = new mReporteI();
            Buscar.Show();
        }

        private void btnLote_Click(object sender, EventArgs e)
        {
            mReporteL Buscar = new mReporteL();
            Buscar.Show();
        }

        private void btnEtapa_Click(object sender, EventArgs e)
        {
            mReporteF Buscar = new mReporteF();
            Buscar.Show();
        }

        private void btnReporteUb_Click(object sender, EventArgs e)
        {
            mReporteU Buscar = new mReporteU();
            Buscar.Show();
        }

        private void btnReportePF_Click(object sender, EventArgs e)
        {
            mEtapaF Buscar = new mEtapaF();
            Buscar.Show();
        }

        private void btnReportSL_Click(object sender, EventArgs e)
        {
            mStatusL Buscar = new mStatusL();
            Buscar.Show();
        }

        private void btnReposicion_Click(object sender, EventArgs e)
        {
            frmReposicion Buscar = new frmReposicion();
            Buscar.Show();
        }

        private void btnReporteR_Click(object sender, EventArgs e)
        {
            mReporteRep Buscar = new mReporteRep();
            Buscar.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
          if (Global.tUsuario!= "Administrador")
            {
                tspAdmon.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
