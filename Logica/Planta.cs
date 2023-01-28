using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Planta
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public int temperatura_maxima_adecuada { get; set; }
        public int temperatura_minima_adecuada { get; set; }

        public int humedad_maxima_adecuada { get; set; }

        public int humedad_minima_adecuada { get; set; }
    }
}
