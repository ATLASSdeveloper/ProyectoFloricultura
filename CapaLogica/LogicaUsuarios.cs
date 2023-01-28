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
    public class LogicaUsuarios
    {
        public DataTable tablaFormada()
        {
            DMLUsuarios tablaDatos = new DMLUsuarios();
            return tablaDatos.consultaTablaFormada();
        }

        public string validarEntradas(string cedula, string nombre, string apellido, string correo, string clave, string cargo)
        {
            string mensaje = "";
            if (VerificaCedula(cedula.ToCharArray()) == false)
            {
                mensaje = mensaje + "La cedula no es valida \n";
            }
            if (nombre.Split(' ').Length < 1 || nombre.Split(' ').Length > 2 || nombre.Equals(""))
            {
                mensaje = mensaje + "La persona puede tener minimo un nombre o maximo dos nombres\n";
            }
            if (apellido.Split(' ').Length < 1 || apellido.Split(' ').Length > 2 || apellido.Equals(""))
            {
                mensaje = mensaje + "La persona puede tener minimo un apellido o maximo dos apellidos\n";
            }
            if (!correo.EndsWith("@uta.edu.ec") && !correo.EndsWith("@yahoo.com") && !correo.EndsWith("@gmail.com")
                && !correo.EndsWith("@hotmail.com"))
            {
                mensaje = mensaje + "El correo ingresado no es valido\n";
            }
            if (cargo.Equals(""))
            {
                mensaje = mensaje + "registre el cargo del empleado\n";
            }
            if (clave.Equals(""))
            {
                mensaje = mensaje + "Ingrese una clave para el acceso al sistema";
            }
            return mensaje;
        }

        public static bool VerificaCedula(char[] validarCedula)
        {
            if (validarCedula.Length < 10)
            {
                return false;
            }
            int aux = 0, par = 0, impar = 0, verifi;
            for (int i = 0; i < 9; i += 2)
            {
                aux = 2 * int.Parse(validarCedula[i].ToString());
                if (aux > 9)
                    aux -= 9;
                par += aux;
            }
            for (int i = 1; i < 9; i += 2)
            {
                impar += int.Parse(validarCedula[i].ToString());
            }

            aux = par + impar;
            if (aux % 10 != 0)
            {
                verifi = 10 - (aux % 10);
            }
            else
                verifi = 0;
            if (verifi == int.Parse(validarCedula[9].ToString()))
                return true;
            else
                return false;
        }
        public string agregarUsuarios(string cedula, string nombre, string apellido, string correo, string clave, string cargo)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.nombres = new string[2];
            usuarios.apellidos = new string[2];

            nombre = nombre.TrimStart();
            nombre = nombre.TrimEnd();
            apellido = apellido.TrimStart();
            apellido = apellido.TrimEnd();
            string mensaje = validarEntradas(cedula, nombre, apellido, correo, clave, cargo);
            if (!mensaje.Equals(""))
            {
                return mensaje;
            }
            int numnombres = nombre.Split(' ').Length;
            int numapellidos = apellido.Split(' ').Length;
            string[] nombres = new string[2];
            if (numnombres == 1)
            {
                usuarios.nombres[0] = nombre.Split(' ')[0];
                usuarios.nombres[1] = "";
            }
            else
            {
                usuarios.nombres = nombre.Split(' ');
            }
            string[] apellidos = new string[2];
            if (numapellidos == 1)
            {
                usuarios.apellidos[0] = apellido.Split(' ')[0];
                usuarios.apellidos[1] = " ";
            }
            else { usuarios.apellidos = apellido.Split(' '); }

            usuarios.cedula = cedula;
            usuarios.correo = correo;
            usuarios.clave = clave;
            usuarios.cargo = cargo;

            DMLUsuarios agregar=new DMLUsuarios();
            return agregar.consultaAgregarUsuarios(usuarios.cedula, usuarios.nombres[0], usuarios.nombres[1],
                        usuarios.apellidos[0], usuarios.apellidos[1],usuarios.correo,usuarios.clave,usuarios.cargo);
        }

        public string eliminar_usuario(string cedula)
        {
            DMLUsuarios eliminar=new DMLUsuarios();
            return eliminar.consulta_eliminar_usuario(cedula);
        }

        public string editarUsuarios(string cedula, string nombre, string apellido, string correo, string clave, string cargo)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.nombres = new string[2];
            usuarios.apellidos = new string[2];
            nombre = nombre.TrimStart();
            nombre = nombre.TrimEnd();
            apellido = apellido.TrimStart();
            apellido = apellido.TrimEnd();
            string mensaje = validarEntradas(cedula, nombre, apellido, correo, clave, cargo);
            if (!mensaje.Equals(""))
            {
                return mensaje;
            }
            int numnombres = nombre.Split(' ').Length;
            int numapellidos = apellido.Split(' ').Length;
            string[] nombres = new string[2];
            if (numnombres == 1)
            {
                usuarios.nombres[0] = nombre.Split(' ')[0];
                usuarios.nombres[1] = "";
            }
            else
            {
                usuarios.nombres = nombre.Split(' ');
            }
            string[] apellidos = new string[2];
            if (numapellidos == 1)
            {
                usuarios.apellidos[0] = apellido.Split(' ')[0];
                usuarios.apellidos[1] = " ";
            }
            else { usuarios.apellidos = apellido.Split(' '); }

            usuarios.cedula = cedula;
            usuarios.correo = correo;
            usuarios.clave = clave;
            usuarios.cargo = cargo;

            DMLUsuarios actualizar=new DMLUsuarios();
            return actualizar.consultaEditarUsuarios(usuarios.cedula, usuarios.nombres[0], usuarios.nombres[1],
                        usuarios.apellidos[0], usuarios.apellidos[1], usuarios.correo, usuarios.clave, usuarios.cargo);
        }
    }
}
