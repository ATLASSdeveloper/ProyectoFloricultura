using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class LogicaInvernaderos
    {

        public DataTable tablaFormada()
        {
            
            DMLInvernaderos miConexion = new DMLInvernaderos();
            return miConexion.consultaTablaFormada();

        }

        public DataTable floresDisponibles()
        {
            DMLInvernaderos flores=new DMLInvernaderos();
            return flores.consultaFloresDisponibles();

        }

        public string agregarInvernadero(string nombre, int capacidad, string flor)
        {
            Invernadero invernadero = new Invernadero();
            if (nombre.Equals(""))
            {
                return "el invernadero debe tener un nombre";
            }
            if (!flor.Equals(""))
            {
                int la_flor = Convert.ToInt32(flor);
                Planta p = new Planta();
                p.id = la_flor;
                invernadero.flor = p;
            }

            invernadero.nombre = nombre;
            invernadero.capacidad = capacidad;


            DMLInvernaderos invernaderos=new DMLInvernaderos();
            return invernaderos.consultaAgregarInvernadero(invernadero.nombre, invernadero.capacidad, flor);
        }

        public string editaInvernadero(string id, string nombre, string capacidad, string flor)
        {
            Invernadero invernadero = new Invernadero();
            int mi_invernadero = 0;
            int capacidadInvernadero = 0;

            if (id.Equals(""))
            {
                return "identifique un invernadero";
            }
            if (nombre.Equals(""))
            {
                return "El invernadero debe tener un nombre";
            }

            
            if (!capacidad.Equals(""))
            {
                capacidadInvernadero = Convert.ToInt32(capacidad);
            }
            mi_invernadero = Convert.ToInt32(id);

            invernadero.id = mi_invernadero;
            invernadero.nombre = nombre;
            invernadero.capacidad = capacidadInvernadero;

            DMLInvernaderos editar = new DMLInvernaderos();
            return editar.consultaEditaInvernadero(invernadero.id, invernadero.nombre, invernadero.capacidad, flor);


        }

        public string eliminarInvernadero(string id)
        {
            int elID = 0;
            if (id.Equals(""))
            {
                return "Seleccione un invernadero para eliminar";
            }
            
            
            elID = Convert.ToInt32(id);
            
            DMLInvernaderos eliminar = new DMLInvernaderos();
            return eliminar.consultaEliminarInvernadero(elID);
        }
    }
}
