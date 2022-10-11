using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Actividad7_Ejercicios_Clases.Ejercicio3
{
    internal class Cliente
    {
        public string? Dni { get; set; }
        public string? Nombre { get; set; }
        public double CantAhorrada { get; set; } = 0;

        public Cliente(string dni, string nombre)
        {
            Dni = dni;
            Nombre = nombre;

        }

        public Cliente()
        {

        }

        public void Aumentar(double cant)
        {

            CantAhorrada += Math.Round(cant, 2);
            Console.WriteLine($"Ingresado {cant} correctamente");

        }

        public void Extraer(double cant)
        {

            if (CantAhorrada - cant < 0)
            {
                Console.WriteLine($"No se puede extraer tanto dinero: Vuelve a tener {CantAhorrada}");
            }
            else
            {
                CantAhorrada = Math.Round(cant, 2);
                Console.WriteLine($"Extraido {cant} correctamente");
            }

        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Cantidad ahorrada: {CantAhorrada}");
        }
    }
}
