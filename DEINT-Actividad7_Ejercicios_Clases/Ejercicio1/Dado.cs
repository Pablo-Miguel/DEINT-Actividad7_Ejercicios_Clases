using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Actividad7_Ejercicios_Clases.Ejercicio1
{
    internal class Dado
    {
        Random r = new Random();
        public short Valor { get; set; } = 0;

        public Dado()
        {
            Tirar();
        }

        public void Tirar()
        {
            Valor = (short)r.Next(1, 7);
            Console.WriteLine($"Valor dado: {Valor}");
        }
    }
}
