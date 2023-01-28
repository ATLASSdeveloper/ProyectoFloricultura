using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LogicaEstadistica
    {
        public DataTable tabla()
        {
            estadistica miConexion = new estadistica();
            return miConexion.tablaFormada();

        }
    }
}
