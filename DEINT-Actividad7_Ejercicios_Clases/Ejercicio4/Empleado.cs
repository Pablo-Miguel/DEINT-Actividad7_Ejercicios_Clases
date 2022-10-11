using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Actividad7_Ejercicios_Clases.Ejercicio4
{
    internal class Empleado : Persona
    {
        public Double Sueldo { get; set; }
        public Empleado(String nombre, Int16 edad, Double sueldo) : base(nombre, edad)
        {
            Sueldo = sueldo;
        }
        public override string ToString()
        {
            return base.ToString() + $", Sueldo -> {Sueldo}";
        }
    }
}
