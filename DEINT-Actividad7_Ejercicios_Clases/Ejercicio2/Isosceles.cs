using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Actividad7_Ejercicios_Clases.Ejercicio2
{
    internal class Isosceles
    {
        public double LadosIguales { get; set; }
        public double LadoDesigual { get; set; }
        public double AlturaTriangulo { get; set; }
        public double Perimetro { get; private set; }
        public double Area { get; private set; }

        public Isosceles(double ladosIguales, double ladoDesigual)
        {

            LadosIguales = ladosIguales;
            LadoDesigual = ladoDesigual;
            AlturaTriangulo = Math.Round(Math.Sqrt(Math.Pow(LadosIguales, 2) - Math.Pow(ladoDesigual, 2) / 4), 2);

        }

        public void HacerPerimetro()
        {
            Perimetro = LadosIguales * 2 + LadoDesigual;
            Console.WriteLine($"Perímetro -> {Perimetro}");
        }

        public void HacerArea()
        {
            Area = LadoDesigual * AlturaTriangulo / 2;
            Console.WriteLine($"Área -> {Area}");
        }

    }
}
