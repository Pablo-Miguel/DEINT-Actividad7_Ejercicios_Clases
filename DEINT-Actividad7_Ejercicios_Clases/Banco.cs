using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Actividad7_Ejercicios_Clases
{
    internal class Banco
    {
        public Cliente[] listaClientes { get; set; } = { new Cliente("1", "Pablo"), new Cliente("2", "Manu"), new Cliente("3", "Marta") };

        public void Operar() {
            String? dniTemp, opcion = null;
            Cliente? cliTemp = null;
            Double cant;
            Boolean salir = false;
            do {
                Console.WriteLine("Introduzca el DNI del cliente con el que desea operar: ");
                dniTemp = Console.ReadLine();

                cliTemp = obtenerClientePorDNI(dniTemp);

                if (cliTemp == null)
                {
                    Console.WriteLine($"ERROR: No existe cliente con DNI {dniTemp}");
                }
                else {
                    Console.WriteLine($"Introduzca el tipo de operación a realizar con {cliTemp.Dni}: Ingresar [I], Extraer [E] o Consultar saldo [C]");
                    opcion = Console.ReadLine();

                    if (opcion != null && opcion.ToLower().StartsWith("i"))
                    {
                        Console.WriteLine("Ingrese cantidad a ingresar: ");
                        cant = Math.Round(Double.Parse(Console.ReadLine()), 2);
                        cliTemp.Aumentar(cant);
                    }
                    else if (opcion != null && opcion.ToLower().StartsWith("e"))
                    {
                        Console.WriteLine("Ingrese cantidad a extraer: ");
                        cant = Math.Round(Double.Parse(Console.ReadLine()), 2);
                        cliTemp.Extraer(cant);
                    }
                    else if (opcion != null && opcion.ToLower().StartsWith("c"))
                    {
                        cliTemp.ConsultarSaldo();
                    }
                    else
                    {
                        Console.WriteLine("ERROR: Elija una opción");
                    }

                    Console.WriteLine("Desea realizar otra operación: Si [S] o No [N]: ");
                    opcion = Console.ReadLine();

                    if (opcion == null || opcion.ToLower().StartsWith("n"))
                    {
                        salir = true;
                    }
                }

            } while (!salir);

        }

        public void FinalDia() {
            Console.WriteLine($"Cantidad del dia: {Math.Round(listaClientes.Sum(c => c.CantAhorrada), 2)}");
        }

        private Cliente? obtenerClientePorDNI(string? dniTemp)
        {
            foreach (var c in listaClientes) {
                if (c.Dni.Equals(dniTemp)) { 
                    return c;
                }
            }
            return null;
        }
    }
}
