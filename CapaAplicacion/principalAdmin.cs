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
    public partial class principalAdmin : Form
    {
        public principalAdmin()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(width: 1000, height: 550);
            this.MaximumSize = new System.Drawing.Size(width: 1000, height: 550);
            this.MinimumSize = new System.Drawing.Size(width: 1000, height: 550);
            this.Text = "Página Principal";
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            this.Close();
        }

        private void boton_reportes_Click(object sender, EventArgs e)
        {
            Reportes reporteria= new Reportes();
            reporteria.Show();
            this.Close();
        }

        private void boton_invernaderos_Click(object sender, EventArgs e)
        {
            Invernaderos invernadero=new Invernaderos();
            invernadero.Show();
            this.Close();
        }

        private void boton_usuarios_Click(object sender, EventArgs e)
        {
            CRUDUsuarios usuarios=new CRUDUsuarios();
            usuarios.Show();    
            this.Close();
        }
    }
}
