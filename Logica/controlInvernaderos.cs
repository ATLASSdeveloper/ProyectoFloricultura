using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Logica
{
    public class controlInvernaderos
    {

        public DataTable invernaderosDisponibles()
        {
            string laconsulta = "SELECT id,nombre FROM `invernaderos`";
            Conexion miConexion = new Conexion();
            return miConexion.consultaGeneral(laconsulta);
        }

        public DataTable lasFlores(int id)
        {
            string laconsulta = "SELECT * FROM `plantas` where id=(" +
                "SELECT id_flor from invernaderos where id="+id.ToString()+")";
            Conexion miConexion = new Conexion();
            return miConexion.consultaGeneral(laconsulta);
        }

        public DataTable registros(int id)
        {
            string laconsulta = "SELECT id,temperatura,humedad,fecha FROM `registro` Where invernadero="+id.ToString()+"";
            Conexion miConexion = new Conexion();
            return miConexion.consultaGeneral(laconsulta);
        }
    }
}
