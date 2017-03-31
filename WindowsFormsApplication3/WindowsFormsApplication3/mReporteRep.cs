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
    public partial class mReporteRep : Form
    {
        public mReporteRep()
        {
            InitializeComponent();
        }

        public bool v { get; set; }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            if (cmbMotivo.SelectedIndex.Equals(-1) && txtAuto.Text == "" && txtCanal.Text == "" && txtCte.Text == "")
            {
                MessageBox.Show("Debes Introducir un Valor en cualquiera de los campos!!!");
            }
            else
            {
                MostrarRep Mostrar = new MostrarRep();

                if (cmbMotivo.SelectedIndex != -1 && txtAuto.Text == "" && txtCanal.Text == "" && txtCte.Text == "")
                {
                    txtAuto.Enabled = false;
                    txtCanal.Enabled = false;
                    txtCte.Enabled = false;
                    Mostrar.m = cmbMotivo.Text;
                    Mostrar.ShowDialog();
                    limpiar();
                }


                if (txtAuto.Text != "" && cmbMotivo.SelectedIndex.Equals(-1) && txtCanal.Text == "" && txtCte.Text == "")
                {

                    cmbMotivo.Enabled = false;
                    txtCanal.Enabled = false;
                    txtCte.Enabled = false;
                    Mostrar.a = txtAuto.Text;
                    Mostrar.ShowDialog();
                    limpiar();
                }


                if (txtCanal.Text != "" && cmbMotivo.SelectedIndex.Equals(-1) && txtAuto.Text == "" && txtCte.Text == "")
                {

                    txtAuto.Enabled = false;
                    cmbMotivo.Enabled = false;
                    txtCte.Enabled = false;
                    Mostrar.c = txtCanal.Text;
                    Mostrar.ShowDialog();
                    limpiar();

                }

                if (txtCte.Text != "" && cmbMotivo.SelectedIndex.Equals(-1) && txtAuto.Text == "" && txtCanal.Text == "")
                {
                    txtAuto.Enabled = false;
                    cmbMotivo.Enabled = false;
                    txtCanal.Enabled = false;
                    Mostrar.cte = txtCte.Text;
                    Mostrar.ShowDialog();
                    limpiar();
                }
            }

   
            if (cmbMotivo.SelectedIndex != -1 && txtAuto.Text != "" || txtCanal.Text != "" || txtCte.Text != "")
            {
                MessageBox.Show("Solo Debes Introducir un Valor en cualquiera de los campos!!");
                limpiar();

            }

            if ( txtAuto.Text != "" && cmbMotivo.SelectedIndex != -1 || txtCanal.Text != "" || txtCte.Text != "")
            {
                MessageBox.Show("Solo Debes Introducir un Valor en cualquiera de los  campos!!");
                limpiar();
            }

            if (txtCanal.Text != ""  && cmbMotivo.SelectedIndex != -1 || txtAuto.Text != "" || txtCte.Text != "")
            {
                MessageBox.Show("Solo Debes Introducir un Valor en cualquiera de los campos!!");
                limpiar();

            }

            if (txtCte.Text != "" && cmbMotivo.SelectedIndex != -1 || txtAuto.Text != "" ||txtCanal.Text != "" )
            {
                MessageBox.Show("Solo Debes Introducir un Valor en cualquiera de los campos!!");
                limpiar();

            }
        }

        public void limpiar ()
        {
            cmbMotivo.SelectedIndex = -1;
            txtAuto.Clear();
            txtCanal.Clear();
            txtCte.Clear();

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
