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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(width:1000,height: 550);
            this.MaximumSize = new System.Drawing.Size(width: 1000, height: 550);
            this.MinimumSize = new System.Drawing.Size(width: 1000, height: 550);
        }

        private void boton_inicio_sesion_Click(object sender, EventArgs e)
        {
            string correo = correoTEXT.Text;
            string clave = claveTEXT.Text;
            Consultas autentificar = new Consultas();
            string existe = autentificar.autentificacion(correo, clave);
            if (existe == null)
            {
                MessageBox.Show("Conexion perdida con la base de datos");
            }
            if (existe == "0")
            {
                MessageBox.Show("Credenciales no identificadas");
            }
            else
            {
                string cargo = autentificar.identificarCargo(correo, clave);
                if (cargo == "Administrador")
                {
                    principalAdmin admin = new principalAdmin();
                    this.Hide();
                    admin.Show();
                }
                else
                {
                    if (cargo == "Floricultor")
                    {
                        Invernaderos inv = new Invernaderos();
                        inv.Show();
                        this.Hide();
                    }
                    else
                    {
                        if (cargo == "Analista")
                        {
                            Reportes reporteria = new Reportes();
                            reporteria.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
