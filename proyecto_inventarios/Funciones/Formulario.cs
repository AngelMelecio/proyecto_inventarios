using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_inventarios.Funciones
{
    internal class Formulario
    {
        
        public double NumPzsOrdenar(int D, int K, int n)
        {
            return Math.Sqrt((2 * D * K) / n); 
        }

    }

}
