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
    public partial class mReporteU : Form
    {
        public mReporteU()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cmbIssue.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Debes Seleccionar una Ubicacion antes de Generar el Reporte!!!");
            }
            else
            {
                MostrarU Mostrar = new MostrarU();
                Mostrar.ub = cmbIssue.Text;
                Mostrar.ShowDialog();

                cmbIssue.SelectedIndex = -1;
            }
            
        }
    }
}
