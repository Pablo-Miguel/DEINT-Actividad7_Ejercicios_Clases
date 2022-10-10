// See https://aka.ms/new-console-template for more information

using DEINT_Actividad7_Ejercicios_Clases;

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

