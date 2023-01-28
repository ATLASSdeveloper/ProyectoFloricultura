using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaAplicacion
{
    public partial class CRUDUsuarios : Form
    {
        public string select_cedula, select_nombre, select_nombre2,
    select_apellido, select_apellido2, select_correo, select_clave, select_cargo;
        public CRUDUsuarios()
        {
            InitializeComponent();
            this.tabla();
            this.limpiarVariables();
            this.Size = new System.Drawing.Size(width: 1000, height: 550);
            this.MaximumSize = new System.Drawing.Size(width: 1000, height: 550);
            this.MinimumSize = new System.Drawing.Size(width: 1000, height: 550);
            this.Text = "Usuarios";
        }

        public void limpiarVariables()
        {
            select_cedula = "";
            select_nombre = "";
            select_nombre2 = "";
            select_apellido = "";
            select_apellido2 = "";
            select_correo = "";
            select_clave = "";
            select_cargo = "";
        }

        public void tabla()
        {
            LogicaUsuarios miTabla = new LogicaUsuarios();
            this.losusuarios.DataSource = miTabla.tablaFormada();

        }

        private void crear_Click(object sender, EventArgs e)
        {
            this.mostrarFormulario();
            this.clave.Enabled= true;
            this.cedula.Enabled = true;
            this.Guardar.Visible = true;
        }

        private void mostrarFormulario()
        {
            this.ced.Visible = true;
            this.nom.Visible = true;
            this.ape.Visible = true;
            this.cor.Visible = true;
            this.pass.Visible = true;
            this.car.Visible = true;
            this.cedula.Visible = true;
            this.nombres.Visible = true;
            this.apellido.Visible = true;
            this.correo.Visible = true;
            this.clave.Visible = true;
            this.cargo.Visible = true;
            this.Cancelar.Visible = true;
            this.Eliminar.Visible = false;
            this.actualizar.Visible = false;
            this.crear.Visible = false;

        }

        public void ocultarFormulario()
        {
            this.ced.Visible = false;
            this.nom.Visible = false;
            this.ape.Visible = false;
            this.cor.Visible = false;
            this.pass.Visible = false;
            this.car.Visible = false;
            this.cedula.Visible = false;
            this.nombres.Visible = false;
            this.apellido.Visible = false;
            this.correo.Visible = false;
            this.clave.Visible = false;
            this.cargo.Visible = false;
            this.Cancelar.Visible = false;
            this.Eliminar.Visible = true;
            this.actualizar.Visible = true;
            this.crear.Visible = true;
        }

        public void limpiarFormulario()
        {
            this.cedula.Clear();
            this.nombres.Clear();
            this.apellido.Clear();
            this.correo.Clear();
            this.clave.Clear();
            this.cargo.ResetText();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (select_cedula.Equals(""))
            {
                MessageBox.Show("Seleccione un usuario para eliminar");
                return;
            }
            LogicaUsuarios usuario = new LogicaUsuarios();
            string mensaje = usuario.eliminar_usuario(select_cedula);
            if (mensaje.Equals(""))
            {
                MessageBox.Show("Eliminado exitosamente");
                this.tabla();
                limpiarVariables();
            }
            else
            {
                MessageBox.Show(mensaje);
            }

        }

        public void almacenarDatos()
        {
            this.cedula.Text = select_cedula;
            this.nombres.Text = select_nombre + " " + select_nombre2;
            this.apellido.Text = select_apellido + " " + select_apellido2;
            this.correo.Text = select_correo;
            this.clave.Text = select_clave;
            this.cargo.Text = select_cargo;
        }
        private void actualizar_Click(object sender, EventArgs e)
        {
            if (select_cedula.Equals(""))
            {
                MessageBox.Show("Seleccione un usuario para modificar");
                return;
            }
            mostrarFormulario();
            this.actualizacion.Visible = true;
            this.cedula.Enabled = false;
            this.clave.Enabled= false;
            almacenarDatos();

        }

        private void actualizacion_Click(object sender, EventArgs e)
        {

            string cedula = this.cedula.Text;
            string nombres = this.nombres.Text;
            string apellidos = this.apellido.Text;
            string correo = this.correo.Text;
            string clave = this.clave.Text;
            string cargo = this.cargo.Text;
            LogicaUsuarios miconsulta = new LogicaUsuarios();
            string mensaje = miconsulta.editarUsuarios(cedula, nombres, apellidos, correo, clave, cargo);
            if (mensaje.Equals(""))
            {
                MessageBox.Show("Actualizacion Exitosa");
                this.tabla();
                limpiarVariables();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void losusuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select_cedula = losusuarios.CurrentRow.Cells[0].Value.ToString();
            select_nombre = losusuarios.CurrentRow.Cells[1].Value.ToString();
            select_nombre2 = losusuarios.CurrentRow.Cells[2].Value.ToString();
            select_apellido = losusuarios.CurrentRow.Cells[3].Value.ToString();
            select_apellido2 = losusuarios.CurrentRow.Cells[4].Value.ToString();
            select_correo = losusuarios.CurrentRow.Cells[5].Value.ToString();
            select_clave = losusuarios.CurrentRow.Cells[6].Value.ToString();
            select_cargo = losusuarios.CurrentRow.Cells[7].Value.ToString();
            if (actualizacion.Visible == true)
            {
                almacenarDatos();
            }
        }

        private void apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }


        private void cargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            noEscribir(e);
        }

        public void noEscribir(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true; return;
            }
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            principalAdmin esadmin = new principalAdmin();
            this.Close();
            esadmin.Visible = true;
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            this.Close();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string cedula = this.cedula.Text;
            string nombres = this.nombres.Text;
            string apellidos = this.apellido.Text;
            string correo = this.correo.Text;
            string clave = this.clave.Text;
            string cargo = this.cargo.Text;
            LogicaUsuarios usuario = new LogicaUsuarios();
            string mensaje = usuario.agregarUsuarios(cedula, nombres, apellidos, correo, clave, cargo);
            if (mensaje.Equals(""))
            {
                limpiarFormulario();
                MessageBox.Show("Agregado exitosamente");
                this.tabla();
            }
            else
            {
                MessageBox.Show(mensaje);
            }

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
            ocultarFormulario();
            this.Guardar.Visible = false;
            this.actualizacion.Visible = false;
        }

        private void cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }



        private void nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void losusuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void soloNumeros(KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;

            }
        }

        public void soloLetras(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar) && (!char.IsControl(e.KeyChar))))

            {
                e.Handled = true;

                return;

            }
        }
    }
}
