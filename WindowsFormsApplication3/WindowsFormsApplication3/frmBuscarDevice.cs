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
    public partial class frmBuscarDevice : Form
    {
        public frmBuscarDevice()
        {
            InitializeComponent();
        }

        public Producto ProdSeleccionado { get; set; }
        public bool v { get; set; }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (txtSerie.Text != "" || txtMAC.Text != "" || ckbAll.Checked == true)
            {
                if (txtSerie.Text != "" && txtMAC.Text == "" && ckbAll.Checked == false)
                {
                    txtMAC.Enabled = false;
                    ckbAll.Enabled = false;
                    Regexp(@"^[0-9]{12}$", txtSerie, pbN, lblN, "Num. Serie");
                    if (v == true)
                    {
                        dgvBuscar.DataSource = ProductoDAL.Buscar(txtSerie.Text, txtMAC.Text);
                    }
                    else
                    {
                        MessageBox.Show("No se Puede Realizar la Busqueda, Verifica la Informacion");
                    }
                }
                if (txtMAC.Text != "" && txtSerie.Text == "" && ckbAll.Checked == false)
                {
                    txtSerie.Enabled = false;
                    ckbAll.Enabled = false;
                    Regexp(@"^[A-Za-z0-9:]{17}$", txtMAC, pbM, lblM, "MAC Address");
                    if (v == true)
                    {
                        dgvBuscar.DataSource = ProductoDAL.Buscar(txtSerie.Text, txtMAC.Text);
                    }
                    else
                    {
                        MessageBox.Show("No se Puede Realizar la Busqueda, Verifica la Informacion");
                    }

                 }
                if (ckbAll.Checked == true && txtSerie.Text == "" && txtMAC.Text == "")
                {
                    txtSerie.Enabled = false;
                    txtMAC.Enabled = false;
                    dgvBuscar.DataSource = ProductoDAL.BuscarAs(txtSerie.Text, txtMAC.Text);
                }
            }
            
                
                if (txtSerie.Text == "" && txtMAC.Text =="" && ckbAll.Checked == false )
                {
                    
                    MessageBox.Show("Debes Introducir al menos un valor!!");
                }

            if(txtSerie.Text != "" && txtMAC.Text != "")
            {
                MessageBox.Show("Debes Introducir solo un valor!!");
                Limpiar();
            }
            
            if(txtMAC.Text!="" && ckbAll.Checked == true)
            {
                MessageBox.Show("Debes Introducir solo un valor!!");
                Limpiar();
            }

            if (txtSerie.Text != "" && ckbAll.Checked == true)
            {
                MessageBox.Show("Debes Introducir solo un valor!!");
                Limpiar();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvBuscar.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvBuscar.CurrentRow.Cells[0].Value);
                ProdSeleccionado = ProductoDAL.ObtenerProducto(id);
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

        public void Limpiar ()
        {
            txtSerie.Clear();
            txtMAC.Clear();
            pbM.Dispose();
            pbN.Dispose();
            ckbAll.Checked = false;
        }
    }
}
