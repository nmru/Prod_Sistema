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
    public partial class mReporteF : Form
    {
        public mReporteF()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
           if (cmbEtapa.SelectedIndex.Equals(-1) || dtpFecha.Checked == false)
           {
               MessageBox.Show("Debes Introducir Ambos Valores");
               cmbEtapa.SelectedIndex = -1;
               dtpFecha.ResetText();
          }
           else
            {
                if (cmbEtapa.SelectedIndex != -1 && dtpFecha.Checked == true)
                {
                    MostrarEF Mostrar = new MostrarEF();
                    Mostrar.et = cmbEtapa.Text;
                    Mostrar.f = dtpFecha.Value;
                    Mostrar.ShowDialog();

                    cmbEtapa.SelectedIndex = -1;
                    dtpFecha.ResetText();
                }
               
           }

        }
    }
}
