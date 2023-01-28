using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DMLPlantas
    {
        public DataTable consultaTablaFormada()
        {
            string laconsulta = "SELECT * FROM `plantas`";
            Conexion miConexion = new Conexion();
            return miConexion.consultaGeneral(laconsulta);

        }

        public string consultaAgregarPlantas(string nombre, int tem_max, int tem_min, int hum_max, int hum_min)
        {


            Conexion miconexion = new Conexion();
            MySqlConnection conectado = miconexion.establecerConexion();
            if (conectado == null)
            {
                return "No fue posible establecer conexion con la base de datos";
            }
            string sentenciaDML = "INSERT INTO plantas  " +
                "VALUES (0,@nombre,@tem_max,@tem_min,@hum_max,@hum_min)";
            ;
            MySqlCommand comando = new MySqlCommand(sentenciaDML, conectado);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@tem_max", tem_max);
            comando.Parameters.AddWithValue("@tem_min", tem_min);
            comando.Parameters.AddWithValue("@hum_max", hum_max);
            comando.Parameters.AddWithValue("@hum_min", hum_min);
            miconexion.ejecutarSentencia(comando, conectado);
            return "Planta agregada correctamente";
        }

        public string consultaEditarPlantas(int id, string nombre, int tem_max, int tem_min, int hum_max, int hum_min)
        {

            Conexion miconexion = new Conexion();
            MySqlConnection conectado = miconexion.establecerConexion();
            if (conectado == null)
            {
                return "No fue posible establecer conexion con la base de datos";
            }

            string sentenciaDML = "UPDATE plantas set nombre=@nombre,temperatura_maxima=@tem_max,temperatura_minima=@tem_min," +
                "humedad_maxima=@hum_max,humedad_minima=@hum_min where id=@id";
            ;
            MySqlCommand comando = new MySqlCommand(sentenciaDML, conectado);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@tem_max", tem_max);
            comando.Parameters.AddWithValue("@tem_min", tem_min);
            comando.Parameters.AddWithValue("@hum_max", hum_max);
            comando.Parameters.AddWithValue("@hum_min", hum_min);
            comando.Parameters.AddWithValue("@id", id);
            miconexion.ejecutarSentencia(comando, conectado);
            return "Planta modificada exitosamente";
        }

        public string consultaEliminarPlantas(int id)
        {
            Conexion miconexion = new Conexion();
            MySqlConnection conectado = miconexion.establecerConexion();
            if (conectado == null)
            {
                return "No fue posible establecer conexion con la base de datos";
            }
            string sentenciaDML = "UPDATE invernaderos SET id_flor=null Where id_flor=@id";
            MySqlCommand comando = new MySqlCommand(sentenciaDML, conectado);
            comando.Parameters.AddWithValue("@id", id);
            miconexion.ejecutarSentencia(comando, conectado);

            sentenciaDML = "DELETE FROM plantas WHERE id=@id";
            MySqlCommand comandoDos = new MySqlCommand(sentenciaDML, conectado);
            comandoDos.Parameters.AddWithValue("@id", id);

            miconexion.ejecutarSentencia(comandoDos, conectado);
            return "";
        }
    }
}
