using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herreria
{
    public partial class Elaboracion : Form
    {
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
          

        }
    }
}
