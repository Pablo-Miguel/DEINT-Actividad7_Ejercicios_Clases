// See https://aka.ms/new-console-template for more information

using DEINT_Actividad7_Ejercicios_Clases.Ejercicio1;
using DEINT_Actividad7_Ejercicios_Clases.Ejercicio2;
using DEINT_Actividad7_Ejercicios_Clases.Ejercicio3;
using DEINT_Actividad7_Ejercicios_Clases.Ejercicio4;

//Ejercicio1
Console.WriteLine("Ejercicio 1");
Juego juego = new Juego();

juego.Tirar();

Console.WriteLine();

//Ejercicio2
Console.WriteLine("Ejercicio 2");

Isosceles isosceles = new Isosceles(8, 5);

isosceles.HacerPerimetro();
isosceles.HacerArea();

Console.WriteLine();

//Ejercicio3
Console.WriteLine("Ejercicio3");

Banco banco = new Banco();

banco.Operar();

banco.FinalDia();

Console.WriteLine();

//Ejercicio4
Console.WriteLine("Ejercicio4");

Persona persona = new Persona("Manuel Jesus", 4);
Empleado empleado = new Empleado("Pablito", 5, 2500.0);

Console.WriteLine(persona.ToString());
Console.WriteLine(empleado.ToString());
