using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DMLUsuarios
    {
        public DataTable consultaTablaFormada()
        {
            string laconsulta = "SELECT * FROM `usuarios`";
            Conexion miConexion = new Conexion();
            return miConexion.consultaGeneral(laconsulta);

        }

        public string consultaAgregarUsuarios(string cedula, string nombreUno,string nombreDos, string apellidoUno,string apellidoDos, string correo, string clave, string cargo)
        {

            string sentenciaDML = "INSERT INTO usuarios (cedula,nombre,nombre2,apellido,apellido2,correo,clave,cargo) " +
                "VALUES (@cedula,@nombre,@nombre2,@apellido,@apellido2,@correo,@clave,@cargo)";
            ;
            Conexion coneccion=new Conexion();
            MySqlConnection conectado = coneccion.establecerConexion();
            if (conectado == null)
            {
                return "No fue posible establecer conexion con la base de datos";
            }
            MySqlCommand comando = new MySqlCommand(sentenciaDML, conectado);
            comando.Parameters.AddWithValue("@cedula", cedula);
            comando.Parameters.AddWithValue("@nombre", nombreUno);
            comando.Parameters.AddWithValue("@nombre2", nombreDos);
            comando.Parameters.AddWithValue("@apellido", apellidoUno);
            comando.Parameters.AddWithValue("@apellido2", apellidoDos);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@clave", clave);
            comando.Parameters.AddWithValue("@cargo", cargo);
            coneccion.ejecutarSentencia(comando, conectado);
            return "";
        }

        public string consulta_eliminar_usuario(string cedula)
        {
            string sentenciaDML = "DELETE FROM usuarios WHERE cedula=@cedula";
            Conexion conexion=new Conexion();
            MySqlConnection conectado = conexion.establecerConexion();
            if (conectado == null)
            {
                return "No fue posible establecer conexion con la base de datos";
            }
            MySqlCommand comando = new MySqlCommand(sentenciaDML, conectado);
            comando.Parameters.AddWithValue("@cedula", cedula);
            conexion.ejecutarSentencia(comando, conectado);
            return "";
        }

        public string consultaEditarUsuarios(string cedula, string nombreUno,string nombreDos, string apellidoUno,string apellidoDos, string correo, string clave, string cargo)
        {

            string sentenciaDML = "UPDATE usuarios " +
                "                   SET nombre=@nombre," +
                "                       nombre2=@nombre2," +
                "                       apellido=@apellido," +
                "                       apellido2=@apellido2," +
                "                       correo=@correo," +
                "                       clave=@clave," +
                "                       cargo=@cargo" +
                "                       where cedula=@cedula";
            ;
            Conexion conectar=new Conexion();
            MySqlConnection conectado = conectar.establecerConexion();
            if (conectado == null)
            {
                return "No fue posible establecer conexion con la base de datos";
            }
            MySqlCommand comando = new MySqlCommand(sentenciaDML, conectado);
            comando.Parameters.AddWithValue("@cedula", cedula);
            comando.Parameters.AddWithValue("@nombre", nombreUno);
            comando.Parameters.AddWithValue("@nombre2", nombreDos);
            comando.Parameters.AddWithValue("@apellido", apellidoUno);
            comando.Parameters.AddWithValue("@apellido2", apellidoDos);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@clave", clave);
            comando.Parameters.AddWithValue("@cargo", cargo);
            conectar.ejecutarSentencia(comando, conectado);
            return "";
        }
    }
}
