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
    public class LogicaPlantas
    {
        public DataTable tablaFormada()
        {
            DMLPlantas tabla = new DMLPlantas();
            return tabla.consultaTablaFormada();

        }

        public string agregarPlantas(string nombre, int tem_max, int tem_min, int hum_max, int hum_min)
        {

            string mensaje = validarEntradas(nombre, tem_max, tem_min, hum_max, hum_min);
            if (!mensaje.Equals(""))
            {
                return mensaje;
            }

            Planta planta = new Planta();
            planta.nombre = nombre;
            planta.temperatura_maxima_adecuada = tem_max;
            planta.temperatura_minima_adecuada = tem_min;
            planta.humedad_maxima_adecuada = hum_max;
            planta.humedad_minima_adecuada = hum_min;


            DMLPlantas Agregar = new DMLPlantas();
            return Agregar.consultaAgregarPlantas(planta.nombre,planta.temperatura_maxima_adecuada,planta.temperatura_minima_adecuada,
                                        planta.humedad_maxima_adecuada,planta.humedad_minima_adecuada);
        }

        public string validarEntradas(string nombre, int tem_max, int tem_min, int hum_max, int hum_min)
        {
            string mensaje = "";
            if (nombre.Equals("") || tem_max == 0 || tem_min == 0 || hum_max == 0 || hum_min == 0)
            {
                mensaje = mensaje + "Todos los campos son obligatorios \n";
            }
            else
            {
                if (tem_max < tem_min)
                {
                    mensaje = mensaje + "La temperatura maxima no puede ser menor a la temperatura minima \n";
                }
                if (hum_max < hum_min)
                {
                    mensaje = mensaje + "La humedad maxima no puede ser menor a la humedad minima \n";
                }
            }
            return mensaje;
        }

        public string editarPlantas(int id, string nombre, int tem_max, int tem_min, int hum_max, int hum_min)
        {
            string mensaje = validarEntradas(nombre, tem_max, tem_min, hum_max, hum_min);
            if (!mensaje.Equals(""))
            {
                return mensaje;
            }

            Planta planta = new Planta();
            planta.id = id;
            planta.nombre = nombre;
            planta.temperatura_maxima_adecuada = tem_max;
            planta.temperatura_minima_adecuada = tem_min;
            planta.humedad_maxima_adecuada = hum_max;
            planta.humedad_minima_adecuada = hum_min;



            DMLPlantas editar = new DMLPlantas();
            return editar.consultaEditarPlantas(planta.id,planta.nombre,planta.temperatura_maxima_adecuada,
                planta.temperatura_minima_adecuada,planta.humedad_maxima_adecuada,planta.humedad_minima_adecuada);
        }

        public string eliminarPlantas(int id)
        {
            DMLPlantas eliminar=new DMLPlantas();
            return eliminar.consultaEliminarPlantas(id);
        }

    }
}
