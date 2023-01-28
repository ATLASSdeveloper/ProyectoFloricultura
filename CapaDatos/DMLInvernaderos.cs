using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DMLInvernaderos
    {
        public DataTable consultaTablaFormada()
        {
            string laconsulta = "SELECT * FROM `invernaderos`";
            Conexion miConexion = new Conexion();
            return miConexion.consultaGeneral(laconsulta);

        }

        public DataTable consultaFloresDisponibles()
        {
            string laconsulta = "SELECT id,nombre FROM `plantas`";
            Conexion miConexion = new Conexion();
            if (miConexion.consultaGeneral(laconsulta) == null)
            {
                return null;
            }
            return miConexion.consultaGeneral(laconsulta);

        }

        public string consultaAgregarInvernadero(string nombre, int capacidad, string flor)
        {

            string sentenciaDML = "INSERT INTO invernaderos  " +
                "VALUES (0,@nombre,@capacidad,@flor)";
            ;
            Conexion miconexion = new Conexion();
            MySqlConnection conectado = miconexion.establecerConexion();
            if (conectado == null)
            {
                return "No fue posible establecer conexion con la base de datos";
            }
            MySqlCommand comando = new MySqlCommand(sentenciaDML, conectado);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@capacidad", capacidad);
            if (flor .Equals(""))
            {
                comando.Parameters.AddWithValue("@flor", null);
            }
            else
            {
                comando.Parameters.AddWithValue("@flor", Convert.ToInt32(flor));
            }
            miconexion.ejecutarSentencia(comando, conectado);
            return "";
        }

        public string consultaEditaInvernadero(int id, string nombre, int capacidad, string flor)
        {
            string sentenciaDML = "UPDATE invernaderos  " +
                "SET nombre=@nombre,capacidad=@capacidad,id_flor=@flor " +
                "Where id=@id";
            ;
            Conexion miconexion = new Conexion();
            MySqlConnection conectado = miconexion.establecerConexion();
            if (conectado == null)
            {
                return "No fue posible establecer conexion con la base de datos";
            }
            MySqlCommand comando = new MySqlCommand(sentenciaDML, conectado);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@capacidad", capacidad);
            if (flor.Equals("") )
            {
                comando.Parameters.AddWithValue("@flor", null);
            }
            else
            {
                comando.Parameters.AddWithValue("@flor", Convert.ToInt32(flor));
            }
            comando.Parameters.AddWithValue("@id", id);
            miconexion.ejecutarSentencia(comando, conectado);
            return "";
        }

        public string consultaEliminarInvernadero(int id)
        {

            Conexion miconexion = new Conexion();
            MySqlConnection conectado = miconexion.establecerConexion();
            if (conectado == null)
            {
                return "No fue posible establecer conexion con la base de datos";
            }
            string sentenciaDML = "DELETE FROM registro Where invernadero=@invernadero";
            MySqlCommand comandoUno = new MySqlCommand(sentenciaDML, conectado);
            comandoUno.Parameters.AddWithValue("@invernadero", id);
            miconexion.ejecutarSentencia(comandoUno, conectado);

            sentenciaDML = "Delete from invernaderos where id=@id";
            MySqlCommand comando = new MySqlCommand(sentenciaDML, conectado);
            comando.Parameters.AddWithValue("@id", id);
            miconexion.ejecutarSentencia(comando, conectado);
            return "";
        }
    }
}
