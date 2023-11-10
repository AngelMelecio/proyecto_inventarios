using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_inventarios.Funciones
{
    internal class Formulario
    {
        // Numero de piezas a Ordenar 
        public double Q(double D, double K, double h)
        {
            return Math.Sqrt((2 * D * K) / h);
        }

        // Numero de Orden Por año 
        public double N(double D, double Q)
        {
            return D / Q;
        }

        // Tiempo entre Ordenes 
        public double T(double N)
        {
            return 365 / N;
        }

        //Demanda por Día
        public double Dmin(double D)
        {
            return D / 365;
        }

        // Punto de Reorden
        public double R(double dia, double L)
        {
            return dia * L;
        }
        // Costo Total de Inventario 
        public double TC(double D, double Q, double h, double C, double K)
        {
            return (((D * C) + (D / Q * K) + (Q / 2) * h));
        }
    }
}

    





