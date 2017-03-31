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
    public partial class frmBuscarLote : Form
    {
        public frmBuscarLote()
        {
            InitializeComponent();
        }

        public Lote LoteSeleccionado { get; set; }
        public bool v { get; set; }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtLote.Text == "" && ckbAll.Checked == false)
            {
                MessageBox.Show("Debes Introducir un Valor!!");
            }
            else
            {
                if (txtLote.Text != "" || ckbAll.Checked == true)
                {
                    if (txtLote.Text != "" && ckbAll.Checked == false)
                    {
                        ckbAll.Enabled = false;
                        Regexp(@"^[0-9]{1,4}$", txtLote, pbL, lblL, "Num. Lote");
                        if (v == true)
                        {
                            ckbAll.Enabled = false;
                            dgvBuscar.DataSource = LoteDAL.Buscar(txtLote.Text);
                        }
                        else
                        {
                            MessageBox.Show("No se Puede Realizar la Busqueda, Verifica la Informacion");
                        }
                    }
                }
            }

            if (ckbAll.Checked == true && txtLote.Text == "")
            {
                txtLote.Enabled = false;
                dgvBuscar.DataSource = LoteDAL.BuscarAs(txtLote.Text);

            }
            if (ckbAll.Checked == true && txtLote.Text != "")
            {
                MessageBox.Show("Debes Introducir Solo un Valor!!");
                Limpiar();
            }


        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvBuscar.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvBuscar.CurrentRow.Cells[0].Value);
                LoteSeleccionado = LoteDAL.ObtenerLote(id);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debes Seleccionar un Registro!!");
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
                lbl.Text = s + " Invalido";

            }
        }

        public void Limpiar()
        {
            txtLote.Clear();
            ckbAll.Checked = false;
        }
    }
}
