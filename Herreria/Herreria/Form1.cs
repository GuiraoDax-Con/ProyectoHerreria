using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Herreria
{
    public partial class Form1 : Form
    {
        SqlConnection conection = new SqlConnection("Server=(local)\\SQLEXPRESS;Database=master;Integrated Security = SSPI;");
        SqlCommand comando = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            string nombre = txtNombre.Text;
            string pass = txtPassword.Text;
            string rol;


            conection.Open();
            comando.Connection = conection;
            comando.CommandText = "SELECT * FROM USUARIO WHERE nombre = @nombre and password = @pass";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@pass", pass);
            comando.ExecuteNonQuery();
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                nombre = reader.GetString(1);
                pass = reader.GetString(2);
                rol = reader.GetString(3);
                MessageBox.Show("Bienvenido a la herreria: " + nombre);
                if (rol == "administrador")
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
