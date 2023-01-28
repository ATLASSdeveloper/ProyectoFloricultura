using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class controlInvernaderos
    {
        public DataTable invernaderosDisponibles()
        {
            
            DMLControlInvernadero control=new DMLControlInvernadero();
            return control.DMLinvernaderosDisponibles();
        }

        public DataTable lasFlores(int id)
        {
            DMLControlInvernadero control = new DMLControlInvernadero();
            return control.DMLlasFlores(id);
        }

        public DataTable registros(int id)
        {
            DMLControlInvernadero control = new DMLControlInvernadero();
            return control.DMLregistros(id);
        }
    }
}
