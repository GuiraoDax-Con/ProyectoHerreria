using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herreria
{
    public partial class MateriasPrimas : Form
    {
        SqlConnection conection = new SqlConnection("Server=(local)\\SQLEXPRESS;Database=master;Integrated Security = SSPI;");
        SqlCommand comando = new SqlCommand();
        public MateriasPrimas()
        {
            InitializeComponent();
        }

        private void MateriasPrimas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'materiasPrimasDataSet.MATERIAS_PRIMAS' Puede moverla o quitarla según sea necesario.
            this.mATERIAS_PRIMASTableAdapter.Fill(this.materiasPrimasDataSet.MATERIAS_PRIMAS);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conection.Open();
            comando.Connection = conection;

            string selectedItem = cbMateriasPrimas.SelectedItem.ToString();
            if (decimal.TryParse(txtCantidad.Text, out decimal newPeso))
            {
                
                {
                
                    string query = "UPDATE MATERIAS_PRIMAS SET Peso = (Peso+@Peso) WHERE Nombre = @Nombre";
                    using (SqlCommand command = new SqlCommand(query, conection))
                    {
                        command.Parameters.AddWithValue("@Peso", newPeso);
                        command.Parameters.AddWithValue("@Nombre", selectedItem);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Peso actualizado correctamente.");
                            this.mATERIAS_PRIMASTableAdapter.Fill(this.materiasPrimasDataSet.MATERIAS_PRIMAS);

                        }
                        else
                        {
                            MessageBox.Show("No se encontró el ítem seleccionado.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un peso válido.");
            }
        }

        private void BtVolver_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
