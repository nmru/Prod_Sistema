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
    public partial class frmProd_Etapa : Form
    {
        public frmProd_Etapa()
        {
            InitializeComponent();
        }

        public prodEtapa pEtapaAct { get; set; }
        public bool v { get; set; }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar();
            btnGuardar.Enabled = true;
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int v1 = 0;
            prodEtapa pEtapa = new prodEtapa();

            for ( int c = 0; c<1; c++)
            {
                switch (c)
                {
                    case 0:
                        Regexp(@"^[0-9]{12}$", txtSerie, pbN, lblN, "Num. Serie");
                        if (v == true)
                            v1 = 1;
                        break;
                }
            }

            if (v1 == 0)
            {
                MessageBox.Show("No se Pudo Registrar el Producto, Verifica La Informacion!!" + Environment.NewLine + Environment.NewLine +
                                "Ejemplos de Informacion Correcta:" + Environment.NewLine + Environment.NewLine +
                                "Numero de Serie: 201604180400, Campo de 12 Caracteres" + Environment.NewLine);
                btnGuardar.Enabled = true;
                //Response.Write("No se Puedo Registrar al Usuario!!");
                // Response.Write("<script>alert('No se Puedo Guardar el Lote!! ')</script>");
            }

            if (v1 == 1)
            {
                pEtapa.Serie = txtSerie.Text.Trim();
                pEtapa.Etapa = cmbEtapa.Text.Trim();
                pEtapa.Fecha = dtpFecha.Value.Year + "/" + dtpFecha.Value.Month + "/" + dtpFecha.Value.Day;
                pEtapa.Issue = cmbIssue.Text.Trim();
                pEtapa.Status = cmbStatus.Text.Trim();

                if (prodEtapaDAL.validar(txtSerie.Text, cmbEtapa.Text) == false && prodEtapaDAL.validars(txtSerie.Text) == false)
                {
                    int resultado = prodEtapaDAL.Agregar(pEtapa);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Etapa Guardada con Exito!!");
                        reg();
                        Limpiar();
                        Deshabilitar();
                        btnGuardar.Enabled = false;
                        //Response.Write("<script>alert('Lote Guardado con Exito ')</script>");
                        //this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('Usuario Guardado con Exit');", true);
                    }
                }

                
            }

            if (prodEtapaDAL.validar(txtSerie.Text, cmbEtapa.Text) == true)
            {
                MessageBox.Show("Esta Etapa ya esta Registrada para este Dispositivo, Por Favor Verifica la Etapa o el Numero de Serie!!");
                txtSerie.Clear();
                cmbEtapa.SelectedIndex = -1;
            }

            if (prodEtapaDAL.validars(txtSerie.Text) == true)
            {
                MessageBox.Show("Dispositivo No Existe, Verifica la Informacion del Dispositivo!!");
                txtSerie.Clear();
                cmbEtapa.SelectedIndex = -1;
            }

            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarE Buscar = new frmBuscarE();
            Buscar.ShowDialog();

            Habilitar();

            if (Buscar.pEtapaSel != null)
            {
                pEtapaAct = Buscar.pEtapaSel;
                txtSerie.Text = Buscar.pEtapaSel.Serie;
                cmbEtapa.Text = Buscar.pEtapaSel.Etapa;
                dtpFecha.Text = Buscar.pEtapaSel.Fecha;
                cmbIssue.Text = Buscar.pEtapaSel.Issue;
                cmbStatus.Text = Buscar.pEtapaSel.Status;

                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
            }

            txtSerie.Enabled = false;


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int v1 = 0;
            prodEtapa pPEtapa = new prodEtapa();

            for (int c = 0; c < 1; c++)
            {
                switch (c)
                {
                    case 0:
                        Regexp(@"^[0-9]{12}$", txtSerie, pbN, lblN, "Num. Serie");
                        if (v == true)
                            v1 = 1;
                        break;
                }
            }

            if (v1 == 1)
            {
                pPEtapa.Serie = txtSerie.Text;
                pPEtapa.Etapa = cmbEtapa.Text;
                pPEtapa.Fecha = dtpFecha.Value.Year + "/" + dtpFecha.Value.Month + "/" + dtpFecha.Value.Day;
                pPEtapa.Issue = cmbIssue.Text;
                pPEtapa.Status = cmbStatus.Text;
                pPEtapa.Id = pEtapaAct.Id;

                int resultado = prodEtapaDAL.Actualizar(pPEtapa);
                if (resultado > 0)
                {
                    Regexp(@"^[0-9]{12}$", txtSerie, pbN, lblN, "Num. Serie");

                    MessageBox.Show("Evaluacion Actualizado con Exito!!");
                    reg();
                    Limpiar();
                    Deshabilitar();
                    btnActualizar.Enabled = false;

                    //Response.Write("<script>alert('Usuario Guardado con Exito ')</script>");
                    //this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('Usuario Guardado con Exit');", true);
                }
            }

            if( v1 == 0)
            {
                MessageBox.Show("No se Pudo Registrar el Producto, Verifica La Informacion!!" + Environment.NewLine + Environment.NewLine +
                                "Ejemplos de Informacion Correcta:" + Environment.NewLine + Environment.NewLine +
                                "Numero de Serie: 201604180400, Campo de 12 Caracteres" + Environment.NewLine);
                btnActualizar.Enabled = true;
            }
   
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar la Evaluacion Actual?", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (prodEtapaDAL.Eliminar(pEtapaAct.Id) > 0)
                {
                    MessageBox.Show("Evaluacion Actual Eliminada Correctamente!", "Evaluacion Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Deshabilitar();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la Evaluacion", "Evaluacion No Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            btnGuardar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                v = false;
            }

        }

        public void Habilitar()
        {
            txtSerie.Enabled = true;
            cmbEtapa.Enabled = true;
            dtpFecha.Enabled = true;
            cmbIssue.Enabled = true;
            cmbStatus.Enabled = true;

        }

        public void Deshabilitar()
        {
            txtSerie.Enabled = false;
            cmbEtapa.Enabled = false;
            dtpFecha.Enabled = false;
            cmbIssue.Enabled = false;
            cmbStatus.Enabled = false;

        }

        public void Limpiar()
        {
            txtSerie.Clear();
            cmbEtapa.SelectedIndex = -1;
            dtpFecha.ResetText();
            cmbIssue.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
        }

        public void reg ()
        {
            pbN.Dispose();
            lblN.Dispose();
        }

        private void frmProd_Etapa_Load(object sender, EventArgs e)
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
