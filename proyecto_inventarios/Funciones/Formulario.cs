using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_inventarios.Funciones
{
    internal class Formulario
    {
        
        public double Q(double D, double K, double n)
        {
            return Math.Sqrt((2 * D * K) / n); 
        }
        public double N(double D, double Q) 
        {
            return D / Q;
        }
        public double T(double N)
        {
            return 365 / N;
        }
        public double Dmin( double D)
        {
            return D / 365;
        }
        public double R(double d, double L)
        {
            return d * L;
        }

    }

}
