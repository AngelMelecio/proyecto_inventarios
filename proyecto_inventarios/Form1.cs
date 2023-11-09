using proyecto_inventarios.Funciones;
using proyecto_inventarios.Funciones.Result;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_inventarios
{
    public partial class Form1 : Form
    {
        private Formulario formulas;

        public Form1()
        {
            InitializeComponent();

            formulas = new Formulario();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            new FrmAyuda().ShowDialog();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnObtenerQ_Click(object sender, EventArgs e)
        {
            double D = Double.Parse(inpD.Text);
            double k = Double.Parse(inpK.Text);
            double n = Double.Parse(inpN.Text);

            resQ.Text = formulas.Q(D,k,n).ToString();
        }
    }
}
