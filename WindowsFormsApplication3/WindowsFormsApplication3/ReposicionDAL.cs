using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication3
{
   public class ReposicionDAL
    {
        public static int Agregar(Reposicion pReposicion)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into reposiciones (SerieS, MACs, LoteS, SerieE, MACe, LoteE, Canal, Cliente, CiudadO, F_Salida, Motivo, Prestamo, Autorizo) values ('{0}','{1}',{2},'{3}','{4}',{5},'{6}','{7}','{8}','{9}','{10}','{11}','{12}')",
            pReposicion.ss,pReposicion.ms,pReposicion.ls,pReposicion.se,pReposicion.me, pReposicion.le, pReposicion.canal,pReposicion.cte,pReposicion.cd,pReposicion.fs,pReposicion.motivo,pReposicion.presta, pReposicion.Auto), BDComun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<Reposicion> Buscar(string pAuto, string pMotivo)
        {
            List<Reposicion> _lista = new List<Reposicion>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT Id_Reposicion, SerieS, MACs, LoteS, SerieE, MACe, LoteE, Canal, Cliente, CiudadO, F_Salida, Motivo, Prestamo, Autorizo FROM reposiciones  where Autorizo='{0}' or Motivo ='{1}'", pAuto, pMotivo), BDComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Reposicion pReposicion = new Reposicion();
                pReposicion.id = _reader.GetInt32(0);
                pReposicion.ss = _reader.GetString(1);
                pReposicion.ms = _reader.GetString(2);
                pReposicion.ls= _reader.GetInt32(3);
                pReposicion.se = _reader.GetString(4);
                pReposicion.me = _reader.GetString(5);
                pReposicion.le = _reader.GetInt32(6);
                pReposicion.canal = _reader.GetString(7);
                pReposicion.cte = _reader.GetString(8);
                pReposicion.cd = _reader.GetString(9);
                pReposicion.fs = _reader.GetString(10);
                pReposicion.motivo = _reader.GetString(11);
                pReposicion.presta = _reader.GetString(12);
                pReposicion.Auto = _reader.GetString(13);

                _lista.Add(pReposicion);
            }

            return _lista;
        }

        public static Reposicion ObtenerReposicion(int Id)
        {
            Reposicion pReposicion = new Reposicion();
            MySqlConnection conexion = BDComun.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Id_Reposicion, SerieS, MACs, LoteS, SerieE, MACe, LoteE, Canal, Cliente, CiudadO, F_Salida, Motivo, Prestamo,  Autorizo FROM reposiciones where Id_Reposicion = {0}", Id), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                pReposicion.id = _reader.GetInt32(0);
                pReposicion.ss = _reader.GetString(1);
                pReposicion.ms = _reader.GetString(2);
                pReposicion.ls = _reader.GetInt32(3);
                pReposicion.se = _reader.GetString(4);
                pReposicion.me = _reader.GetString(5);
                pReposicion.le = _reader.GetInt32(6);
                pReposicion.canal = _reader.GetString(7);
                pReposicion.cte = _reader.GetString(8);
                pReposicion.cd = _reader.GetString(9);
                pReposicion.fs = _reader.GetString(10);
                pReposicion.motivo = _reader.GetString(11);
                pReposicion.presta = _reader.GetString(12);
                pReposicion.Auto = _reader.GetString(13);
            }

            conexion.Close();
            return pReposicion;

        }

        public static int Actualizar(Reposicion pReposicion)
        {
            int retorno = 0;
            MySqlConnection conexion = BDComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update reposiciones set SerieS='{0}', MACs='{1}', LoteS={2}, SerieE='{3}', MACe='{4}', LoteE={5}, Canal='{6}', Cliente='{7}',CiudadO='{8}',F_Salida='{9}', Motivo='{10}',Prestamo='{11}', Autorizo='{12}' where Id_Reposicion={13}",
            pReposicion.ss, pReposicion.ms, pReposicion.ls, pReposicion.se, pReposicion.me, pReposicion.le, pReposicion.canal, pReposicion.cte, pReposicion.cd, pReposicion.fs, pReposicion.motivo, pReposicion.presta, pReposicion.Auto, pReposicion.id), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;
        }

        public static int Eliminar(int pId)
        {
            int retorno = 0;
            MySqlConnection conexion = BDComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From reposiciones where Id_Reposicion={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

        public static List<Reposicion> BuscarAs(string pMotivo, string pAuto)
        {
            List<Reposicion> _lista = new List<Reposicion>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT Id_Reposicion, SerieS, MACs, LoteS, SerieE, MACe, LoteE, Canal, Cliente, CiudadO, F_Salida, Motivo, Prestamo, Autorizo FROM reposiciones ", pMotivo, pAuto), BDComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                Reposicion pReposicion = new Reposicion();
                pReposicion.id = _reader.GetInt32(0);
                pReposicion.ss = _reader.GetString(1);
                pReposicion.ms = _reader.GetString(2);
                pReposicion.ls = _reader.GetInt32(3);
                pReposicion.se = _reader.GetString(4);
                pReposicion.me = _reader.GetString(5);
                pReposicion.le = _reader.GetInt32(6);
                pReposicion.canal = _reader.GetString(7);
                pReposicion.cte = _reader.GetString(8);
                pReposicion.cd = _reader.GetString(9);
                pReposicion.fs = _reader.GetString(10);
                pReposicion.motivo = _reader.GetString(11);
                pReposicion.presta = _reader.GetString(12);
                pReposicion.Auto = _reader.GetString(13);

                _lista.Add(pReposicion);
            }

            return _lista;
        }

        public static Boolean validare(string ps)
        {

            bool r = false;


            MySqlConnection conexion = BDComun.ObtenerConexion();
          

           MySqlCommand _comando = new MySqlCommand(String.Format("select * from producto where Num_Serie ='{0}' and Disponibilidad ='Disponible'", ps), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                r = true;
                
            }

            _reader.Close();
            conexion.Close();
            return r;

        }

        public static Boolean upDis(string ps)
        {

            bool r = false;

            MySqlConnection conexion = BDComun.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(String.Format("Update producto set Disponibilidad ='No Disponible' where Num_Serie ='{0}'", ps), conexion);

            MySqlDataReader _reader = cmd.ExecuteReader();

            while (_reader.Read())
            {
                r = true;

            }

            _reader.Close();
            cmd.ExecuteNonQuery();
            conexion.Close();
            return r;

        }

        public static int Agregares(string se,string me)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into producto (Num_Serie, MAC_Address, Num_Lote, Disponibilidad) values ('{0}','{1}','0','En Servicio')",
            se, me), BDComun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static Boolean upDisSE(string ps)
        {

            bool r = false;

            MySqlConnection conexion = BDComun.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(String.Format("Update producto set Disponibilidad ='En Revision' where Num_Serie ='{0}'", ps), conexion);

            MySqlDataReader _reader = cmd.ExecuteReader();

            while (_reader.Read())
            {
                r = true;

            }

            _reader.Close();
            cmd.ExecuteNonQuery();
            conexion.Close();
            return r;

        }
        public static Boolean validares(string ps)
        {

            bool r = false;


            MySqlConnection conexion = BDComun.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("select * from producto where Num_Serie ='{0}' ", ps), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {
                r = true;

            }

            _reader.Close();
            conexion.Close();
            return r;

        }

    }
}
