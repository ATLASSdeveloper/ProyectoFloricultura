using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class CRUDinvernaderoscs : Form
    {
        string nombreSeleccionado="";
        string capacidadSeleccionada="",invernaderoSeleccionado="";
        string idFlorSeleccionada = "";

        public void limpiarVariables()
        {
            nombreSeleccionado = "";
            capacidadSeleccionada = "";
            invernaderoSeleccionado = "";
            idFlorSeleccionada = "";
        }
        public CRUDinvernaderoscs()
        {
            InitializeComponent();
            cargaDatosTabla();
            cargaDatosFlores();
            limpiarFormulario();
        }

        public void cargaDatosTabla()
        {
            LogicaInvernaderos tablaInvernaderos=new LogicaInvernaderos();  
            this.tablaInvernaderos.DataSource= tablaInvernaderos.tablaFormada();
        }

        public void cargaDatosFlores()
        {
            LogicaInvernaderos flores = new LogicaInvernaderos();
            if (flores.floresDisponibles == null)
            {
                MessageBox.Show("No se ha podido establecer la conexion con la base de datos");
                return;
            }
            this.flores.DataSource = flores.floresDisponibles();
            this.flores.DisplayMember = "nombre";
            this.flores.ValueMember = "id";
        }

        public void mostrarFormulario()
        {
            this.jtxtflor.Visible = true;
            this.jtxtcapacidad.Visible = true;
            this.jtxtnombre.Visible = true;
            this.button_cancelar.Visible = true;
            this.inputCapacidad.Visible = true;
            this.inputNombre.Visible = true;
            this.flores.Visible= true;
            this.button_crear.Visible = false;
            this.button_editar.Visible = false;
            this.button_borrar.Visible = false;
        }

        public void ocultarFormulario()
        {
            this.jtxtflor.Visible = false;
            this.jtxtcapacidad.Visible = false;
            this.jtxtnombre.Visible = false;
            this.button_cancelar.Visible = false;
            this.inputCapacidad.Visible = false;
            this.inputNombre.Visible = false;
            this.flores.Visible = false;
            this.button_crear.Visible = true;
            this.button_editar.Visible = true;
            this.button_borrar.Visible = true;
            this.crear.Visible = false;
            this.editar.Visible = false;
        }

        public void limpiarFormulario()
        {
            this.inputCapacidad.Text= string.Empty;
            this.inputNombre.Text= string.Empty;
            this.flores.Text= string.Empty;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_crear_Click(object sender, EventArgs e)
        {
            mostrarFormulario();
            this.crear.Visible= true;

        }

        private void crear_Click(object sender, EventArgs e)
        {
            string nombre = this.inputNombre.Text.ToString();
            int capacidad=0;
            if (!this.inputCapacidad.Text.ToString().Equals(""))
            {
                capacidad=Convert.ToInt32(this.inputCapacidad.Text.ToString());
            }
            string? idFlor;
            if (this.flores.Text.Equals(""))
            {
                idFlor = null;
            }
            else
            {
                idFlor=this.flores.SelectedValue.ToString();
            }
            
            LogicaInvernaderos agregar=new LogicaInvernaderos();
            string mensaje=agregar.agregarInvernadero(nombre,capacidad,idFlor);
            if (mensaje.Equals(""))
            {
                cargaDatosTabla();
                limpiarFormulario();
                MessageBox.Show("Invernadero creado exitosamente");
            }
            else
            {
                MessageBox.Show(mensaje);
            }

        }

        private void editar_Click(object sender, EventArgs e)
        {
            LogicaInvernaderos edita = new LogicaInvernaderos();
            string nombre = this.inputNombre.Text.ToString();
            int capacidad = 0;
            if (!this.inputCapacidad.Text.ToString().Equals(""))
            {
                capacidad=Convert.ToInt32(this.inputCapacidad.Text.ToString());
            }
            string? idFlor;
            if (this.flores.Text.Equals(""))
            {
                idFlor = null;
            }
            else
            {
                idFlor = this.flores.SelectedValue.ToString();
            }

            string mensaje=edita.editaInvernadero(invernaderoSeleccionado, nombre, capacidad, idFlor);
            if (mensaje.Equals(""))
            {
                limpiarFormulario();
                ocultarFormulario();
                cargaDatosTabla();
                limpiarVariables();
                MessageBox.Show("Edicion de invernadero completada con exito");
            }
            else
            {
                MessageBox.Show(mensaje);
            }
            

        }

        private void tablaInvernaderos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.invernaderoSeleccionado = tablaInvernaderos.CurrentRow.Cells[0].Value.ToString();
            this.nombreSeleccionado= tablaInvernaderos.CurrentRow.Cells[1].Value.ToString();
            this.capacidadSeleccionada = tablaInvernaderos.CurrentRow.Cells[2].Value.ToString();
            this.idFlorSeleccionada = tablaInvernaderos.CurrentRow.Cells[3].Value.ToString();
            
            if (editar.Visible==true)
            {
                this.inputNombre.Text = nombreSeleccionado;
                this.inputCapacidad.Text = capacidadSeleccionada;
                if (idFlorSeleccionada.Equals(""))
                {
                    this.flores.Text = string.Empty;
                }
                else
                {
                    this.flores.SelectedValue = idFlorSeleccionada.ToString();
                }
            }
        }

        private void button_borrar_Click(object sender, EventArgs e)
        {
            LogicaInvernaderos eliminar=new LogicaInvernaderos();
            string mensaje=eliminar.eliminarInvernadero(invernaderoSeleccionado);
            if (mensaje.Equals(""))
            {
                MessageBox.Show("Eliminado con exito");
                cargaDatosTabla();
                limpiarVariables();
            }
            else
            {
                MessageBox.Show(mensaje);
            }

        }

        private void TeclearNombre(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            if (nombreSeleccionado.Equals(""))
            {
                MessageBox.Show("Seleccione un invernadero para modificar");
                return;
            }
            mostrarFormulario();
            this.editar.Visible= true;
            this.inputNombre.Text=nombreSeleccionado.ToString();
            this.inputCapacidad.Text=capacidadSeleccionada.ToString();
            if (idFlorSeleccionada.Equals(""))
            {
                this.flores.Text = string.Empty;
            }
            else
            { 
            this.flores.SelectedValue = idFlorSeleccionada.ToString();
            }

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
            ocultarFormulario();
            
        }

        private void TeclearCapacidad(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        public void soloNumeros(KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;

            }
        }

        private void TeclearFlores(object sender, KeyPressEventArgs e)
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

        private void regresa_Click(object sender, EventArgs e)
        {
            Invernaderos losInvernaderos= new Invernaderos();   
            losInvernaderos.Show();
            this.Close();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
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
