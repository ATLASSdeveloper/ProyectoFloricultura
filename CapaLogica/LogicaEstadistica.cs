using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogicaEstadistica
    {
        public DataTable tabla()
        {
            SentenciasDML miConexion = new SentenciasDML();
            return miConexion.consultaTablaReportes();

        }

        public DataTable tablaEspecifica(string id)
        {
            SentenciasDML miConexion = new SentenciasDML();
            return miConexion.consultaTablaReportesEspecifico(Convert.ToInt32(id));

        }
    }
}
