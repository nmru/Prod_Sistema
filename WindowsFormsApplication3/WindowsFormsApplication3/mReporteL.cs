using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication3
{
    public partial class mReporteL : Form
    {
        public mReporteL()
        {
            InitializeComponent();
        }

        public bool v { get; set; }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int v1 = 0, v2 = 0;
            MostrarL Mostrar = new MostrarL();

            for (int c = 0; c <= 1; c++)
            {
                switch (c)
                {
                    case 0:
                        Regexp(@"^[0-9]{1,4}$", txtLote, pbL, lblL, "Num. Lote");
                        if (v == true)
                            v1 = 1;
                        if (txtSerie.Text == "")
                            pbS.Dispose();
                            lblS.Dispose();
                           // txtSerie.Enabled = false;
                        break;
                    case 1:
                        Regexp(@"^[0-9]{12}$", txtSerie, pbS, lblS, "Numero Serie");
                        if (v == true)
                            v2 = 1;
                        if ( txtLote.Text == "")
                           // txtLote.Enabled = false;
                            pbL.Dispose();
                            lblL.Dispose();
                        break;
                }


            }
            

            if (txtLote.Text == "" && txtSerie.Text == "")
            {
                MessageBox.Show("Debes Introducir un Valor en cualquiera de los dos campos!!!");
            }

            if (txtLote.Text != "" || txtSerie.Text != "")
            {
                if (v1 == 1 || v2 == 1)
                {

                    if (v1 == 1)
                    {
                       
                        if (txtLote.Text != "" && txtSerie.Text == "")
                        {
                           txtSerie.Enabled = false;
                            pbS.Dispose();
                            lblS.Dispose();
                            Mostrar.pack = Int32.Parse(txtLote.Text);
                            Mostrar.ShowDialog();

                            txtLote.Clear();
                            txtSerie.Clear();
                        }
                    }
                }


                if (txtSerie.Text != "" && txtLote.Text == "")
                {
                    if (v2 == 1)
                    {
                        txtLote.Enabled = false;
                        pbL.Dispose();
                        lblL.Dispose();
                        Mostrar.serie = txtSerie.Text;
                        Mostrar.ShowDialog();

                        txtLote.Clear();
                        txtSerie.Clear();
                    }
                }

                if (txtLote.Text != "" && txtSerie.Text != "")
                {
                    MessageBox.Show("Solo Debes Introducir un Valor en cualquiera de los dos campos!!");
                    txtLote.Clear();
                    txtSerie.Clear();
                }
            }
          

            if (v1 == 0 && txtSerie.Text == ""&& txtLote.Text!="")
            {
                MessageBox.Show("Numero de Lote Permite Maximo 4 Caracteres!!");
                txtLote.Clear();
                txtLote.Focus();
               txtSerie.Enabled = false;
                pbS.Dispose();
                lblS.Dispose();

            }

            if (v2 == 0 && txtLote.Text == "" && txtSerie.Text!="")
            {
                MessageBox.Show("Numero de Serie Esta conformado por 12 Caracteres!!");
                txtLote.Clear();
                txtLote.Focus();
               // txtSerie.Enabled = false;
                pbL.Dispose();
                lblL.Dispose();
            }
        }

        public void Regexp(string re, TextBox tb, PictureBox pcb, Label lbl, string s)
        {
            v = false;
            Regex regex = new Regex(re);
            if (regex.IsMatch(tb.Text))
            {
                pcb.Image = Properties.Resources.ok;
                lbl.ForeColor = Color.Green;
                lbl.Text = "";
                v = true;
            }

            else
            {
                pcb.Image = Properties.Resources.red_cross_icon_21533;
                lbl.ForeColor = Color.Red;
                lbl.Text = s + " Invalid@";
                
            }
        }

    }
}
