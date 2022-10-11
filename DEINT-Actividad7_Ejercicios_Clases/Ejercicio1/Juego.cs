using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Actividad7_Ejercicios_Clases.Ejercicio1
{
    internal class Juego
    {
        public Dado[] listaDados { get; set; } = { new Dado(), new Dado(), new Dado() };

        public void Tirar()
        {

            if (listaDados.Sum(d => d.Valor) == listaDados.First().Valor * 3)
            {
                Console.WriteLine("Has ganado");
            }
            else
            {
                Console.WriteLine("Has perdido");
            }
        }

    }
}
