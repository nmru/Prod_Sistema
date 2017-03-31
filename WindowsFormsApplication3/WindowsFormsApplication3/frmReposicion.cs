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
    public partial class frmReposicion : Form
    {
        public frmReposicion()
        {
            InitializeComponent();
        }

        public Reposicion RepAct { get; set; }
        public bool v { get; set; }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar();
            btnGuardar.Enabled = true;
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int v1 = 0, v2 = 0, v3 = 0, v4 = 0, v5 = 0, v6 = 0, v7 = 0, v8 = 0, v9 = 0, v10 = 0, v11 =0;
            Reposicion pReposicion = new Reposicion();
            for (int c = 0; c <= 10; c++)
            {
                switch (c)
                {
                    case 0:
                        Regexp(@"^[0-9]{12}$", txtSerieS, pbss, lblss, "Num. Serie Salida");
                        if (v == true)
                            v1 = 1;
                        break;
                    case 1:
                        Regexp(@"^(#?([0-9A-Fa-f]){2}[:]){5}(([0-9A-Fa-f]{2})?)$", txtMACs, pbms, lblms, "MAC Address Salida");
                        if (v == true)
                            v2 = 1;
                        break;
                    case 2:
                        Regexp(@"^[0-9]{1,4}$", txtLoteS, pbls, lblls, "Num. Lote Salida");
                        v3 = 1;
                        break;
                    case 3:
                        Regexp(@"^[0-9]{12}$", txtSerieE, pbse, lblse, "Num. Serie Entrada");
                        if (v == true)
                            v4 = 1;
                        break;
                    case 4:
                        Regexp(@"^(#?([0-9A-Fa-f]){2}[:]){5}(([0-9A-Fa-f]{2})?)$", txtMACe, pbme, lblme, "MAC Address Entrada");
                        if (v == true)
                            v5 = 1;
                        break;
                    case 5:
                        Regexp(@"^[0-9]{1,4}$", txtLoteE, pble, lblle, "Num. Lote Entrada");
                        if (v == true)
                            v6 = 1;
                        break;
                    case 6:
                        Regexp(@"^[A-Za-z\s]{3,50}$", txtCanal, pbc, lblc, "Canal");
                        if (v == true)
                            v7 = 1;
                        break;
                    case 7:
                        Regexp(@"^[A-Za-z\s.]{3,50}$", txtCliente, pbcte, lblcte, "Cliente");
                        if (v == true)
                            v8 = 1;
                        break;
                    case 8:
                        Regexp(@"^[A-Za-z\s]{3,20}$", txtCiudad, pbcd, lblcd, "Ciudad Origen");
                        if (v == true)
                            v9 = 1;
                        break;
                    case 9:
                        Regexp(@"^[A-Za-z\s\W]{3,20}$", txtPresta, pbPR, lblPR, "Prestamo a");
                        if (v == true || txtPresta.Text == "")
                            v10 = 1;
                        break;
                    case 10:
                        Regexp(@"^[A-Za-z\s]{3,50}$", txtAuto, pba, lbla, "Autorizo");
                        if (v == true)
                            v11 = 1;
                        break;
                }
            }

            if (v1 == 0 || v2 == 0 || v3 == 0 || v4 == 0 || v5 == 0 || v6 == 0 || v7 == 0 || v8 == 0 || v9 == 0 || v10 == 0 || v11 == 0)
            {
                MessageBox.Show("No se Pudo Registrar el Producto, Verifica La Informacion!!" + Environment.NewLine + Environment.NewLine +
                                "Ejemplos de Informacion Correcta:" + Environment.NewLine + Environment.NewLine +
                                "Numero de Serie: 201604180400, Campo de 12 Caracteres" + Environment.NewLine +
                                "MAC Address: 78:A3:51:12:98:BA, Campo de 17 Carcateres" + Environment.NewLine +
                                "Numero Lote: 45, Minimo 1 Caracter, Maximo 4" + Environment.NewLine +
                                "Canal: Maria Martinez, Minimo 4 Carcateres, Maximo 50" + Environment.NewLine +
                                "Cliente: Pinturas S.A de C.V, Minimo 4 Caracteres, Maximo 50 " + Environment.NewLine +
                                "Ciudad: Tijuana, Minimo 4 Caracteres, Maximo 20" + Environment.NewLine +
                                "Autorizo: Sergio Chavez, Minimo 4 Caracteres, Maximo 50");

                btnGuardar.Enabled = true;
            }

            if (v1 == 1 && v2 == 1 && v3 == 1 && v4 == 1 && v5 == 1 && v6 == 1 && v7 == 1 && v8 == 1 && v9 == 1 && v10 == 1 && v11 == 1)
            {
                pReposicion.ss = txtSerieS.Text.Trim();
                pReposicion.ms = txtMACs.Text.Trim();
                pReposicion.ls = Int32.Parse(txtLoteS.Text.Trim());
                pReposicion.se = txtSerieE.Text.Trim();
                pReposicion.me = txtMACe.Text.Trim();
                pReposicion.le = Int32.Parse(txtLoteE.Text.Trim());
                pReposicion.canal = txtCanal.Text.Trim();
                pReposicion.cte = txtCliente.Text.Trim();
                pReposicion.cd = txtCiudad.Text.Trim();
                pReposicion.fs = dtpFecha.Value.Year + "/" + dtpFecha.Value.Month + "/" + dtpFecha.Value.Day;
                pReposicion.motivo = cmbMotivo.Text.Trim();
                pReposicion.presta = txtPresta.Text.Trim();
                pReposicion.Auto = txtAuto.Text.Trim();

                

                if (txtSerieS.Text != txtSerieE.Text && txtMACs.Text != txtMACe.Text && ReposicionDAL.validare(txtSerieS.Text) == true)
                {
                    int resultado = ReposicionDAL.Agregar(pReposicion);

                    ReposicionDAL.upDis(txtSerieS.Text);

                    if (ReposicionDAL.validares(txtSerieE.Text) == true)
                    {
                        ReposicionDAL.upDisSE(txtSerieE.Text);
                    }

                    if (ReposicionDAL.validares(txtSerieE.Text) == false)
                    {
                        ReposicionDAL.Agregares(txtSerieE.Text, txtMACe.Text);
                    }

                        if (resultado > 0)
                    {
                        MessageBox.Show("Reposicion Guardada con Exito!!");
                        btnGuardar.Enabled = false;
                        Limpiar();
                        reg();
                        Deshabilitar();
                   }
                  
                }

                else
                {

                    if (txtSerieS.Text == txtSerieE.Text)
                    {
                        MessageBox.Show("Las Numero de Serie de Ambos Dispositivos No pueden Ser Iguales, Verifica la Informacion!!");
                        txtSerieE.Clear();
                        txtSerieE.Focus();
                    }

                    if (txtMACs.Text == txtMACe.Text)
                    {
                        MessageBox.Show("Las MAC Address de Ambos Dispositivos No pueden Ser Iguales, Verifica la Informacion!!");
                        txtMACe.Clear();
                        txtMACe.Focus();

                    }

                    if (ReposicionDAL.validare(txtSerieS.Text) == false)
                    {
                        MessageBox.Show("Este Dispositivo No existe o No se Encuentra Disponible, Verifica la Informacion!!");
                        txtSerieS.Clear();
                        txtSerieS.Focus();
                    }


                }
                              
            }

         

            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarReposicion Buscar = new frmBuscarReposicion();
            Buscar.ShowDialog();

            Habilitar();

            if (Buscar.RepSelec != null)
            {
                RepAct= Buscar.RepSelec;
                txtSerieS.Text = Buscar.RepSelec.ss;
                txtSerieE.Text = Buscar.RepSelec.se;
                txtMACs.Text = Buscar.RepSelec.ms;
                txtMACe.Text = Buscar.RepSelec.me;
                txtLoteS.Text = Buscar.RepSelec.ls.ToString();
                txtLoteE.Text = Buscar.RepSelec.le.ToString();
                txtCanal.Text = Buscar.RepSelec.canal;
                txtCliente.Text = Buscar.RepSelec.cte;
                txtCiudad.Text = Buscar.RepSelec.cd;
                dtpFecha.Text = Buscar.RepSelec.fs;
                cmbMotivo.Text = Buscar.RepSelec.motivo;
                txtPresta.Text = Buscar.RepSelec.presta;
                txtAuto.Text = Buscar.RepSelec.Auto;

                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;

                if(txtPresta.Text == "")
                {
                    txtPresta.Enabled = false;
                }

            }

            txtSerieE.Enabled = false;
            txtSerieS.Enabled = false;
            txtMACe.Enabled = false;
            txtMACs.Enabled = false;
          
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int v1 = 0, v2 = 0, v3 = 0, v4 = 0, v5 = 0, v6 = 0, v7 = 0, v8 = 0, v9 = 0, v10 = 0, v11 = 0;
            Reposicion pReposicion = new Reposicion();
            for (int c = 0; c <= 10; c++)
            {
                switch (c)
                {
                    case 0:
                        Regexp(@"^[0-9]{12}$", txtSerieS, pbss, lblss, "Num. Serie Salida");
                        if (v == true)
                            v1 = 1;
                        break;
                    case 1:
                        Regexp(@"^(#?([0-9A-Fa-f]){2}[:]){5}(([0-9A-Fa-f]{2})?)$", txtMACs, pbms, lblms, "MAC Address Salida");
                        if (v == true)
                            v2 = 1;
                        break;
                    case 2:
                        Regexp(@"^[0-9]{1,4}$", txtLoteS, pbls, lblls, "Num. Lote Salida");
                        v3 = 1;
                        break;
                    case 3:
                        Regexp(@"^[0-9]{12}$", txtSerieE, pbse, lblse, "Num. Serie Entrada");
                        if (v == true)
                            v4 = 1;
                        break;
                    case 4:
                        Regexp(@"^(#?([0-9A-Fa-f]){2}[:]){5}(([0-9A-Fa-f]{2})?)$", txtMACe, pbme, lblme, "MAC Address Entrada");
                        if (v == true)
                            v5 = 1;
                        break;
                    case 5:
                        Regexp(@"^[0-9]{1,4}$", txtLoteE, pble, lblle, "Num. Lote Entrada");
                        if (v == true)
                            v6 = 1;
                        break;
                    case 6:
                        Regexp(@"^[A-Za-z\s]{3,50}$", txtCanal, pbc, lblc, "Canal");
                        if (v == true)
                            v7 = 1;
                        break;
                    case 7:
                        Regexp(@"^[A-Za-z\s.]{3,50}$", txtCliente, pbcte, lblcte, "Cliente");
                        if (v == true)
                            v8 = 1;
                        break;
                    case 8:
                        Regexp(@"^[A-Za-z\s]{3,20}$", txtCiudad, pbcd, lblcd, "Ciudad Origen");
                        if (v == true)
                            v9 = 1;
                        break;
                    case 9:
                        Regexp(@"^[A-Za-z\s\W]{3,20}$", txtPresta, pbPR, lblPR, "Prestamo A");
                        if (v == true || txtPresta.Text =="")
                            v10 = 1;
                        break;
                    case 10:
                        Regexp(@"^[A-Za-z\s]{3,50}$", txtAuto, pba, lbla, "Autorizo");
                        if (v == true)
                            v11 = 1;
                        break;
                }
            }

            if (v1 == 0 || v2 == 0 || v3 == 0 || v4 == 0 || v5 == 0 || v6 == 0 || v7 == 0 || v8 == 0 || v9 == 0 || v10 == 0 || v11 == 0)
            {
                MessageBox.Show("No se Pudo Registrar el Producto, Verifica La Informacion!!" + Environment.NewLine + Environment.NewLine +
                                "Ejemplos de Informacion Correcta:" + Environment.NewLine + Environment.NewLine +
                                "Numero de Serie: 201604180400, Campo de 12 Caracteres" + Environment.NewLine +
                                "MAC Address: 78:A3:51:12:98:BA, Campo de 17 Carcateres" + Environment.NewLine +
                                "Numero Lote: 45, Minimo 1 Caracter, Maximo 4" + Environment.NewLine +
                                "Canal: Maria Martinez, Minimo 4 Carcateres, Maximo 50" + Environment.NewLine +
                                "Cliente: Pinturas S.A de C.V, Minimo 4 Caracteres, Maximo 50 " + Environment.NewLine +
                                "Ciudad: Tijuana, Minimo 4 Caracteres, Maximo 20" + Environment.NewLine +
                                "Autorizo: Sergio Chavez, Minimo 4 Caracteres, Maximo 50");
                btnActualizar.Enabled = true;
                //Response.Write("No se Puedo Registrar al Usuario!!");
                //Response.Write("<script>alert('No Se pudo Registrar al Usuario!! ')</script>");
            }

            if (v1 == 1 && v2 == 1 && v3 == 1 && v4 == 1 && v5 == 1 && v6 == 1 && v7 == 1 && v8 == 1 && v9 == 1 && v10 == 1 && v11 == 1)
            {

                pReposicion.ss = txtSerieS.Text.Trim();
                pReposicion.ms = txtMACs.Text.Trim();
                pReposicion.ls = Int32.Parse(txtLoteS.Text.Trim());
                pReposicion.se = txtSerieE.Text.Trim();
                pReposicion.me = txtMACe.Text.Trim();
                pReposicion.le = Int32.Parse(txtLoteE.Text.Trim());
                pReposicion.canal = txtCanal.Text.Trim();
                pReposicion.cte = txtCliente.Text.Trim();
                pReposicion.cd = txtCiudad.Text.Trim();
                pReposicion.fs = dtpFecha.Value.Year + "/" + dtpFecha.Value.Month + "/" + dtpFecha.Value.Day;
                pReposicion.motivo = cmbMotivo.Text.Trim();
                pReposicion.presta = txtPresta.Text.Trim();
                pReposicion.Auto = txtAuto.Text.Trim();
                pReposicion.id = RepAct.id;

                if (txtSerieS.Text != txtSerieE.Text && txtMACs.Text!= txtMACe.Text)
                {
                    int resultado = ReposicionDAL.Actualizar(pReposicion);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Reposicion Actualizada con Exito!!");
                        Limpiar();
                        Deshabilitar();
                        btnActualizar.Enabled = false;
                        reg();
                        //Response.Write("<script>alert('Usuario Guardado con Exito ')</script>");
                        //this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('Usuario Guardado con Exit');", true);
                    }
                }

            }

           
          
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar La Reposicion Actual?", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ReposicionDAL.Eliminar(RepAct.id) > 0)
                {
                    MessageBox.Show("Reposicion Eliminada Correctamente!", "Reposicion Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Deshabilitar();
                    
                  }
                else
                {
                    MessageBox.Show("No se pudo eliminar la Reposicion", "Reposicion No Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Habilitar()
        {
            txtSerieS.Enabled = true;
            txtSerieE.Enabled = true;
            txtMACs.Enabled = true;
            txtMACe.Enabled = true;
            txtLoteE.Enabled = true;
            txtLoteS.Enabled = true;
            txtCanal.Enabled = true;
            txtCliente.Enabled = true;
            txtCiudad.Enabled = true;
            dtpFecha.Enabled = true;
            cmbMotivo.Enabled = true;
            txtAuto.Enabled = true;
            
        }

        public void Deshabilitar ()
        {
            txtSerieS.Enabled = false;
            txtSerieE.Enabled = false;
            txtMACs.Enabled = false;
            txtMACe.Enabled = false;
            txtLoteE.Enabled = false;
            txtLoteS.Enabled = false;
            txtCanal.Enabled = false;
            txtCliente.Enabled = false;
            txtCiudad.Enabled = false;
            dtpFecha.Enabled = false;
            cmbMotivo.Enabled = false;
            txtAuto.Enabled = false;
            txtPresta.Enabled = false;

        }

        public void Limpiar ()
        {
            txtSerieE.Clear();
            txtSerieS.Clear();
            txtMACe.Clear();
            txtMACs.Clear();
            txtLoteE.Clear();
            txtLoteS.Clear();
            txtCanal.Clear();
            txtCliente.Clear();
            txtCiudad.Clear();
            dtpFecha.ResetText();
            cmbMotivo.SelectedIndex = -1;
            txtAuto.Clear();
            txtPresta.Clear();
            

        }

        public void reg ()
        {
            pba.Dispose();
            pbc.Dispose();
            pbcd.Dispose();
            pbcte.Dispose();
            pble.Dispose();
            pbls.Dispose();
            pbme.Dispose();
            pbms.Dispose();
            pbPR.Dispose();
            pbse.Dispose();
            pbss.Dispose();
            lbla.Dispose();
            lblc.Dispose();
            lblcd.Dispose();
            lblcte.Dispose();
            lblle.Dispose();
            lblls.Dispose();
            lblme.Dispose();
            lblms.Dispose();
            lblse.Dispose();
            lblss.Dispose();
            lblPR.Dispose();
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

        private void frmReposicion_Load(object sender, EventArgs e)
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

        private void cmbMotivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMotivo.SelectedIndex == 4)
            {
                txtPresta.Enabled = true;
                pbPR.Enabled = true;
                lblPR.Enabled = true;
                lblPrestamo.Enabled= true;
            }
        }

        private void txtPresta_EnabledChanged(object sender, EventArgs e)
        {
            if (cmbMotivo.SelectedText == "Prestamo")
            {
                txtPresta.Enabled = true;
                pbPR.Enabled = true;
                lblPR.Enabled = true;
                lblPrestamo.Enabled = true;
            }
        }
    }
}
