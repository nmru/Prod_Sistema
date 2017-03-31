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
    public partial class frmLote : Form
    {
        public frmLote()
        {
            InitializeComponent();
        }

        public Lote LoteAct { get; set; }
        public bool v { get; set; }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar();
            btnGuardar.Enabled = true;
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int v1 = 0, v2 = 0;
            Lote pLote = new Lote();

            for (int c = 0; c <= 1; c++)
            {
                switch (c)
                {
                    case 0:
                        Regexp(@"^[0-9]{1,4}$", txtNumLote, pbL, lblL, "Num. Lote");
                        if (v == true)
                            v1 = 1;
                        break;
                    case 1:
                        Regexp(@"^[A-Za-z]{4,20}$", txtUbicacion, pbU, lblU, "Ubicacion");
                        if (v == true)
                            v2 = 1;
                        break;
                }
            }

            if (v1 == 0 || v2 == 0)
            {
                MessageBox.Show("No se Pudo Registrar el Lote, Verifica la Informacion!!" + Environment.NewLine + Environment.NewLine +
                                "Ejemplos de Informacion Correcta:" + Environment.NewLine + Environment.NewLine +
                                "Numero Lote: 45, Minimo 1 Caracter, Maximo 4" + Environment.NewLine +
                                "Ubicacion: Almacen, Minimo 4, Maximo 20");
                btnGuardar.Enabled = true;
            }

            if (v1 == 1 && v2 == 1)
            {
                pLote.Num_Lote = txtNumLote.Text.Trim();
                pLote.Ubicacion = txtUbicacion.Text.Trim();
                pLote.SLote = cmbSLote.Text.Trim();

                if (LoteDAL.verificar(txtNumLote.Text) == 0)
                {
                    int resultado = LoteDAL.Agregar(pLote);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Lote Guardado con Exito!!");
                        reg();
                        btnGuardar.Enabled = false;
                        Limpiar();
                        Deshabilitar();
                        //Response.Write("<script>alert('Lote Guardado con Exito ')</script>");
                        //this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('Usuario Guardado con Exit');", true);
                    }

                }

                
            }
            
            if (LoteDAL.verificar(txtNumLote.Text) == 1)
            {
                MessageBox.Show("Campo Num.Lote ya Existe, Por favor Ingresa otro Num. Lote!!");
                txtNumLote.Focus();
                txtNumLote.Clear();
            }
           
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarLote Buscar = new frmBuscarLote();
            Buscar.ShowDialog();

            Habilitar();

            if (Buscar.LoteSeleccionado != null)
            {
                LoteAct = Buscar.LoteSeleccionado;
                txtNumLote.Text = Buscar.LoteSeleccionado.Num_Lote;
                txtUbicacion.Text = Buscar.LoteSeleccionado.Ubicacion;
                cmbSLote.Text = Buscar.LoteSeleccionado.SLote;
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
            }

            txtNumLote.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int v1 = 0, v2 = 0;
            Lote pLote = new Lote();

            for (int c = 0; c <= 1; c++)
            {
                switch (c)
                {
                    case 0:
                        Regexp(@"^[0-9]{1,4}$", txtNumLote, pbL, lblL, "Num. Lote");
                        if (v == true)
                            v1 = 1;
                        break;
                    case 1:
                        Regexp(@"^[A-Za-z]{1,20}$", txtUbicacion, pbU, lblU, "Ubicacion");
                        if (v == true)
                            v2 = 1;
                        break;
                }
            }

            if (v1 == 0 || v2 == 0)
            {
                btnActualizar.Enabled = true;
                MessageBox.Show("No se Pudo Registrar el Lote, Verifica la Informacion!!" + Environment.NewLine + Environment.NewLine +
                                 "Ejemplos de Informacion Correcta:" + Environment.NewLine + Environment.NewLine +
                                 "Numero Lote: 45, Minimo 1 Caracter, Maximo 4" + Environment.NewLine +
                                 "Ubicacion: Almacen, Minimo 4, Maximo 20");
            }

            if (v1 == 1 && v2 == 1)
            {
                pLote.Num_Lote = txtNumLote.Text.Trim();
                pLote.Ubicacion = txtUbicacion.Text.Trim();
                pLote.SLote = cmbSLote.Text.Trim();
                pLote.id = LoteAct.id;

                int resultado = LoteDAL.Actualizar(pLote);
                if (resultado > 0)
                {
                   MessageBox.Show("Lote Actualizado con Exito!!");
                    reg();
                    Limpiar();
                    Deshabilitar();
                    btnActualizar.Enabled = false;
                    //Response.Write("<script>alert('Usuario Guardado con Exito ')</script>");
                    //this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('Usuario Guardado con Exit');", true);
                }
                
            }

                       
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar el Lote Actual?", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (LoteDAL.Eliminar(LoteAct.id) > 0)
                {
                    MessageBox.Show("Lote Eliminado Correctamente!", "Lote Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Deshabilitar();
                    Limpiar();
                    btnGuardar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Lote", "Lote No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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
            txtNumLote.Clear();
            txtUbicacion.Clear();
            cmbSLote.SelectedIndex =-1;
            
        }

        public void Habilitar()
        {
            txtNumLote.Enabled = true;
            txtUbicacion.Enabled = true;
            cmbSLote.Enabled = true;
         }

        public void Deshabilitar()
        {
            txtNumLote.Enabled = false;
            txtUbicacion.Enabled = false;
            cmbSLote.Enabled = false;
        }

        public void reg()
        {
            pbL.Dispose();
            pbU.Dispose();
            lblL.Dispose();
            lblU.Dispose();
         }

        private void frmLote_Load(object sender, EventArgs e)
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
