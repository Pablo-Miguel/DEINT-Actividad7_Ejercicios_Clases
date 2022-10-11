using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Actividad7_Ejercicios_Clases.Ejercicio4
{
    internal class Persona
    {
        public String Nombre { get; set; }
        public Int16 Edad { get; set; }

        public Persona(String nombre, Int16 edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public override string ToString()
        {
            return $"Persona: Nombre -> {Nombre}, Edad -> {Edad} años";
        }
    }
}
