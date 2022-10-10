using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Actividad7_Ejercicios_Clases
{
    internal class Cliente
    {
        public String? Dni { get; set; }
        public String? Nombre { get; set; }
        public Double CantAhorrada { get; set; } = 0;

        public Cliente(String dni, String nombre)
        {
            Dni = dni;
            Nombre = nombre;

        }

        public Cliente()
        {

        }

        public void Aumentar(Double cant) {
            
            CantAhorrada += Math.Round(cant, 2);
            Console.WriteLine($"Ingresado {cant} correctamente");

        }

        public void Extraer(Double cant) {

            if (CantAhorrada - cant < 0)
            {
                Console.WriteLine($"No se puede extraer tanto dinero: Vuelve a tener {CantAhorrada}");
            }
            else {
                CantAhorrada = Math.Round(cant, 2);
                Console.WriteLine($"Extraido {cant} correctamente");
            }

        }

        public void ConsultarSaldo() {
            Console.WriteLine($"Cantidad ahorrada: {CantAhorrada}");
        }
    }
}
