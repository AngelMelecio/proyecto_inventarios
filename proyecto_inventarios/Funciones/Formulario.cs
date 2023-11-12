using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_inventarios.Funciones
{
    internal class Formulario
    {
        //Comentario: se agrego una variable para manejar los tiempos que se necesitan en las formulas de T y d
        double diasXanio = 360;
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
            return (diasXanio / N);
        }

        //Demanda por Día
        public double Dmin(double D)
        {
            return D / diasXanio;
        }

        // Punto de Reorden
        public double R(double dia, double L)
        {
            return dia * L;
        }
        // Costo Total de Inventario 
        //Comentario: se tenia un error al recibir los datos como correspondian por lo que se tuvo que realizar un acomodo en base a 
        //los datos que recibe de uno por uno , es decir se organizo para evitar problemas en el calculo: D,C,K,Q,h
        public double TC(double D, double C, double K, double Q, double h)
        {
            double opcion = (D * C);
            double Prepara = (D / Q);
            double PreparaT = (Prepara * K);
            double Almacen = (Q / 2);
            double CostoA = Almacen * h;
            double CostoFinal = (opcion + PreparaT + CostoA);
            return CostoFinal;
        }
    }
}

    





