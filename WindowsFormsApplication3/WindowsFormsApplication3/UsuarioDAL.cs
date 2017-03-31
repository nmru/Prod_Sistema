using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication3
{
   public class UsuarioDAL
    {
        public static int Agregar(Usuario pUsuario)
        {
          
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into usuario (Nombre, Apellido, User, Password, Area, Puesto, Rol) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
            pUsuario.Nom, pUsuario.Ap, pUsuario.User, pUsuario.Contraseña, pUsuario.Area, pUsuario.Puesto, pUsuario.Rol), BDComun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<Usuario> Buscar(string pNom, string pAp)
        {
            List<Usuario> _lista = new List<Usuario>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT Id, Nombre, Apellido, User, Password, Area, Puesto, Rol FROM usuario  where Nombre ='{0}' or Apellido='{1}'", pNom, pAp), BDComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Usuario pUsuario = new Usuario();
                pUsuario.Id = _reader.GetInt32(0);
                pUsuario.Nom = _reader.GetString(1);
                pUsuario.Ap = _reader.GetString(2);
                pUsuario.User = _reader.GetString(3);
                pUsuario.Contraseña = _reader.GetString(4);
                pUsuario.Area = _reader.GetString(5);
                pUsuario.Puesto = _reader.GetString(6);
                pUsuario.Rol = _reader.GetString(7);

                _lista.Add(pUsuario);
            }

            return _lista;
        }

        public static Usuario ObtenerUsuario(int Id)
        {
            Usuario pUsuario = new Usuario();
            MySqlConnection conexion = BDComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Id, Nombre, Apellido, User, Password, Area, Puesto, Rol FROM usuario where Id = {0}", Id), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                pUsuario.Id = _reader.GetInt32(0);
                pUsuario.Nom = _reader.GetString(1);
                pUsuario.Ap = _reader.GetString(2);
                pUsuario.User = _reader.GetString(3);
                pUsuario.Contraseña = _reader.GetString(4);
                pUsuario.Area = _reader.GetString(5);
                pUsuario.Puesto = _reader.GetString(6);
                pUsuario.Rol = _reader.GetString(7);
            }

            conexion.Close();
            return pUsuario;

        }

        public static int Actualizar(Usuario pUsuario)
        {
            int retorno = 0;
            MySqlConnection conexion = BDComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update usuario set Nombre='{0}', Apellido='{1}', User='{2}', Password='{3}', Area='{4}', Puesto='{5}', Rol='{6}' where Id={7}",
            pUsuario.Nom, pUsuario.Ap, pUsuario.User, pUsuario.Contraseña, pUsuario.Area, pUsuario.Puesto, pUsuario.Rol, pUsuario.Id), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;
        }

        public static int Eliminar(int pId)
        {
            int retorno = 0;
            MySqlConnection conexion = BDComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From usuario where Id={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

        public static int Autenticaficar(string pU, string pC)
        {
            int resultado = -1;
            MySqlConnection conexion = BDComun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT User, Password, Rol FROM usuario where User='{0}' and Password='{1}'", pU,pC), conexion);

            MySqlDataReader _reader = comando.ExecuteReader();

            while (_reader.Read())
            {
                resultado = 50;
                Global.tUsuario = _reader.GetString(2);
            }

            conexion.Close();

            return resultado;
        }

        public static List<Usuario> BuscarAs(string p, string p1)
        {
            List<Usuario> _lista = new List<Usuario>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
            "SELECT Id, Nombre, Apellido, User, Password, Area, Puesto, Rol FROM usuario ",p,p1), BDComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();


            while (_reader.Read())
            {
                Usuario pUsuario = new Usuario();
                pUsuario.Id = _reader.GetInt32(0);
                pUsuario.Nom = _reader.GetString(1);
                pUsuario.Ap = _reader.GetString(2);
                pUsuario.User = _reader.GetString(3);
                pUsuario.Contraseña = _reader.GetString(4);
                pUsuario.Area = _reader.GetString(5);
                pUsuario.Puesto = _reader.GetString(6);
                pUsuario.Rol = _reader.GetString(7);

                _lista.Add(pUsuario);
            }

            return _lista;

        }

        public static Boolean verificar(string pN, string pA, string pU)
        {
            bool res = false;
          
                MySqlConnection conexion = BDComun.ObtenerConexion();
                MySqlCommand comando = new MySqlCommand(String.Format("SELECT * FROM usuario where Nombre = '{0}' and Apellido = '{1}' and User =  '{2}'", pN,pA,pU), conexion);
                MySqlDataReader _reader = comando.ExecuteReader();

                while (_reader.Read())
                {
                    res = true;
               
                }
            _reader.Close();
            conexion.Close();

            return res;
            
        }

        public static Boolean verificaru(string pU)
        {
            bool res = false;

            MySqlConnection conexion = BDComun.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(String.Format("SELECT * FROM usuario where  User =  '{0}'", pU), conexion);
            MySqlDataReader _reader = comando.ExecuteReader();

            while (_reader.Read())
            {
                res = true;

            }
            _reader.Close();
            conexion.Close();

            return res;

        }
    }
}
