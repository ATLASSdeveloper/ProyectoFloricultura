using CapaLogica;
using System;
using System.Collections;
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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
            this.cargaDatos();
            this.cargarListaInvernaderos();
            this.los_invernaderos.Text = string.Empty;
            this.Size = new System.Drawing.Size(width: 1000, height: 550);
            this.MaximumSize = new System.Drawing.Size(width: 1000, height: 550);
            this.MinimumSize = new System.Drawing.Size(width: 1000, height: 550);
            this.Text = "Reportes";
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            this.Close();
        }

        public void cargaDatos()
        {
            LogicaEstadistica log = new LogicaEstadistica();
            DataTable tabla = log.tabla();
            ArrayList Fechas = new ArrayList();
            ArrayList Temperatura = new ArrayList();
            ArrayList Humedad = new ArrayList();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Fechas.Add(tabla.Rows[i]["FECHA"].ToString());
                Temperatura.Add(Convert.ToDouble(tabla.Rows[i]["ROUND((SUM(TEMPERATURA))/COUNT(ID))"]));
                Humedad.Add(Convert.ToDouble(tabla.Rows[i]["ROUND((SUM(HUMEDAD))/COUNT(ID))"]));
            }
            estadisticaVisual.Series[0].Points.DataBindXY(Fechas, Temperatura);
            estadisticaVisual.Series[1].Points.DataBindXY(Fechas, Humedad);
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
            LogicaEstadistica log = new LogicaEstadistica();
            DataTable tabla = log.tablaEspecifica(this.los_invernaderos.SelectedValue.ToString());
            ArrayList Fechas = new ArrayList();
            ArrayList Temperatura = new ArrayList();
            ArrayList Humedad = new ArrayList();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Fechas.Add(tabla.Rows[i]["FECHA"].ToString());
                Temperatura.Add(Convert.ToDouble(tabla.Rows[i]["ROUND((SUM(TEMPERATURA))/COUNT(ID))"]));
                Humedad.Add(Convert.ToDouble(tabla.Rows[i]["ROUND((SUM(HUMEDAD))/COUNT(ID))"]));
            }
            estadisticaVisual.Series[0].Points.DataBindXY(Fechas, Temperatura);
            estadisticaVisual.Series[1].Points.DataBindXY(Fechas, Humedad);
        }

        private void los_invernaderos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.los_invernaderos.Text.Equals(""))
            {
                this.cargaDatos();
            }
        }
    }
}
