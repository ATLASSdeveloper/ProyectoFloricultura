using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Reportes
{
    internal class LogicaEstadistica
    {
        public DataTable tabla()
        {
            estadistica miConexion = new estadistica();
            return miConexion.tablaFormada();

        }
    }

    internal class estadistica
    {
        public DataTable tablaFormada()
        {
            string laconsulta = "SELECT FECHA, ROUND((SUM(TEMPERATURA))/COUNT(ID)) , ROUND((SUM(HUMEDAD))/COUNT(ID)) FROM REGISTRO GROUP BY DATE(FECHA)";
            Conexion miConexion = new Conexion();
            return miConexion.consultaGeneral(laconsulta);

        }
    }

    internal class Conexion
    {
        static string servidor = "localhost";
        static string bd = "agil";
        static string usuario = "root";
        static string password = "";
        static string puerto = "3306";
        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
        string mensaje = "";

        public MySqlConnection establecerConexion()
        {
            MySqlConnection conex = new MySqlConnection(cadenaConexion);
            try
            {
                conex.Open();
                conex.Close();
            }
            catch (Exception ex)
            {
                conex.Close();
                conex = null;
            }

            return conex;
        }

        public string consultaEspecifica(string consulta)
        {
            string valor = "";
            try
            {
                MySqlConnection conectado = this.establecerConexion();
                MySqlCommand comando = new MySqlCommand(consulta, conectado);
                conectado.Open();
                valor = comando.ExecuteScalar().ToString();
                conectado.Close();
            }
            catch (Exception e)
            {
                valor = "";
            }
            return valor;
        }

        public DataTable consultaGeneral(string consulta)
        {
            DataTable estructuraTabla = new DataTable();
            try
            {
                MySqlConnection conectado = this.establecerConexion();
                MySqlCommand comando = new MySqlCommand(consulta, conectado);
                conectado.Open();
                MySqlDataAdapter datos = new MySqlDataAdapter(comando);

                datos.Fill(estructuraTabla);
                conectado.Close();
                return estructuraTabla;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public int ejecutarSentencia(MySqlCommand comando, MySqlConnection conectado)
        {
            try
            {
                conectado.Open();
                comando.ExecuteNonQuery();
                conectado.Close();
                return 0;
            }
            catch (Exception e)
            {
                return 1;
            }
        }
    }
}