using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Invernadero
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int capacidad { get; set; }

        public Planta flor { get; set; }
    }
}
