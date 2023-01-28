using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using MySql.Data.MySqlClient;

namespace Logica
{
    public class LogicaPlantas 
    {
        public DataTable tablaFormada()
        {
            string laconsulta = "SELECT * FROM `plantas`";
            Conexion miConexion = new Conexion();
            return miConexion.consultaGeneral(laconsulta);

        }

        public string agregarPlantas(string nombre, int tem_max,int tem_min, int hum_max, int hum_min)
        {

            string mensaje = validarEntradas(nombre, tem_max,  tem_min,  hum_max,  hum_min);
            if (!mensaje.Equals(""))
            {
                return mensaje;
            }
          
            Planta planta= new Planta();
            planta.nombre = nombre;
            planta.temperatura_maxima_adecuada = tem_max;
            planta.temperatura_minima_adecuada= tem_min;
            planta.humedad_maxima_adecuada= hum_max;
            planta.humedad_minima_adecuada=hum_min;


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
            comando.Parameters.AddWithValue("@nombre", planta.nombre);
            comando.Parameters.AddWithValue("@tem_max", planta.temperatura_maxima_adecuada);
            comando.Parameters.AddWithValue("@tem_min", planta.temperatura_minima_adecuada);
            comando.Parameters.AddWithValue("@hum_max", planta.humedad_maxima_adecuada);
            comando.Parameters.AddWithValue("@hum_min", planta.humedad_minima_adecuada);
            miconexion.ejecutarSentencia(comando, conectado);
            return "Planta agregada correctamente";
        }

        public string validarEntradas(string nombre, int tem_max, int tem_min, int hum_max, int hum_min)
        {
            string mensaje = "";
            if(nombre.Equals("") || tem_max == 0 || tem_min==0 || hum_max ==0 || hum_min==0)
            {
                mensaje = mensaje + "Todos los campos son obligatorios \n";
            }
            else
            {
                if (tem_max < tem_min)
                {
                    mensaje = mensaje + "La temperatura maxima no puede ser menor a la temperatura minima \n";
                }
                if (hum_max < hum_min)
                {
                    mensaje = mensaje + "La humedad maxima no puede ser menor a la humedad minima \n";
                }
            }
            return mensaje;
        }

        public string editarPlantas(int id,string nombre, int tem_max, int tem_min, int hum_max, int hum_min)
        {
            string mensaje = validarEntradas(nombre, tem_max, tem_min, hum_max, hum_min);
            if (!mensaje.Equals(""))
            {
                return mensaje;
            }

            Planta planta = new Planta();
            planta.id = id;
            planta.nombre = nombre;
            planta.temperatura_maxima_adecuada = tem_max;
            planta.temperatura_minima_adecuada = tem_min;
            planta.humedad_maxima_adecuada = hum_max;
            planta.humedad_minima_adecuada = hum_min;



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
            comando.Parameters.AddWithValue("@nombre", planta.nombre);
            comando.Parameters.AddWithValue("@tem_max", planta.temperatura_maxima_adecuada);
            comando.Parameters.AddWithValue("@tem_min", planta.temperatura_minima_adecuada);
            comando.Parameters.AddWithValue("@hum_max", planta.humedad_maxima_adecuada);
            comando.Parameters.AddWithValue("@hum_min", planta.humedad_minima_adecuada);
            comando.Parameters.AddWithValue("@id", planta.id);
            miconexion.ejecutarSentencia(comando, conectado);
            return "Planta modificada exitosamente";
        }

        public string eliminarPlantas(int id)
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
