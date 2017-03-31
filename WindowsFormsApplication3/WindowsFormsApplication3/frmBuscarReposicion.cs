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
    public partial class frmBuscarReposicion : Form
    {
        public frmBuscarReposicion()
        {
            InitializeComponent();
        }

        public Reposicion RepSelec { get; set; }
        public bool v { get; set; }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
             if (txtAuto.Text != "" || cmbMotivo.SelectedIndex != -1 || ckbAll.Checked == true)
            {
                if (txtAuto.Text != "" && cmbMotivo.SelectedIndex == -1 && ckbAll.Checked == false)
                {
                    cmbMotivo.Enabled = false;
                    ckbAll.Enabled = false;
                    Regexp(@"^[A-Za-z]$", txtAuto, pba, lbla, "Campo Autorizo");
                    if (v == true)
                    {
                        dgvBuscar.DataSource = ReposicionDAL.Buscar(txtAuto.Text, cmbMotivo.Text);
                    }
                    else
                    {
                        MessageBox.Show("No se Puede Realizar la Busqueda, Verifica la Informacion");
                    }
                }

                if (cmbMotivo.SelectedIndex != -1 && txtAuto.Text == "" && ckbAll.Checked == false)
                {
                    txtAuto.Enabled = false;
                    ckbAll.Enabled = false;
                    dgvBuscar.DataSource = ReposicionDAL.Buscar(txtAuto.Text, cmbMotivo.Text);
                }

                if (ckbAll.Checked == true && txtAuto.Text == "" && cmbMotivo.Text == "")
                {
                    txtAuto.Enabled = false;
                    cmbMotivo.Enabled = false;
                    dgvBuscar.DataSource = ReposicionDAL.BuscarAs(txtAuto.Text, cmbMotivo.Text);
                }
            }

            if (txtAuto.Text == "" && cmbMotivo.SelectedIndex == -1 && ckbAll.Checked == false)
            {

                MessageBox.Show("Debes Introducir al menos un valor!!");
            }

            if (txtAuto.Text != "" && cmbMotivo.SelectedIndex != -1 )
            {
                MessageBox.Show("Debes Introducir solo un valor!!");
                limpiar();
            }

            if(txtAuto.Text != "" && ckbAll.Checked == true)
            {
                MessageBox.Show("Debes Introducir solo un valor!!");
                limpiar();
            }
            if (cmbMotivo.SelectedIndex!=-1 && ckbAll.Checked == true)
            {
                MessageBox.Show("Debes Introducir solo un valor!!");
                limpiar();
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvBuscar.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvBuscar.CurrentRow.Cells[0].Value);
                RepSelec = ReposicionDAL.ObtenerReposicion(id);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debes Selecionar un Registro!!");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
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

        public void limpiar()
        {
            txtAuto.Clear();
            cmbMotivo.ResetText();
            cmbMotivo.SelectedIndex =-1 ;
            pba.Dispose();
            lbla.ResetText();
            ckbAll.Checked = false;
        }
    }
}
