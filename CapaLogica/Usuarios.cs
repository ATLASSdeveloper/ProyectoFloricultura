using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Usuarios
    {
        public string cedula { get; set; }

        public string[] nombres { get; set; }

        public string[] apellidos { get; set; }

        public string correo { get; set; }
        public string clave { get; set; }

        public string cargo { get; set; }
    }
}
