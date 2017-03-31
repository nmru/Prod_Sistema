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
    public partial class frmBuscarE : Form
    {
        public frmBuscarE()
        {
            InitializeComponent();
        }

        public prodEtapa pEtapaSel { get; set; }
        public bool v { get; set; }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSerie.Text != "" || cmbEtapa.SelectedIndex !=-1 || ckbAll.Checked == true)
            {

                if (txtSerie.Text != "" && cmbEtapa.SelectedIndex == -1 && ckbAll.Checked == false)
                {
                    cmbEtapa.Enabled = false;
                    ckbAll.Enabled = false;
                    Regexp(@"^[0-9]{12}$", txtSerie, pbS, lblS, "Num. Serie");
                    if (v == true)
                    {
                        dgvBuscar.DataSource = prodEtapaDAL.Buscar(txtSerie.Text, cmbEtapa.Text);
                    }
                    else
                    {
                        MessageBox.Show("No se Puede Realizar la Busqueda, Verifica la Informacion");
                    }
                }

                if (cmbEtapa.SelectedIndex != -1 && txtSerie.Text == "" && ckbAll.Checked == false)
                {
                    txtSerie.Enabled = false;
                    ckbAll.Enabled = false;
                    dgvBuscar.DataSource = prodEtapaDAL.Buscar(txtSerie.Text, cmbEtapa.Text);
                }

                if (cmbEtapa.SelectedIndex == -1 && txtSerie.Text == "" && ckbAll.Checked == true)
                {
                    txtSerie.Enabled = false;
                    cmbEtapa.Enabled = false;
                    dgvBuscar.DataSource = prodEtapaDAL.BuscarAs(txtSerie.Text, cmbEtapa.Text);
                }


            }


            if (txtSerie.Text == "" && cmbEtapa.SelectedIndex.Equals(-1) && ckbAll.Checked == false)
            {

                MessageBox.Show("Debes Introducir al menos un valor!!");
            }

            if (txtSerie.Text != "" && cmbEtapa.SelectedIndex != -1)
            {
                MessageBox.Show("Debes Introducir solo un valor!!");
                limpiar();
            }

            if (ckbAll.Checked == true  && cmbEtapa.SelectedIndex != -1)
            {
                MessageBox.Show("Debes Introducir solo un valor!!");
                limpiar();
            }

            if (txtSerie.Text != "" && ckbAll.Checked == true)
            {
                MessageBox.Show("Debes Introducir solo un valor!!");
                limpiar();
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvBuscar.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvBuscar.CurrentRow.Cells[0].Value);
                pEtapaSel = prodEtapaDAL.ObtenerPEtapa(id);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un Registro!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Regexp(string re, TextBox tb, PictureBox pcb, Label lbl, string s)
        {

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
                v = false;
            }
        }

        public void limpiar ()
        {
            txtSerie.Clear();
            cmbEtapa.SelectedIndex = -1;
            pbS.Dispose();
            lblS.ResetText();
        }

    }
}
