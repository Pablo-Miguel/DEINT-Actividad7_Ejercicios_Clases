using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Actividad7_Ejercicios_Clases
{
    internal class Dado
    {
        Random r = new Random();
        public Int16 Valor { get; set; } = 0;

        public Dado()
        {
            this.Tirar();
        }

        public void Tirar()
        {
            Valor = (Int16) r.Next(1, 7);
            Console.WriteLine($"Valor dado: {Valor}");
        }
    }
}
