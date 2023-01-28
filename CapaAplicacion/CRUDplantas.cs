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
    public partial class CRUDplantas : Form
    {
        public CRUDplantas()
        {
            InitializeComponent();
            this.mostrarDatos();
            this.Size = new System.Drawing.Size(width: 1000, height: 550);
            this.MaximumSize = new System.Drawing.Size(width: 1000, height: 550);
            this.MinimumSize = new System.Drawing.Size(width: 1000, height: 550);
            this.Text = "Plantas";
        }

        int id, temperatura_max, temperatura_min, humedad_max, humedad_min;
        string nombreDeLaPlanta;

        public void limpiarVariables()
        {
            id = 0;
            temperatura_max = 0;
            temperatura_min = 0;
            humedad_max = 0;
            humedad_min = 0;
            nombreDeLaPlanta = "";
        }

        public void mostrarDatos()
        {
            LogicaPlantas tablaPlantas = new LogicaPlantas();
            LaTablaPlantas.DataSource = tablaPlantas.tablaFormada();
        }

        private void button_crear_Click(object sender, EventArgs e)
        {
            mostrarFormulario();
            this.crea.Visible = true;
        }



        private void mostrarFormulario()
        {
            this.label_hum1.Visible = true;
            this.label_hum2.Visible = true;
            this.label_nom.Visible = true;
            this.label_tem1.Visible = true;
            this.label_tem2.Visible = true;
            this.nom_planta.Visible = true;
            this.tem_maxima.Visible = true;
            this.tem_min.Visible = true;
            this.hum_maxima.Visible = true;
            this.hum_minima.Visible = true;
            this.button_cancelar.Visible = true;
            this.button_crear.Visible = false;
            this.button_editar.Visible = false;
            this.button_eliminar.Visible = false;
        }

        private void ocultarFormulario()
        {
            this.label_hum1.Visible = false;
            this.label_hum2.Visible = false;
            this.label_nom.Visible = false;
            this.label_tem1.Visible = false;
            this.label_tem2.Visible = false;
            this.nom_planta.Visible = false;
            this.tem_maxima.Visible = false;
            this.tem_min.Visible = false;
            this.hum_maxima.Visible = false;
            this.hum_minima.Visible = false;
            this.button_cancelar.Visible = false;
            this.button_crear.Visible = true;
            this.button_editar.Visible = true;
            this.button_eliminar.Visible = true;
            this.crea.Visible = false;
            this.editar.Visible = false;
        }

        private void limpiarFormulario()
        {
            this.nom_planta.Text = "";
            this.tem_maxima.Text = "";
            this.tem_min.Text = "";
            this.hum_maxima.Text = "";
            this.hum_minima.Text = "";
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Seleccione una flor para modificar sus atributos");
                return;
            }
            mostrarFormulario();
            cargaDatosFormulario();
            this.editar.Visible = true;
        }

        private void editar_Click(object sender, EventArgs e)
        {
            string planta = this.nom_planta.Text;
            int tem_max = Convert.ToInt32(this.tem_maxima.Text);
            int tem_min = Convert.ToInt32(this.tem_min.Text);
            int hum_max = Convert.ToInt32(this.hum_maxima.Text);
            int hum_min = Convert.ToInt32(this.hum_minima.Text);
            LogicaPlantas creaPlanta = new LogicaPlantas();
            string mensaje = creaPlanta.editarPlantas(id, planta, tem_max, tem_min, hum_max, hum_min);
            MessageBox.Show(mensaje);
            if (mensaje.Equals("Planta modificada exitosamente"))
            {
                limpiarFormulario();
                ocultarFormulario();
                mostrarDatos();
                limpiarVariables();
            }

        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            LogicaPlantas eliminaPlanta = new LogicaPlantas();
            if (id == null || id == 0)
            {
                MessageBox.Show("Identifique la planta que quiera eliminar");
            }
            else
            {
                string mensaje = eliminaPlanta.eliminarPlantas(id);
                if (mensaje.Equals(""))
                {
                    mostrarDatos();
                    MessageBox.Show("Planta eliminada correctamente");
                    limpiarVariables();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
            ocultarFormulario();
        }

        private void crea_Click(object sender, EventArgs e)
        {
            string planta = this.nom_planta.Text;
            if (this.tem_maxima.Text.Equals(""))
            {
                this.tem_maxima.Text = "0";
            }
            if (this.tem_min.Text.Equals(""))
            {
                this.tem_min.Text = "0";
            }
            if (this.hum_maxima.Text.Equals(""))
            {
                this.hum_maxima.Text = "0";
            }
            if (this.hum_minima.Text.Equals(""))
            {
                this.hum_minima.Text = "0";
            }
            int tem_max = Convert.ToInt32(this.tem_maxima.Text);
            int tem_min = Convert.ToInt32(this.tem_min.Text);
            int hum_max = Convert.ToInt32(this.hum_maxima.Text);
            int hum_min = Convert.ToInt32(this.hum_minima.Text);
            LogicaPlantas creaPlanta = new LogicaPlantas();
            string mensaje = creaPlanta.agregarPlantas(planta, tem_max, tem_min, hum_max, hum_min);
            MessageBox.Show(mensaje);
            if (mensaje.Equals("Planta agregada correctamente"))
            {
                limpiarFormulario();
                ocultarFormulario();
                mostrarDatos();
            }
        }

        private void cargaDatosFormulario()
        {
            this.nom_planta.Text = nombreDeLaPlanta;
            this.tem_maxima.Text = temperatura_max.ToString();
            this.tem_min.Text = temperatura_min.ToString();
            this.hum_maxima.Text = humedad_max.ToString();
            this.hum_minima.Text = humedad_min.ToString();

        }
        private void clickTabla(object sender, DataGridViewCellEventArgs e)
        {
            this.id = Convert.ToInt32(LaTablaPlantas.CurrentRow.Cells[0].Value);
            this.nombreDeLaPlanta = LaTablaPlantas.CurrentRow.Cells[1].Value.ToString();
            this.temperatura_max = Convert.ToInt32(LaTablaPlantas.CurrentRow.Cells[2].Value);
            this.temperatura_min = Convert.ToInt32(LaTablaPlantas.CurrentRow.Cells[3].Value);
            this.humedad_max = Convert.ToInt32(LaTablaPlantas.CurrentRow.Cells[4].Value);
            this.humedad_min = Convert.ToInt32(LaTablaPlantas.CurrentRow.Cells[5].Value);
            if (this.editar.Visible == true)
            {
                cargaDatosFormulario();
            }

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


        private void TeclearNombre(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            Invernaderos losInvernaderos = new Invernaderos();
            losInvernaderos.Show();
            this.Close();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void teclaTemMax(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void TeclearTempMin(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void TeclearHumMax(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void TeclearHumMin(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }
    }
}
