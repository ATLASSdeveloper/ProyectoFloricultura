using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class estadistica
    {
        public DataTable tablaFormada()
        {
            string laconsulta = "SELECT FECHA, ROUND((SUM(TEMPERATURA))/COUNT(ID)) , ROUND((SUM(HUMEDAD))/COUNT(ID)) FROM REGISTRO GROUP BY DATE(FECHA)";
            Conexion miConexion = new Conexion();
            return miConexion.consultaGeneral(laconsulta);

        }
    }
}
