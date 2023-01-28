using Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class principalAdmin : Form
    {
        public principalAdmin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CRUDusuarios ventanaUsuarios = new CRUDusuarios();
            this.Close();
            ventanaUsuarios.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Invernaderos losInvernaderos=new Invernaderos();
            losInvernaderos.botonRegresar();
            losInvernaderos.Visible= true;
            this.Close();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Login login=new Login();
            login.Visible = true;
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Repo reportes;
            try
            {
                reportes = new Repo();
                this.Close();
                reportes.Visible = true;
            }
            catch(Exception ex) { 
            }
            
        }
    }
}
