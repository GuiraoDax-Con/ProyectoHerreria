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
    public partial class MateriasPrimas : Form
    {
        List<MateriaPrima> listaMateriasPrimas = new List<MateriaPrima>();
        private Excel.Application objetoExcel = new Excel.Application();
        MateriaPrima materiaPrima = new MateriaPrima();
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
                // Obtener el precio de compra de la materia prima seleccionada
                string querySelect = "SELECT Precio_compra FROM MATERIAS_PRIMAS WHERE Nombre = @Nombre";
                decimal precioCompra = 0;
                using (SqlCommand commandSelect = new SqlCommand(querySelect, conection))
                {
                    commandSelect.Parameters.AddWithValue("@Nombre", selectedItem);
                    using (SqlDataReader reader = commandSelect.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            precioCompra = reader.GetDecimal(0);
                        }
                    }
                }
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
                            // Verificar si la materia prima ya existe en la lista
                            var materiaExistente = listaMateriasPrimas.FirstOrDefault(mp => mp.Nombre == selectedItem);
                            if (materiaExistente != null)
                            {
                                // Incrementar el peso de la materia prima existente
                                materiaExistente.Peso += newPeso;
                            }
                            else
                            {
                                // Agregar la nueva materia prima a la lista
                                materiaPrima = new MateriaPrima
                                {
                                    Nombre = selectedItem,
                                    Peso = newPeso,
                                     Precio_compra = precioCompra
                                };
                                listaMateriasPrimas.Add(materiaPrima);
                            }
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
            conection.Close();
        }

        private void BtVolver_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2("THARIVOL");
            form2.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            objetoExcel.Visible = true;

            Excel.Workbook libro = objetoExcel.Workbooks.Add(Missing.Value);
            Excel.Worksheet hoja = (Excel.Worksheet)libro.Worksheets.get_Item(1);

            // Agregar encabezados
            hoja.Cells[1, 2] = "Nombre";
            hoja.Cells[1, 3] = "Peso";
            hoja.Cells[1, 4] = "Precio Compra";

            // Agregar datos de la lista
            int row = 2;
            decimal totalPrecio = 0;
            foreach (var item in listaMateriasPrimas)
            {
                hoja.Cells[row, 2] = item.Nombre;
                hoja.Cells[row, 3] = item.Peso;
                hoja.Cells[row, 4] = item.Precio_compra;
                totalPrecio += item.Precio_compra * item.Peso;
                row++;
            }

            // Agregar total de precios
            int totalRow = row + 2;
            hoja.Cells[totalRow, 2] = "Total";
            hoja.Cells[totalRow, 4] = totalPrecio + " PO";

            // Formatear celdas
            Excel.Range rango = hoja.get_Range("A1", "D1");
            rango.Font.Bold = true;
            rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            rango.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

            rango = hoja.get_Range($"A1:D{row}");
            rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

            // Formatear celdas del total
            rango = hoja.get_Range($"B{totalRow}", $"D{totalRow}");
            rango.Font.Bold = true;
            rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            rango.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

            // Insertar imagen
            string imagePath = "C:\\Users\\Guty\\source\\repos\\HerreriaDnd\\Herreria\\Herreria\\asets\\sello.jpg";
            hoja.Shapes.AddPicture(imagePath, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 50, totalRow * 15, 100, 100);
        }
    
    }
}
