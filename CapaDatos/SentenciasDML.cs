using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class SentenciasDML
    {
        public DataTable consultaTablaReportes()
        {
            string laconsulta = "SELECT FECHA, ROUND((SUM(TEMPERATURA))/COUNT(ID)) , ROUND((SUM(HUMEDAD))/COUNT(ID)) FROM REGISTRO GROUP BY DATE(FECHA)";
            Conexion miConexion = new Conexion();
            return miConexion.consultaGeneral(laconsulta);
        }

        public DataTable consultaTablaReportesEspecifico(int id)
        {
            string laconsulta = "SELECT FECHA, ROUND((SUM(TEMPERATURA))/COUNT(ID)) , ROUND((SUM(HUMEDAD))/COUNT(ID)) FROM REGISTRO WHERE invernadero="+id.ToString()+" GROUP BY DATE(FECHA)";
            Conexion miConexion = new Conexion();
            return miConexion.consultaGeneral(laconsulta);
        }
    }
}
