using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Herreria
{
    public partial class Form3 : Form
    {
        Equipamiento equipamiento = new Equipamiento();
        List<Equipamiento> listaEquipamiento = new List<Equipamiento>();
        private DataGridViewRow objetosSeleccionado = null;
        private readonly string connectionString = "Server=(local)\\SQLEXPRESS;Database=master;Integrated Security=SSPI;";
        private Excel.Application objetoExcel = new Excel.Application();
        public Form3(string nombre)
        {
            InitializeComponent();
            lbUsur.Text = $"{nombre}";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'equipamientoDataSet1.EQUIPAMIENTO' Puede moverla o quitarla según sea necesario.
            this.eQUIPAMIENTOTableAdapter.Fill(this.equipamientoDataSet1.EQUIPAMIENTO);
            dataGridView1.DataSource = equipamientoDataSet1.Tables["EQUIPAMIENTO"];

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (objetosSeleccionado != null)
            {
                int idEquipamiento = int.Parse(objetosSeleccionado.Cells[0].Value.ToString());
                string nombreEquipamiento = objetosSeleccionado.Cells[1].Value.ToString();

                using (SqlConnection conection = new SqlConnection(connectionString))
                {
                    conection.Open();
                    string query = "UPDATE EQUIPAMIENTO SET cantidad = (cantidad - 1) WHERE nombre = @Nombre";
                    using (SqlCommand command = new SqlCommand(query, conection))
                    {
                        command.Parameters.AddWithValue("@Nombre", nombreEquipamiento);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Equipameinto actualizado correctamente.");
                            this.eQUIPAMIENTOTableAdapter.Fill(this.equipamientoDataSet1.EQUIPAMIENTO);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el equipo seleccionado.");
                        }
                    }
                }
                MessageBox.Show("Elaboración completada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Verificar si el producto ya existe en la lista
                var productoExistente = listaEquipamiento.FirstOrDefault(equip => equip.Id == idEquipamiento);
                if (productoExistente != null)
                {
                    // Incrementar la cantidad del producto existente
                    productoExistente.Cantidad += 1;
                }
                else
                {
                    // Agregar el nuevo producto a la lista
                    listaEquipamiento.Add(equipamiento);
                }

            }
            else
            {
                MessageBox.Show("Por favor, seleccione un objeto para actualizar el stock.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                objetosSeleccionado = dataGridView1.SelectedRows[0];
                int idEquip = int.Parse(objetosSeleccionado.Cells[0].Value.ToString());
                string nombreEquip = objetosSeleccionado.Cells[1].Value.ToString();
                int cantidadEquip = 1;
                decimal precioEquip = decimal.Parse(objetosSeleccionado.Cells[3].Value.ToString());
                string tipoEquip = objetosSeleccionado.Cells[4].Value.ToString();
                decimal pesoEquip = decimal.Parse(objetosSeleccionado.Cells[5].Value.ToString());
                equipamiento = new Equipamiento(idEquip, nombreEquip, precioEquip, tipoEquip, pesoEquip, cantidadEquip);
                //MessageBox.Show("Equipamiento comprado: " + equipamiento.ToString());
                MessageBox.Show("Objeto seleccionado: " + objetosSeleccionado.Cells[1].Value.ToString());
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    objetosSeleccionado = row;

                    //MessageBox.Show("Objeto seleccionado: " + objetosSeleccionado.Cells[1].Value.ToString());
                    break;
                }
            }
        }

        private void cbEquipamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEquipamiento.SelectedItem != null)
            {
                string filtro = cbEquipamiento.SelectedItem.ToString();

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

        private void button2_Click(object sender, EventArgs e)
        {
            objetoExcel.Visible = true;

            Excel.Workbook libro = objetoExcel.Workbooks.Add(Missing.Value);
            Excel.Worksheet hoja = (Excel.Worksheet)libro.Worksheets.get_Item(1);

            // Agregar encabezados
            hoja.Cells[1, 1] = "Id";
            hoja.Cells[1, 2] = "Nombre";
            hoja.Cells[1, 3] = "Cantidad";
            hoja.Cells[1, 4] = "Precio Venta";
            hoja.Cells[1, 5] = "Tipo";
            hoja.Cells[1, 6] = "Peso";

            // Agregar datos de la lista
            int row = 2;
            decimal totalPrecio = 0;
            foreach (var item in listaEquipamiento)
            {
                hoja.Cells[row, 1] = item.Id;
                hoja.Cells[row, 2] = item.Nombre;
                hoja.Cells[row, 3] = item.Cantidad;
                hoja.Cells[row, 4] = item.Precio_venta;
                hoja.Cells[row, 5] = item.Tipo;
                hoja.Cells[row, 6] = item.Peso;
                totalPrecio += item.Precio_venta * item.Cantidad;
                row++;
            }

            // Agregar total de precios
            int totalRow = row + 2;
            hoja.Cells[totalRow, 3] = "Total";
            hoja.Cells[totalRow, 4] = totalPrecio +"PO";

            // Formatear celdas
            Excel.Range rango = hoja.get_Range("A1", "F1");
            rango.Font.Bold = true;
            rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            rango.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

            rango = hoja.get_Range($"A1:F{row}");
            rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

            // Formatear celdas del total
            rango = hoja.get_Range($"C{totalRow}", $"D{totalRow}");
            rango.Font.Bold = true;
            rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            rango.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

            // Insertar imagen
            string imagePath = "C:\\Users\\Guty\\source\\repos\\HerreriaDnd\\Herreria\\Herreria\\asets\\sello.jpg"; 
            hoja.Shapes.AddPicture(imagePath, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 100, 100, 100, 100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
