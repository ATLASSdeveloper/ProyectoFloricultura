using Logica;
using MySql.Data.MySqlClient;

namespace App

{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correo = correoTEXT.Text;
            string clave = claveTEXT.Text;
            Consultas autentificar= new Consultas();
            string existe=autentificar.autentificacion(correo,clave);
            if (existe==null)
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
                if (cargo == "Administrador") { 
                    principalAdmin admin= new principalAdmin();
                    this.Hide();
                    admin.Show();
                }
                else
                {
                    if (cargo == "Floricultor")
                    {
                        Invernaderos inv=new Invernaderos();
                        inv.Show();
                        this.Hide();
                    }
                }
            }
            
        }
    }
}