using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_inventarios.Funciones.Result
{
    public partial class FrmAyuda : Form
    {
        public FrmAyuda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }
    }
}
