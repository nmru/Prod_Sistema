using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication3
{
   public  class prodEtapaDAL
    {
        public static int Agregar(prodEtapa pPEtapa)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into prod_etapa(Num_Serie, Etapa, F_Etapa, Issue_E, S_Etapa) values ('{0}','{1}','{2}','{3}','{4}')",
            pPEtapa.Serie, pPEtapa.Etapa, pPEtapa.Fecha, pPEtapa.Issue, pPEtapa.Status), BDComun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<prodEtapa> Buscar(string pSerie, string pEtapa)
        {
            List<prodEtapa> _lista = new List<prodEtapa>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT Id_PEtapa, Num_Serie, Etapa, F_Etapa, Issue_E, S_Etapa FROM prod_etapa where Num_Serie ='{0}' or Etapa='{1}'", pSerie, pEtapa), BDComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                prodEtapa pPEtapa = new prodEtapa();
                pPEtapa.Id = _reader.GetInt32(0);
                pPEtapa.Serie = _reader.GetString(1);
                pPEtapa.Etapa = _reader.GetString(2);
                pPEtapa.Fecha = _reader.GetString(3);
                pPEtapa.Issue = _reader.GetString(4);
                pPEtapa.Status = _reader.GetString(5);

                _lista.Add(pPEtapa);
            }

            return _lista;

        }

        public static prodEtapa ObtenerPEtapa(int id)
        {
            prodEtapa pPEtapa = new prodEtapa();
            MySqlConnection conexion = BDComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Id_PEtapa, Num_Serie, Etapa, F_Etapa, Issue_E, S_Etapa FROM prod_etapa where Id_PEtapa = {0}", id), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                pPEtapa.Id = _reader.GetInt32(0);
                pPEtapa.Serie = _reader.GetString(1);
                pPEtapa.Etapa = _reader.GetString(2);
                pPEtapa.Fecha = _reader.GetString(3);
                pPEtapa.Issue = _reader.GetString(4);
                pPEtapa.Status = _reader.GetString(5);
            }

            conexion.Close();
            return pPEtapa;

        }

        public static int Actualizar(prodEtapa pPEtapa)
        {
            int retorno = 0;
            MySqlConnection conexion = BDComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update prod_etapa set  Num_Serie='{0}', Etapa='{1}', F_Etapa='{2}', Issue_E='{3}', S_Etapa='{4}'  where Id_PEtapa={5}",
            pPEtapa.Serie, pPEtapa.Etapa, pPEtapa.Fecha, pPEtapa.Issue, pPEtapa.Status, pPEtapa.Id), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;
        }

        public static int Eliminar(int pId)
        {
            int retorno = 0;
            MySqlConnection conexion = BDComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From prod_etapa where Id_PEtapa={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

        public static List<prodEtapa> BuscarAs(string pSerie, string pEtapa)
        {
            List<prodEtapa> _lista = new List<prodEtapa>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT Id_PEtapa, Num_Serie, Etapa, F_Etapa, Issue_E, S_Etapa FROM prod_etapa order by Etapa", pSerie, pEtapa), BDComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                prodEtapa pPEtapa = new prodEtapa();
                pPEtapa.Id = _reader.GetInt32(0);
                pPEtapa.Serie = _reader.GetString(1);
                pPEtapa.Etapa = _reader.GetString(2);
                pPEtapa.Fecha = _reader.GetString(3);
                pPEtapa.Issue = _reader.GetString(4);
                pPEtapa.Status = _reader.GetString(5);

                _lista.Add(pPEtapa);
            }

            return _lista;
           }

        public static bool validar(string s, string e)
        {
            bool r = false;

            MySqlConnection conexion = BDComun.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM prod_etapa where Num_Serie = '{0}' and Etapa = '{1}'", s,e), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                r = true;
            }

            conexion.Close();
            return r;

        }

        public static bool validars(string s)
        {
            bool r = false;

            MySqlConnection conexion = BDComun.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM producto where Num_Serie = '{0}'", s), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                r = true;
            }

            conexion.Close();
            return r;

        }

    }
    }
