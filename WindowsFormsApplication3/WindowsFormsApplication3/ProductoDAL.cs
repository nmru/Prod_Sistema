using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication3
{
    public class ProductoDAL
    {
        public static int Agregar(Producto pProducto)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into producto (Num_Serie, MAC_Address, Num_Lote, Disponibilidad) values ('{0}','{1}','{2}','{3}')",
            pProducto.Serial, pProducto.MAC, pProducto.lote, pProducto.Disp), BDComun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<Producto> Buscar(string pSerial, string pMAC)
        {
            List<Producto> _lista = new List<Producto>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT Id_Prod, Num_Serie, MAC_Address, Num_Lote, Disponibilidad FROM producto  where Num_Serie ='{0}' or MAC_Address='{1}'", pSerial, pMAC), BDComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Producto pProducto = new Producto();
                pProducto.Id_Prod = _reader.GetInt32(0);
                pProducto.Serial = _reader.GetString(1);
                pProducto.MAC = _reader.GetString(2);
                pProducto.lote = _reader.GetString(3);
                pProducto.Disp = _reader.GetString(4);

                _lista.Add(pProducto);
            }

            return _lista;

        }

        public static Producto ObtenerProducto(int id)
        {
            Producto pProducto = new Producto();
            MySqlConnection conexion = BDComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Id_Prod, Num_Serie, MAC_Address, Num_Lote, Disponibilidad FROM producto where Id_Prod = {0}", id), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                pProducto.Id_Prod = _reader.GetInt32(0);
                pProducto.Serial = _reader.GetString(1);
                pProducto.MAC = _reader.GetString(2);
                pProducto.lote = _reader.GetString(3);
                pProducto.Disp = _reader.GetString(4);
            }

            conexion.Close();
            return pProducto;

        }

        public static int Actualizar(Producto pProducto)
        {
            int retorno = 0;
            MySqlConnection conexion = BDComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update producto set  Num_Serie='{0}', MAC_Address='{1}', Num_Lote={2}, Disponibilidad='{3}' where Id_Prod={4}",
            pProducto.Serial, pProducto.MAC, pProducto.lote, pProducto.Disp,pProducto.Id_Prod), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;
        }

        public static int Eliminar(int pId)
        {
            int retorno = 0;
            MySqlConnection conexion = BDComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From producto where Id_Prod={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

        public static List<Producto> BuscarAs(string pSerial, string pMAC)
        {
            List<Producto> _lista = new List<Producto>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT Id_Prod, Num_Serie, MAC_Address, Num_Lote, Disponibilidad FROM producto ", pSerial, pMAC), BDComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Producto pProducto = new Producto();
                pProducto.Id_Prod = _reader.GetInt32(0);
                pProducto.Serial = _reader.GetString(1);
                pProducto.MAC = _reader.GetString(2);
                pProducto.lote = _reader.GetString(3);
                pProducto.Disp = _reader.GetString(4);

                _lista.Add(pProducto);
            }

            return _lista;

        }

        public static Boolean validars(string pn)
        {

            bool r = false;
            

            MySqlConnection conexion = BDComun.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM producto where Num_Serie = '{0}'", pn), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                r = true;
            }

            _reader.Close();
            conexion.Close();
            return r;
            
        }

        public static Boolean validarm(string pm)
        {

            bool r = false;
            
            MySqlConnection conexion = BDComun.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM producto where MAC_Address = '{0}'", pm), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                r = true;
            }

            _reader.Close();
            conexion.Close();
            return r;

        }

        public static int validarc (string l)
        {

            int c = 0;
            MySqlConnection conexion = BDComun.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM producto where Num_Lote= '{0}'", l), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                c++;
            }

            _reader.Close();
            conexion.Close();
            return c;



        }

    }
}
