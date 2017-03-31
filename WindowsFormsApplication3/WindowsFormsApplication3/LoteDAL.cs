using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication3
{
   public class LoteDAL
    {
        public static int Agregar(Lote pLote)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into lote (Num_Lote, Ubicacion, S_Lote) values ('{0}','{1}','{2}')",
            pLote.Num_Lote, pLote.Ubicacion, pLote.SLote), BDComun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<Lote> Buscar(string plote)
        {
            List<Lote> _lista = new List<Lote>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT  Id_Lote, Num_Lote, Ubicacion, S_Lote FROM lote  where Num_Lote ='{0}'", plote), BDComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Lote pLote = new Lote();
                pLote.id = _reader.GetInt32(0);
                pLote.Num_Lote = _reader.GetString(1);
                pLote.Ubicacion = _reader.GetString(2);
                pLote.SLote = _reader.GetString(3);

                _lista.Add(pLote);
            }

            return _lista;
        }

        public static Lote ObtenerLote(int id)
        {
            Lote pLote = new Lote();
            MySqlConnection conexion = BDComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Id_Lote, Num_Lote, Ubicacion, S_Lote FROM lote  where Id_Lote={0}", id), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pLote.id = _reader.GetInt32(0);
                pLote.Num_Lote = _reader.GetString(1);
                pLote.Ubicacion = _reader.GetString(2);
                pLote.SLote = _reader.GetString(3);

            }

            conexion.Close();
            return pLote;
        }

        public static int Actualizar(Lote pLote)
        {
            int retorno = 0;
            MySqlConnection conexion = BDComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update lote set  Num_Lote='{0}', Ubicacion='{1}', S_Lote='{2}' where Id_Lote={3}",
            pLote.Num_Lote, pLote.Ubicacion, pLote.SLote, pLote.id), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;
        }

        public static int Eliminar(int pId)
        {
            int retorno = 0;
            MySqlConnection conexion = BDComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From lote where Id_Lote={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

        public static List<Lote> BuscarAs(string plote)
        {
            List<Lote> _lista = new List<Lote>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT  Id_Lote, Num_Lote, Ubicacion, S_Lote FROM lote ", plote), BDComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Lote pLote = new Lote();
                pLote.id = _reader.GetInt32(0);
                pLote.Num_Lote = _reader.GetString(1);
                pLote.Ubicacion = _reader.GetString(2);
                pLote.SLote = _reader.GetString(3);

                _lista.Add(pLote);
            }

            return _lista;
        }

        public static int verificar (string pN)
        {
            int res= 0;

            MySqlConnection conexion = BDComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Id_Lote, Num_Lote, Ubicacion, S_Lote FROM lote  where Num_Lote='{0}'", pN), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                res = 1;

            }

            _reader.Close();
            conexion.Close();

            return res;

        }
    }
}
