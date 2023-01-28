using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class Consultas
    {
        public string autentificacion(string correo, string clave)
        {
            string laconsulta = "SELECT COUNT(*) FROM `usuarios` WHERE `correo`='" + correo + "' AND `clave`='" + clave + "'";
            Conexion miConexion = new Conexion();
            string cantidad = miConexion.consultaEspecifica(laconsulta);
            if (cantidad == "")
            {
                return null;
            }
            else
            {
                return cantidad;
            }
        }

        public string identificarCargo(string correo, string clave)
        {
            string laconsulta = "SELECT `cargo` FROM `usuarios` WHERE `correo`='" + correo + "' AND `clave` ='" + clave + "'";
            Conexion miConexion = new Conexion();
            return miConexion.consultaEspecifica(laconsulta);
        }

       
    }
}
