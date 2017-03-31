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
    public partial class mEtapaF : Form
    {
        public mEtapaF()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cmbEtapa.SelectedIndex.Equals(-1) || dtpF1.Checked ==false || dtpF2.Checked == false)
            {
                MessageBox.Show("Debes Ingresar Informacion en Todos Los Campos!!!");
                cmbEtapa.SelectedIndex = -1;
                dtpF1.ResetText();
                dtpF2.ResetText();
            }

            if (cmbEtapa.SelectedIndex != -1 && dtpF1.Checked == true || dtpF2.Checked == true)
             {
                MostrarEFechas Mostrar = new MostrarEFechas();
                 Mostrar.et = cmbEtapa.Text;
                 Mostrar.f1 = dtpF1.Value;
                 Mostrar.f2 = dtpF2.Value;
                 Mostrar.ShowDialog();
                
                 dtpF1.ResetText();
                 dtpF2.ResetText();
                 cmbEtapa.SelectedIndex = -1;
             }

            }
           
        }
    }

