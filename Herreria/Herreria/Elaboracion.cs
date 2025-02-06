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
    public partial class Elaboracion : Form
    {
        Equipamiento equipamiento = new Equipamiento();
        private DataGridViewRow objetosSeleccionado = null;
        List<Equipamiento> listaEquipamiento = new List<Equipamiento>();
        private readonly string connectionString = "Server=(local)\\SQLEXPRESS;Database=master;Integrated Security=SSPI;";
        public Elaboracion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Elaboracion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'equipamientoDataSet1.EQUIPAMIENTO' Puede moverla o quitarla según sea necesario.
            this.eQUIPAMIENTOTableAdapter1.Fill(this.equipamientoDataSet1.EQUIPAMIENTO);
            dataGridView1.DataSource = equipamientoDataSet1.Tables["EQUIPAMIENTO"];

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    objetosSeleccionado = row;
                    equipamiento.Id = int.Parse(objetosSeleccionado.Cells[0].Value.ToString());
                    equipamiento = objetosSeleccionado.DataBoundItem as Equipamiento;

                    //MessageBox.Show("Objeto seleccionado: " + objetosSeleccionado.Cells[1].Value.ToString());
                    break;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoEquipamiento.SelectedItem != null)
            {
                string filtro = cbTipoEquipamiento.SelectedItem.ToString();

                // Verifica que el DataSource del DataGridView sea un DataTable
                if (dataGridView1.DataSource is DataTable dataTable)
                {
                    dataTable.DefaultView.RowFilter = string.Format("tipo LIKE '%{0}%'", filtro);
                }
                else
                {
                    MessageBox.Show("El origen de datos del DataGridView no es un DataTable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un elemento del ComboBox.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                objetosSeleccionado = dataGridView1.SelectedRows[0];

                MessageBox.Show("Objeto seleccionado: " + objetosSeleccionado.Cells[1].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (objetosSeleccionado != null)
            {
                int idEquipamiento = int.Parse(objetosSeleccionado.Cells[0].Value.ToString());
                string nombreEquipamiento = objetosSeleccionado.Cells[1].Value.ToString();

                if (ActualizarPesoMateriasPrimas(idEquipamiento))
                {
                    using (SqlConnection conection = new SqlConnection(connectionString))
                    {
                        conection.Open();
                        string query = "UPDATE EQUIPAMIENTO SET cantidad = (cantidad + 1) WHERE nombre = @Nombre";
                        using (SqlCommand command = new SqlCommand(query, conection))
                        {
                            command.Parameters.AddWithValue("@Nombre", nombreEquipamiento);
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Stock actualizado correctamente.");
                                this.eQUIPAMIENTOTableAdapter1.Fill(this.equipamientoDataSet1.EQUIPAMIENTO);

                            }
                            else
                            {
                                MessageBox.Show("No se encontró el ítem seleccionado.");
                            }
                        }
                    }
                    MessageBox.Show("Elaboración completada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un objeto para actualizar el stock.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2("THARIVOL");
            form2.Show();
            this.Hide();
        }

        private bool ActualizarPesoMateriasPrimas(int idEquipamiento)
        {
            try
            {
                using (SqlConnection conection = new SqlConnection(connectionString))
                {
                    conection.Open();

                    // Consulta para obtener el peso disponible de las materias primas necesarias para el equipamiento
                    string querySelect = @"
                        SELECT mp.nombre, mp.peso, mpe.cantidad_necesaria
                        FROM MATERIAS_PRIMAS mp
                        INNER JOIN MATERIAS_PRIMAS_EQUIPAMIENTO mpe ON mp.id = mpe.id_materia_prima
                        WHERE mpe.id_equipamiento = @IdEquipamiento";

                    using (SqlCommand commandSelect = new SqlCommand(querySelect, conection))
                    {
                        commandSelect.Parameters.AddWithValue("@IdEquipamiento", idEquipamiento);
                        using (SqlDataReader reader = commandSelect.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nombreMateriaPrima = reader["nombre"].ToString();
                                double pesoDisponible = Convert.ToDouble(reader["peso"]);
                                double pesoNecesarioParaEquipamiento = Convert.ToDouble(reader["cantidad_necesaria"]);

                                if (pesoDisponible < pesoNecesarioParaEquipamiento)
                                {
                                    MessageBox.Show($"No hay suficiente peso de {nombreMateriaPrima}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                            }
                        }
                    }

                    // Consulta para actualizar el peso de las materias primas
                    string queryUpdate = @"
                        UPDATE MATERIAS_PRIMAS
                        SET peso = peso - mpe.cantidad_necesaria
                        FROM MATERIAS_PRIMAS mp
                        INNER JOIN MATERIAS_PRIMAS_EQUIPAMIENTO mpe ON mp.id = mpe.id_materia_prima
                        WHERE mpe.id_equipamiento = @IdEquipamiento";

                    using (SqlCommand commandUpdate = new SqlCommand(queryUpdate, conection))
                    {
                        commandUpdate.Parameters.AddWithValue("@IdEquipamiento", idEquipamiento);
                        commandUpdate.ExecuteNonQuery();
                    }

                    MessageBox.Show("Peso de materias primas actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el peso de las materias primas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btFactura_Click(object sender, EventArgs e)
        {
           
           
            listaEquipamiento.Add(equipamiento);
        }
    }
}