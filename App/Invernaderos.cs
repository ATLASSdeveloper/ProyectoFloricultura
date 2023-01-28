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
    public partial class Invernaderos : Form
    {
        public Invernaderos()
        {
            InitializeComponent();
            cargarListaInvernaderos();
        }

        public void botonRegresar()
        {
            this.regresar.Visible = true;
        }
        public void cargarListaInvernaderos()//
        {
            controlInvernaderos invernaderos = new controlInvernaderos();
            if (invernaderos.invernaderosDisponibles()==null)
            {
                MessageBox.Show("Se perdio la conexion con la base de datos");
                return;
            }
            this.los_invernaderos.DataSource = invernaderos.invernaderosDisponibles();
            this.los_invernaderos.DisplayMember = "nombre";
            this.los_invernaderos.ValueMember = "id";
        }
        private void gestionarPlantas_Click(object sender, EventArgs e)
        {
            crudPlantas misPlantas = new crudPlantas();
            misPlantas.Visible = true;
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gestionInvernaderos_Click(object sender, EventArgs e)
        {
            CRUDinvernaderoscs miInvernadero=new CRUDinvernaderoscs();
            this.Hide();
            miInvernadero.Visible = true;
        }

        private void los_invernaderos_SelectedIndexChanged(object sender, EventArgs e)//
        {
            controlInvernaderos misInvernaderos = new controlInvernaderos();
            tablaTemperaturas.DataSource = misInvernaderos.registros(Convert.ToInt32(this.los_invernaderos.SelectedValue));
            DataTable tabla = misInvernaderos.lasFlores(Convert.ToInt32(this.los_invernaderos.SelectedValue));
            DataTable lasflores = misInvernaderos.lasFlores(Convert.ToInt32(this.los_invernaderos.SelectedValue));
            try
            {
                this.nom_pla.Text = lasflores.Rows[0][1].ToString();
                this.tem_pla.Text = lasflores.Rows[0][3].ToString() + "-" + lasflores.Rows[0][2].ToString() + " C";
                this.hum_pla.Text = lasflores.Rows[0][5].ToString() + "-" + lasflores.Rows[0][4].ToString() + " %";
            }
            catch (Exception)
            {
                MessageBox.Show("El invernadero no contiene flores en su interior");
                this.nom_pla.Text = "";
                this.tem_pla.Text = "";
                this.hum_pla.Text = "";
            }
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            principalAdmin esadmin = new principalAdmin();
            this.Close();
            esadmin.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login= new Login();
            login.Visible= true;
            this.Close();
        }
    }
}
