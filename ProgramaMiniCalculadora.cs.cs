/******************************************************************************

Autor: Tomas A. Bedoya
Fecha: 29-05-24
 App con Menu
 *******
 Se solicita crear una minicalculadora que realice:
-Suma
-Resta
-Multiplicacion
-Divicion
Debe terminar la ejecucion al usuario elegir opcion "Salir"
*******************************************************************************/
using System;
using System.Threading;
class Program { 
  static void Main(string[] args) {
  // 1 Pantalla bienvenida (imagen ASCII)
Console.WriteLine("                                     __  ");
Console.WriteLine("           _             __  __     / /  ");
Console.WriteLine("         _| |_   _____   | ||  |   / /   ");
Console.WriteLine("        |_   _| |_____|   | . |   / /    ");
Console.WriteLine("          |_|            |_| |_| /_/     ");
Console.WriteLine("  Bienvenido a la MiniCalculadora");
Thread.Sleep(3000); // 3 segundos = 3000 milisegundos 
Console.Clear();
  // 2 Mostrar menu de opcioneseleccionar la opcion deseada")
Console.WriteLine("Menú de opciones");
    Console.WriteLine("Seleccionar la opción deseada:");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicación");
    Console.WriteLine("4. Divisón");
    Console.WriteLine("5. Salir");
  // 3 Capturar opcion elegida por usuario 
  Console.Write("Digitar numero deseado: ");
  int opcion = Int32.Parse(Console.ReadLine());
  
  if (opcion==5){
      goto Salir;
  }
  
  // 3.5 capturar los numeros elegidos por el usuario
  Console.Write("\nDigitar numero 1: ");
  int numero1 = Int32.Parse(Console.ReadLine());
  Console.Write("\nDigitar numero 2: ");
  int numero2 = Int32.Parse(Console.ReadLine());
  
  // 4 Validar la opcion elegida
  if( opcion == 1){
        Console.WriteLine("La suma es: " + (numero1+numero2));
    }
    
    if( opcion == 2){
        Console.WriteLine("La resta es: " + (numero1-numero2));
    }
    
    if( opcion == 3){
        Console.WriteLine("La multiplicación es: " + (numero1*numero2));
    }
    
    if( opcion == 4){
        if ( numero1 != 0 && numero2 !=0){
            Console.WriteLine("La división es: " + (numero1/numero2));    
        }
        else{
            Console.WriteLine("No se puede dividir por cero.");    
        }
    }

       // 5 Mostrar resultado o finalizar ejecución
    Salir:
        Console.WriteLine("Saliendo del programa...");
    
    
    }
}