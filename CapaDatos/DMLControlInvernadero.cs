using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DMLControlInvernadero
    {

        public DataTable DMLinvernaderosDisponibles()
        {
            string laconsulta = "SELECT id,nombre FROM `invernaderos`";
            Conexion miConexion = new Conexion();
            return miConexion.consultaGeneral(laconsulta);
        }

        public DataTable DMLlasFlores(int id)
        {
            string laconsulta = "SELECT * FROM `plantas` where id=(" +
                "SELECT id_flor from invernaderos where id=" + id.ToString() + ")";
            Conexion miConexion = new Conexion();
            return miConexion.consultaGeneral(laconsulta);
        }

        public DataTable DMLregistros(int id)
        {
            string laconsulta = "SELECT id,temperatura,humedad,fecha FROM `registro` Where invernadero=" + id.ToString() + "";
            Conexion miConexion = new Conexion();
            return miConexion.consultaGeneral(laconsulta);
        }
    }
}
