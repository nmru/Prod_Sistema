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
    public partial class frmBuscarUsuario : Form
    {
        public frmBuscarUsuario()
        {
            InitializeComponent();
        }

        public Usuario UsuarioSeleccionado { get; set; }
        public bool v { get; set; }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            if (txtNom.Text != "" || txtAp.Text != "" || ckbAll.Checked == true)
            {
               
                if (txtNom.Text != "" && txtAp.Text == "" && ckbAll.Checked == false)
                {
                    txtAp.Enabled = false;
                    ckbAll.Enabled = false;

                    Regexp(@"^[A-Za-z*]{1,20}$", txtNom, pbN, lblN, "Nombre");

                    if (v == true)
                    {
                        dgvBuscar.DataSource = UsuarioDAL.Buscar(txtNom.Text, txtAp.Text);
                    }
                    else
                    {
                        MessageBox.Show("No se Puede Realizar la Busqueda, Verifica la Informacion");
                    }
                }

                if (txtAp.Text != "" && txtNom.Text == "" && ckbAll.Checked == false)
                {
                    txtNom.Enabled = false;
                    ckbAll.Enabled = false;
                    Regexp(@"^[A-Za-z*]{1,20}$", txtAp, pbA, lblA, "Apellido");
                    if (v == true)
                    {
                        dgvBuscar.DataSource = UsuarioDAL.Buscar(txtNom.Text, txtAp.Text);
                    }
                    else
                    {
                        MessageBox.Show("No se Puede Realizar la Busqueda, Verifica la Informacion");
                    }

                }

                if(ckbAll.Checked == true && txtNom.Text =="" && txtAp.Text=="")
                {
                    txtNom.Enabled = false;
                    txtAp.Enabled = false;
                    dgvBuscar.DataSource = UsuarioDAL.BuscarAs(txtNom.Text, txtAp.Text);
                }
            }


            if (txtNom.Text == "" && txtAp.Text == "" && ckbAll.Checked == false)
            {

                MessageBox.Show("Debes Introducir al menos un valor!!");
            }

            if (txtNom.Text != "" && txtAp.Text != "" )
            {
                Limpiar();
                MessageBox.Show("Debes Introducir solo un valor!!");
            }

            if(txtAp.Text !="" && ckbAll.Checked == true)
            {
                Limpiar();
                MessageBox.Show("Debes Introducir solo un valor!!");
            }

            if (txtNom.Text != "" && ckbAll.Checked == true)
            {
                Limpiar();
                MessageBox.Show("Debes Introducir solo un valor!!");
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvBuscar.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvBuscar.CurrentRow.Cells[0].Value);
                UsuarioSeleccionado = UsuarioDAL.ObtenerUsuario(id);
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
                v = false;
            }
        }

        public void Limpiar ()
        {
            txtNom.Clear();
            txtAp.Clear();
            pbA.Dispose();
            pbN.Dispose();
            ckbAll.Checked = false;
        }

        private void frmBuscarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'produccionDataSet2.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.produccionDataSet2.usuario);

        }
    }
}
