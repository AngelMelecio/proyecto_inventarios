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
        private object inpF;

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
            double h = Double.Parse(inpH.Text);

            resQ.Text = formulas.Q(D,k,h).ToString();
        }
        


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this);
        }

        private void resQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOptenerN_Click(object sender, EventArgs e)
        {
           
            {
                double D = Double.Parse(inpD.Text);
                double Q = Double.Parse(inpQ.Text);

                resN.Text = formulas.N(D, Q).ToString();
            }

        }
        private void btnObtenerT_Click(object sender, EventArgs e)
        {
            {
                double N = Double.Parse(inpN.Text);
                

                resT.Text = formulas.T(N).ToString();
            }


        }

        private void btnObtenerDmin_Click(object sender, EventArgs e)
        {
            double D = Double.Parse(inpD.Text);

            resDmin.Text = formulas.Dmin(D).ToString();
        }

        private void btnObtenerR_Click(object sender, EventArgs e)
        {
            double dia = Double.Parse(inpdia.Text);
            double L = Double.Parse(inpL.Text);
            resR.Text = formulas.R(dia, L).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

   


}


