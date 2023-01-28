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
    public partial class Invernaderos : Form
    {
        public Invernaderos()
        {
            InitializeComponent();
            cargarListaInvernaderos();
            this.Size = new System.Drawing.Size(width: 1000, height: 550);
            this.MaximumSize = new System.Drawing.Size(width: 1000, height: 550);
            this.MinimumSize = new System.Drawing.Size(width: 1000, height: 550);
            this.Text = "Control Invernaderos";
        }

        public void cargarListaInvernaderos()
        {
            controlInvernaderos invernaderos = new controlInvernaderos();
            if (invernaderos.invernaderosDisponibles() == null)
            {
                MessageBox.Show("Se perdio la conexion con la base de datos");
                return;
            }
            this.los_invernaderos.DataSource = invernaderos.invernaderosDisponibles();
            this.los_invernaderos.DisplayMember = "nombre";
            this.los_invernaderos.ValueMember = "id";
        }

        private void los_invernaderos_SelectedIndexChanged(object sender, EventArgs e)
        {
            controlInvernaderos misInvernaderos = new controlInvernaderos();
            tablaTemperaturas.DataSource = misInvernaderos.registros(Convert.ToInt32(this.los_invernaderos.SelectedValue));
            DataTable tabla = misInvernaderos.lasFlores(Convert.ToInt32(this.los_invernaderos.SelectedValue));
            DataTable lasflores = misInvernaderos.lasFlores(Convert.ToInt32(this.los_invernaderos.SelectedValue));
            try
            {
                this.label1.Text = lasflores.Rows[0][1].ToString();
                this.label2.Text = lasflores.Rows[0][3].ToString() + "-" + lasflores.Rows[0][2].ToString() + " C";
                this.label3.Text = lasflores.Rows[0][5].ToString() + "-" + lasflores.Rows[0][4].ToString() + " %";
            }
            catch (Exception)
            {
                MessageBox.Show("El invernadero no contiene flores en su interior");
                this.label1.Text = "";
                this.label2.Text = "";
                this.label3.Text = "";
            }
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void button_crudPlantas_Click(object sender, EventArgs e)
        {
            CRUDplantas plantas = new CRUDplantas();    
            plantas.Show();
            this.Close();
        }

        private void button_crudInvernaderos_Click(object sender, EventArgs e)
        {
            CRUDInvernaderos invernaderos= new CRUDInvernaderos();
            invernaderos.Show();
            this.Close();
        }
    }
}
