using proyecto_inventarios.Funciones;
using proyecto_inventarios.Funciones.Result;
using System;
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
        //------------------------------FORMULA PARA SACAR Q----------------------------------------------------------------
        private void btnObtenerQ_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inpD.Text) || string.IsNullOrEmpty(inpK.Text) || string.IsNullOrEmpty(inpH.Text))
            {
                string camposFaltantes = "";

                if (string.IsNullOrEmpty(inpD.Text))
                    camposFaltantes += "D, ";

                if (string.IsNullOrEmpty(inpK.Text))
                    camposFaltantes += "K, ";

                if (string.IsNullOrEmpty(inpH.Text))
                    camposFaltantes += "H, ";

                camposFaltantes = camposFaltantes.TrimEnd(',', ' '); 

                MessageBox.Show($"Por favor, complete los campos: {camposFaltantes}.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            try
            {
                double D = Double.Parse(inpD.Text);
                double k = Double.Parse(inpK.Text);
                double h = Double.Parse(inpH.Text);

                resQ.Text = formulas.Q(D, k, h).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar limpiar = new Limpiar();
            limpiar.BorrarCampos(this);
        }

        private void resQ_TextChanged(object sender, EventArgs e)
        {

        }

        //-----------------------------------------FORMULA PARA SACAR N------------------------------------------
        private void btnOptenerN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inpD.Text) || string.IsNullOrEmpty(inpQ.Text))
            {
                string camposFaltantes = "";

                if (string.IsNullOrEmpty(inpD.Text))
                    camposFaltantes += "D, ";

                if (string.IsNullOrEmpty(inpQ.Text))
                    camposFaltantes += "Q, ";

                camposFaltantes = camposFaltantes.TrimEnd(',', ' '); 

                MessageBox.Show($"Por favor, complete los campos: {camposFaltantes}.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            try
            {
                double D = Double.Parse(inpD.Text);
                double Q = Double.Parse(inpQ.Text);

                resN.Text = formulas.N(D, Q).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //----------------------------FORMULA PARA SACAR T---------------------------------
        private void btnObtenerT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inpN.Text))
            {
                MessageBox.Show("Por favor, complete el campo N.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            try
            {
                double N = Double.Parse(inpN.Text);

                resT.Text = formulas.T(N).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido en el campo N.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //------------------ FORMULA PARA SACAR d---------------------------------------------------
        private void btnObtenerDmin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inpD.Text))
            {
                MessageBox.Show("Por favor, ingrese el valor de D.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            try
            {
                double D = Double.Parse(inpD.Text);

                resDmin.Text = formulas.Dmin(D).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para D.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // ---------------------- FORMULA PARA SACAR R---------------------------------------------------
        private void btnObtenerR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inpDmin.Text) || string.IsNullOrEmpty(inpL.Text))
            {
                string camposFaltantes = "";

                if (string.IsNullOrEmpty(inpDmin.Text))
                    camposFaltantes += "d, ";

                if (string.IsNullOrEmpty(inpL.Text))
                    camposFaltantes += "L, ";

                camposFaltantes = camposFaltantes.TrimEnd(',', ' '); 

                MessageBox.Show($"Por favor, complete los campos: {camposFaltantes}.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            try
            {
                double dia = Double.Parse(inpDmin.Text);
                double L = Double.Parse(inpL.Text);

                resR.Text = formulas.R(dia, L).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void inpDmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void inpN_TextChanged(object sender, EventArgs e)
        {

        }

        //Comentario: Se ordenaron las variables para evitar un problema en el envio de los datos, porque al realizar la depuración se
        //mostraron valores que no correspondian con el de los campos de texto solicitados
        //Advertencia: no mover los valores que se envian ni las variables declaradas
        private void btnTC_Click(object sender, EventArgs e)
        {
            double D = Double.Parse(inpD.Text);
            double C = Double.Parse(inpC.Text);
            double K = Double.Parse(inpK.Text);
            double Q = Double.Parse(inpQ.Text);
            double h = Double.Parse(inpH.Text);
            txtMuestraTC.Text = formulas.TC(D, C, K, Q, h).ToString();
        }

        /**  private void btnObtenerTC_Click(object sender, EventArgs e)
          {
              double D = Double.Parse(inpD.Text);
              double C = Double.Parse(inpC.Text);
              double Q = Double.Parse(inpQ.Text);
              double h = Double.Parse(inpH.Text);
              resR.Text = formulas.R(D, C, Q, h).ToString();
            
          } */
    }

   


}


