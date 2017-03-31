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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        public Usuario usActual { get; set; }
        public bool v { get; set; }

        private void frmUsuario_Load(object sender, EventArgs e)
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


        public void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar();
            Limpiar();
            btnGuardar.Enabled = true;
        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            
            int v1 = 0, v2 = 0, v3 = 0, v4 = 0, v5 = 0, v6 = 0;
            Usuario pUsuario = new Usuario();
           
                for (int c = 0; c <= 5; c++)
                {
                    switch (c)
                    {
                        case 0:
                            Regexp(@"^[A-Za-z\s]{3,50}$", txtNom, pbN, lblN, "Nombre");
                            if (v == true)
                                v1 = 1;
                            break;
                        case 1:
                            Regexp(@"^[A-Za-z\s]{3,50}$", txtAp, pbA, lblA, "Apellido");
                            if (v == true)
                                v2 = 1;
                            break;
                        case 2:
                            Regexp(@"^[A-Za-z]{4,15}$", txtUsuario, pbU, lblU, "Usuario");
                            v3 = 1;
                            break;
                        case 3:
                            Regexp(@"^[0-9A-Za-z]{6,20}$", txtPass, pbC, lblc, "Contraseña");
                            if (v == true)
                                v4 = 1;
                            break;
                        case 4:
                            Regexp(@"^[A-Za-z]{4,20}$", txtArea, pbAr, lblAr, "Area");
                            if (v == true)
                                v5 = 1;
                            break;
                        case 5:
                            Regexp(@"^[A-Za-z\s.]{4,30}$", txtPuesto, pbP, lblP, "Puesto");
                            if (v == true)
                                v6 = 1;
                            break;
                    }
                }

            if (v1 == 0 || v2 == 0 || v3 == 0 || v4 == 0 || v5 == 0 || v6 == 0)
            {
                MessageBox.Show("No se Puedo Registrar al Usuario, Verifica La Informacion!!" + Environment.NewLine + Environment.NewLine +
                                "Ejemplos de Informacion Correcta:" + Environment.NewLine + Environment.NewLine +
                                "Nombre: Margarita, Minimo 3 Caracteres, Maximo 50 " + Environment.NewLine +
                                "Apellido: Ramos, Maximo 50 Caracteres" + Environment.NewLine +
                                "Usuario: mramos, Minimo 4 Caracteres, Maximo 15" + Environment.NewLine +
                                "Contraseña: 12345ab, Minimo 6 Caracteres, Maximo 20" + Environment.NewLine +
                                "Area: Logistica, Minimo 4 Caracteres, Maximo 20 " + Environment.NewLine +
                                "Puesto: Ingeniero en Sistemas o Ing. Sistemas, Minimo 4 Carcateres, Maximo 30 ");
                btnGuardar.Enabled = true;
            }

            if (v1 == 1 && v2 == 1 && v3 == 1 && v4 == 1 && v5 == 1 && v6 == 1)
                {
                    pUsuario.Nom = txtNom.Text.Trim();
                    pUsuario.Ap = txtAp.Text.Trim();
                    pUsuario.User = txtUsuario.Text.Trim();
                    pUsuario.Contraseña = txtPass.Text.Trim();
                    pUsuario.Area = txtArea.Text.Trim();
                    pUsuario.Puesto = txtPuesto.Text.Trim();
                    pUsuario.Rol = cmbRol.Text.Trim();

                if (UsuarioDAL.verificar(txtNom.Text, txtAp.Text, txtUsuario.Text) == false && UsuarioDAL.verificaru(txtUsuario.Text) == false)
                {
                    int resultado = UsuarioDAL.Agregar(pUsuario);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Usuario Guardado con Exito!!");
                        btnGuardar.Enabled = false;
                        Limpiar();
                        Deshabilitar();
                        reg();
                        //Response.Write("<script>alert('Usuario Guardado con Exito ')</script>");
                        //this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('Usuario Guardado con Exit');", true);
                    }

                }

           

                if (UsuarioDAL.verificar(txtNom.Text, txtAp.Text, txtUsuario.Text) == true)
                {
                    MessageBox.Show("Usuario ya Existe, Por favor ingresa otro Usuario!!");
                    Limpiar();
                }

                if (UsuarioDAL.verificaru(txtUsuario.Text) == true)
                {
                    MessageBox.Show("Nom Usuario ya fue Asignado, Por Favor Ingresa otro Nom. Usuario!!");
                    txtUsuario.Clear();
                    txtUsuario.Focus();
                }


            }
           

            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            frmBuscarUsuario Buscar = new frmBuscarUsuario();
            Buscar.ShowDialog();
            

            Habilitar();        

            if (Buscar.UsuarioSeleccionado != null)
            {
                usActual = Buscar.UsuarioSeleccionado;
                txtNom.Text = Buscar.UsuarioSeleccionado.Nom;
                txtAp.Text = Buscar.UsuarioSeleccionado.Ap;
                txtUsuario.Text = Buscar.UsuarioSeleccionado.User;
                txtPass.Text = Buscar.UsuarioSeleccionado.Contraseña;
                txtArea.Text = Buscar.UsuarioSeleccionado.Area;
                txtPuesto.Text = Buscar.UsuarioSeleccionado.Puesto;
                cmbRol.Text = Buscar.UsuarioSeleccionado.Rol;
         
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
            }

            txtUsuario.Enabled = false;
        }

        public void btnActualizar_Click(object sender, EventArgs e)
        {
            
            int v1 = 0, v2 = 0, v3 = 0, v4 = 0, v5 = 0, v6 = 0;
            Usuario pUsuario = new Usuario();

            for (int c = 0; c <= 5; c++)
            {
                switch (c)
                {
                    case 0:
                        Regexp(@"^[A-Za-z\s]{3,50}$", txtNom, pbN, lblN, "Nombre");
                        if (v == true)
                            v1 = 1;
                        break;
                    case 1:
                        Regexp(@"^[A-Za-z\s]{3,50}$", txtAp, pbA, lblA, "Apellido");
                        if (v == true)
                            v2 = 1;
                        break;
                    case 2:
                        Regexp(@"^[A-Za-z]{4,15}$", txtUsuario, pbU, lblU, "Usuario");
                        v3 = 1;
                        break;
                    case 3:
                        Regexp(@"^[0-9A-Za-z]{6,20}$", txtPass, pbC, lblc, "Contraseña");
                        if (v == true)
                            v4 = 1;
                        break;
                    case 4:
                        Regexp(@"^[A-Za-z]{4,20}$", txtArea, pbAr, lblAr, "Area");
                        if (v == true)
                            v5 = 1;
                        break;
                    case 5:
                        Regexp(@"^[A-Za-z\s.]{4,30}$", txtPuesto, pbP, lblP, "Puesto");
                        if (v == true)
                            v6 = 1;
                        break;
                }
            }

             if (v1 == 1 && v2 == 1 && v3 == 1 && v4 == 1 && v5 == 1 && v6 == 1)
                {
                    pUsuario.Nom = txtNom.Text.Trim();
                    pUsuario.Ap = txtAp.Text.Trim();
                    pUsuario.User = txtUsuario.Text.Trim();
                    pUsuario.Contraseña = txtPass.Text.Trim();
                    pUsuario.Area = txtArea.Text.Trim();
                    pUsuario.Puesto = txtPuesto.Text.Trim();
                    pUsuario.Rol = cmbRol.Text.Trim();
                    pUsuario.Id = usActual.Id;

                    int resultado = UsuarioDAL.Actualizar(pUsuario);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Usuario Actualizado con Exito!!");
                        Limpiar();
                        reg();
                        Deshabilitar();
                        btnActualizar.Enabled = false;

                        //Response.Write("<script>alert('Usuario Guardado con Exito ')</script>");
                        //this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('Usuario Guardado con Exit');", true);
                    }
                }

            

            if (v1 == 0 || v2 == 0 || v3 == 0 || v4 == 0 || v5 == 0 || v6 == 0)
            {
                MessageBox.Show("No se Puedo Registrar al Usuario, Verifica La Informacion:" + Environment.NewLine + Environment.NewLine +
                                "Ejemplos de Informacion Correcta:" + Environment.NewLine + Environment.NewLine +
                                "Nombre: Margarita, Minimo 3 Caracteres, Maximo 50 " + Environment.NewLine +
                                "Apellido: Ramos, Maximo 50 Caracteres" + Environment.NewLine +
                                "Usuario: mramos, Minimo 4 Caracteres, Maximo 15" + Environment.NewLine +
                                "Contraseña: 12345ab, Minimo 6 Caracteres, Maximo 20" + Environment.NewLine +
                                "Area: Logistica, Minimo 4 Caracteres, Maximo 20 " + Environment.NewLine +
                                "Puesto: Ingeniero en Sistemas o Ing. Sistemas, Minimo 4 Carcateres, Maximo 30 ");
                btnActualizar.Enabled = true;
            }


            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        public void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar al Usuario Actual?", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (UsuarioDAL.Eliminar(usActual.Id) > 0)
                {
                    MessageBox.Show("Usuario Eliminado Correctamente!", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Deshabilitar();
                    btnGuardar.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Usuario", "Usuario No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

       private void txtNom_TextChanged(object sender, EventArgs e)
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

        public void Limpiar()
        {
            txtNom.Clear();
            txtAp.Clear();
            txtUsuario.Clear();
            txtPass.Clear();
            txtArea.Clear();
            txtPuesto.Clear();          
            cmbRol.SelectedIndex = -1;
         }

        public void Deshabilitar()
        {
            txtNom.Enabled = false;
            txtAp.Enabled = false;
            txtUsuario.Enabled = false;
            txtPass.Enabled = false;
            txtArea.Enabled = false;
            txtPuesto.Enabled = false;
            cmbRol.Enabled = false;
        }

        public void Habilitar()
        {
            txtNom.Enabled = true; 
            txtAp.Enabled = true; 
            txtUsuario.Enabled = true; 
            txtPass.Enabled = true; 
            txtArea.Enabled = true; 
            txtPuesto.Enabled = true;
            cmbRol.Enabled = true;
        }

        public void reg ()
        {
            lblA.Dispose();
            lblAr.Dispose();
            lblc.Dispose();
            lblN.Dispose();
            lblP.Dispose();
            lblU.Dispose();
            pbN.Dispose();
            pbA.Dispose();
            pbU.Dispose();
            pbC.Dispose();
            pbAr.Dispose();
            pbP.Dispose();

        }

    }
}
