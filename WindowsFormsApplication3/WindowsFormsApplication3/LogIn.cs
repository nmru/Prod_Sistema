using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication3
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            
            
            if (UsuarioDAL.Autenticaficar(txtUser.Text,txtPass.Text ) > 0) //Si el usuario es correcto nos abrira la otra ventana.
            {
                this.Hide();
                Main Buscar = new Main();
                Buscar.Show();
            }
            else //Si no lo es mostrara este mensaje.
                MessageBox.Show("Error - Ingrese sus datos correctamente");
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (UsuarioDAL.Autenticaficar(txtUser.Text, txtPass.Text) > 0) //Si el usuario es correcto nos abrira la otra ventana.
                {
                    this.Hide();
                    Main Buscar = new Main();
                    Buscar.Show();
                }
                else //Si no lo es mostrara este mensaje.
                    MessageBox.Show("Error - Ingrese sus datos correctamente");
            }
        }
    }
}
