using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Actividad7_Ejercicios_Clases
{
    internal class Isosceles
    {
        public Double LadosIguales { get; set; }
        public Double LadoDesigual { get; set; }
        public Double AlturaTriangulo { get; set; }
        public Double Perimetro { get; private set; }
        public Double Area { get; private set; }

        public Isosceles(Double ladosIguales, Double ladoDesigual)
        {

            this.LadosIguales = ladosIguales;
            this.LadoDesigual = ladoDesigual;
            AlturaTriangulo = Math.Round(Math.Sqrt(Math.Pow(LadosIguales, 2) - (Math.Pow(ladoDesigual, 2) / 4)), 2);

        }

        public void HacerPerimetro() {
            Perimetro = (LadosIguales * 2) + LadoDesigual;
            Console.WriteLine($"Perímetro -> {Perimetro}");
        }

        public void HacerArea() {
            Area = (LadoDesigual * AlturaTriangulo) / 2;
            Console.WriteLine($"Área -> {Area}");
        }

    }
}
