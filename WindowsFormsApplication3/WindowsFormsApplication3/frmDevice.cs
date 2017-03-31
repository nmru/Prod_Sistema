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
    public partial class frmDevice : Form
    {
        public frmDevice()
        {
            InitializeComponent();
        }

        public Producto prodAct { get; set; }
        public bool v { get; set; }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            Habilitar();
            Limpiar();
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int v1 = 0, v2 = 0, v3 = 0;
            Producto pProducto = new Producto();

            for (int c = 0; c <= 2; c++)
            {
                switch (c)
                {
                    case 0:
                        Regexp(@"^[0-9]{12}$", txtSerie, pbNumSerie, lblSerie, "Num. Serie");
                        if (v == true)
                            v1 = 1;
                        break;
                    case 1:
                        Regexp(@"^(#?([0-9A-Fa-f]){2}[:]){5}(([0-9A-Fa-f]{2})?)$", txtMAC, pbMAC, lblM, "MAC Address");
                        if (v == true)
                            v2 = 1;
                        break;
                    case 2:
                        Regexp(@"^[0-9]{1,4}$", txtLote, pbLote, lblL, "Num. Lote");
                        if (v == true)
                            v3 = 1;
                        break;
                }
            }

            if (v1 == 0 || v2 == 0 || v3 == 0)
            {
                MessageBox.Show("No se Pudo Registrar el Producto, Verifica La Informacion!!" + Environment.NewLine + Environment.NewLine +
                                "Ejemplos de Informacion Correcta:" + Environment.NewLine + Environment.NewLine +
                                "Numero de Serie: 201604180400, Campo de 12 Caracteres" + Environment.NewLine +
                                "MAC Address: 78:A3:51:12:98:BA, Campo de 17 Carcateres" + Environment.NewLine +
                                "Numero Lote: 45, Minimo 1 Caracter, Maximo 4" + Environment.NewLine);
                btnGuardar.Enabled = true;
            }

            if (v1 == 1 && v2 == 1 && v3 == 1)
            {
                pProducto.Serial = txtSerie.Text.Trim();
                pProducto.MAC = txtMAC.Text.Trim();
                pProducto.lote = txtLote.Text.Trim();
                pProducto.Disp = cmbDisp.Text.Trim();

                if (ProductoDAL.validars(txtSerie.Text) == false && ProductoDAL.validarm(txtMAC.Text) == false && ProductoDAL.validarc(txtLote.Text)<=20)
                {
                    int resultado = ProductoDAL.Agregar(pProducto);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Producto Guardado con Exito!!");
                        reg();
                        Limpiar();
                        Deshabilitar();
                        btnGuardar.Enabled = false;
                        //Response.Write("<script>alert('Producto Guardado con Exito!! ')</script>");
                        //this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('Usuario Guardado con Exito');", true);
                    }
                }

            }

            if(ProductoDAL.validars(txtSerie.Text) == true)
            {
                MessageBox.Show("Campo Num. Serie ya Existe, Por favor Ingresa otro Num. Serie!!");
                txtSerie.Clear();
                txtSerie.Focus();
            }

            if (ProductoDAL.validarm(txtMAC.Text) == true)
            {
                MessageBox.Show("Campo MAC Address ya Existe, Por favor Ingresa otra MAC Address!!");
                txtMAC.Clear();
                txtMAC.Focus();
            }

           if( ProductoDAL.validarc(txtLote.Text) > 20)
            {
                MessageBox.Show("El Lote Actual ha Excedido su Capacidad de Almacenimiento, Cada Lote tiene Capacidad de Almacenamiento para 20 Dispositivos!!");
                txtLote.Clear();
                txtLote.Focus();
            }

            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarDevice Buscar = new frmBuscarDevice();
            Buscar.ShowDialog();

            Habilitar();

            if (Buscar.ProdSeleccionado != null)
            {
                prodAct = Buscar.ProdSeleccionado;
                txtSerie.Text = Buscar.ProdSeleccionado.Serial.ToString();
                txtMAC.Text = Buscar.ProdSeleccionado.MAC;
                txtLote.Text = Buscar.ProdSeleccionado.lote.ToString();
                cmbDisp.Text = Buscar.ProdSeleccionado.Disp.ToString();
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
            }

            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int v1 = 0, v2 = 0, v3 = 0;
            Producto pProducto = new Producto();

            for (int c = 0; c <= 2; c++)
            {
                switch (c)
                {
                    case 0:
                        Regexp(@"^[0-9]{12}$", txtSerie, pbNumSerie, lblSerie, "Num. Serie");
                        if (v == true)
                        v1 = 1;
                        break;
                    case 1:
                        Regexp(@"^(#?([0-9A-Fa-f]){2}[:]){5}(([0-9A-Fa-f]{2})?)$", txtMAC, pbMAC, lblM, "MAC Address");
                        if (v == true)
                            v2 = 1;
                        break;
                    case 2:
                        Regexp(@"^[0-9]{1,4}$", txtLote, pbLote, lblL, "Num. Lote");
                        if (v == true)
                            v3 = 1;
                        break;
                }
            }


            if (v1 == 1 && v2 == 1 && v3 == 1)
            {
                pProducto.Serial = txtSerie.Text.Trim();
                pProducto.MAC = txtMAC.Text.Trim();
                pProducto.lote = txtLote.Text.Trim();
                pProducto.Disp = cmbDisp.Text.Trim();
                pProducto.Id_Prod = prodAct.Id_Prod;

                int resultado = ProductoDAL.Actualizar(pProducto);
                if (resultado > 0)
                {
                    MessageBox.Show("Device Actualizado con Exito!!");
                    reg();
                    Limpiar();
                    Deshabilitar();
                    btnActualizar.Enabled = false;
                    //Response.Write("<script>alert('Usuario Guardado con Exito ')</script>");
                    //this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('Usuario Guardado con Exit');", true);
                }
            }

            if (v1 == 0 || v2 == 0 || v3 == 0)
            {
                MessageBox.Show("No se Pudo Registrar el Producto, Verifica La Informacion!!" + Environment.NewLine + Environment.NewLine +
                                "Ejemplos de Informacion Correcta:" + Environment.NewLine + Environment.NewLine +
                                "Numero de Serie: 201604180400, Campo de 12 Caracteres" + Environment.NewLine +
                                "MAC Address: 78:A3:51:12:98:BA, Campo de 17 Carcateres" + Environment.NewLine +
                                "Numero Lote: 45, Minimo 1 Caracter, Maximo 4" + Environment.NewLine);
                btnActualizar.Enabled = false;
            }

            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar al Device Actual?", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ProductoDAL.Eliminar(prodAct.Id_Prod) > 0)
                {
                    MessageBox.Show("Device Eliminado Correctamente!", "Device Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Deshabilitar();
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnGuardar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Device", "Device No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSerie_TextChanged(object sender, EventArgs e)
        {
          
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
            txtLote.Clear();
            cmbDisp.SelectedIndex = -1;
        }

        public void reg()
        {
            pbLote.Dispose();
            pbMAC.Dispose();
            pbNumSerie.Dispose();
            lblL.Dispose();
            lblM.Dispose();
            lblSerie.Dispose();

        }

        public void Habilitar ()
        {
            txtSerie.Enabled = true;
            txtMAC.Enabled = true;
            txtLote.Enabled = true;
            cmbDisp.Enabled = true;
        }

        public void Deshabilitar()
        {
            txtSerie.Enabled = false;
            txtMAC.Enabled = false;
            txtLote.Enabled = false;
            cmbDisp.Enabled = false;
        }

        private void frmDevice_Load(object sender, EventArgs e)
        {
            if (Global.tUsuario != "Administrador")
            {
                btnNuevo.Visible = false;
                btnGuardar.Visible = false;
                btnActualizar.Visible = false;
                btnEliminar.Visible = false;
                Deshabilitar();
            }
        }
     }
   }
