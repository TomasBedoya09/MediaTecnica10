/******************************************************************************
Autor: Tomas A. Bedoya
Fecha: 30-05-2024
Descripcion: Ejercicio aprendizaje

             Dada la nota determinar:
             1- Pierde
             2- Pierde
             3- Gana
             4- Alto
             5- Superior

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Digite un la nota (1.0-5.0), luego enter");
    Console.Write("Nota: ");
    int nota = Int32.Parse(Console.ReadLine());
    switch(nota)
    { 
    case 1:
      Console.WriteLine("Pierde");
      break;
    case 2:
      Console.WriteLine("Pierde");
      break;
    case 3:
      Console.WriteLine("Gana");
      break;
    case 4:
      Console.WriteLine("Alto");
      break;
    case 5:
      Console.WriteLine("Superior");
      break;
    default:
      Console.WriteLine("Opcion no valida");
      Console.WriteLine("Saliendo del programa...");
      break;
    }
  }
}