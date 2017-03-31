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
    public partial class mStatusL : Form
    {
        public mStatusL()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Debes Seleccionar un Status antes de Generar el Reporte!!!");
                cmbStatus.SelectedIndex = -1;
            }
            else
            {
                MostrarS Mostrar = new MostrarS();
                Mostrar.st = cmbStatus.Text;
                Mostrar.ShowDialog();

                cmbStatus.SelectedIndex = -1;
            }
        }
    }
}
