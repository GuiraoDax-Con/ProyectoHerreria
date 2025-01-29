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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MateriasPrimas materiasPrimas = new MateriasPrimas();
            materiasPrimas.Show();
            this.Hide();


        }

        private void btElaborar_Click(object sender, EventArgs e)
        {
            Elaboracion elaboracion = new Elaboracion();
            elaboracion.Show();
            this.Hide();
        }
    }
}
