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
    public partial class mReporteI : Form
    {
        public mReporteI()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            if ( cmbIssue.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Debes Seleccionar un Tipo de Issue antes de Generar el Reporte!!!");
            }
            else
            {
                MostrarI Mostrar = new MostrarI();
                Mostrar.issue = cmbIssue.Text;
                Mostrar.ShowDialog();

                cmbIssue.SelectedIndex = -1;

            }

        }
    }
}
