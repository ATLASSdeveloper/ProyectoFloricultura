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
    public class LogicaInvernaderos
    {
        public DataTable tablaFormada()
        {
            string laconsulta = "SELECT * FROM `invernaderos`";
            Conexion miConexion = new Conexion();
            return miConexion.consultaGeneral(laconsulta);

        }

        public DataTable floresDisponibles()
        {
            string laconsulta = "SELECT id,nombre FROM `plantas`";
            Conexion miConexion = new Conexion();
            if (miConexion.consultaGeneral(laconsulta) == null)
            {
                return null;
            }
            return miConexion.consultaGeneral(laconsulta);

        }

        public string agregarInvernadero(string nombre,int capacidad,string flor)
        {
            Invernadero invernadero = new Invernadero();
            if (nombre.Equals(""))
            {
                return "el invernadero debe tener un nombre";
            }
            if (flor != null)
            {
                int la_flor=Convert.ToInt32(flor);
                Planta p = new Planta();
                p.id= la_flor;
                invernadero.flor = p;
            }
            
            invernadero.nombre = nombre;
            invernadero.capacidad = capacidad;
            

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
            comando.Parameters.AddWithValue("@nombre", invernadero.nombre);
            comando.Parameters.AddWithValue("@capacidad", invernadero.capacidad);
            if (invernadero.flor == null)
            {
                comando.Parameters.AddWithValue("@flor", null);
            }
            else
            {
                comando.Parameters.AddWithValue("@flor", invernadero.flor.id);
            }
            miconexion.ejecutarSentencia(comando, conectado);
            return "";
        }

        public string editaInvernadero(string id,string nombre, int capacidad, string flor)
        {
            Invernadero invernadero = new Invernadero();
            int mi_id = 0;
            if (id.Equals(""))
            {
                return "identifique un invernadero";
            }
            else
            {
                mi_id = Convert.ToInt32(id);
            }

            if (nombre.Equals(""))
            {
                return "El invernadero debe tener un nombre";
            }

            if (flor != null)
            {
                int la_flor = Convert.ToInt32(flor);
                Planta p = new Planta();
                p.id = la_flor;
                invernadero.flor = p;
            }
            invernadero.id= mi_id;
            invernadero.nombre = nombre;
            invernadero.capacidad = capacidad;

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
            comando.Parameters.AddWithValue("@nombre", invernadero.nombre);
            comando.Parameters.AddWithValue("@capacidad", invernadero.capacidad);
            if (invernadero.flor == null)
            {
                comando.Parameters.AddWithValue("@flor", null);
            }
            else
            {
                comando.Parameters.AddWithValue("@flor", invernadero.flor.id);
            }
            comando.Parameters.AddWithValue("@id", invernadero.id);
            miconexion.ejecutarSentencia(comando, conectado);
            return "";
        }

        public string eliminarInvernadero(string id)
        {
            int elID = 0;
            if (id.Equals(""))
            {
                return "Seleccione un invernadero para eliminar";
            }
            else
            {
                elID = Convert.ToInt32(id);
            }
            Conexion miconexion = new Conexion();
            MySqlConnection conectado = miconexion.establecerConexion();
            if (conectado == null)
            {
                return "No fue posible establecer conexion con la base de datos";
            }
            string sentenciaDML = "DELETE FROM registro Where invernadero=@invernadero";
            MySqlCommand comandoUno = new MySqlCommand(sentenciaDML, conectado);
            comandoUno.Parameters.AddWithValue("@invernadero", elID);
            miconexion.ejecutarSentencia(comandoUno, conectado);

            sentenciaDML = "Delete from invernaderos where id=@id";
            MySqlCommand comando = new MySqlCommand(sentenciaDML, conectado);
            comando.Parameters.AddWithValue("@id", elID);
            miconexion.ejecutarSentencia(comando, conectado);
            return "";
        }
    }
}
