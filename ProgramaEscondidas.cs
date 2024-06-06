/*
Autor: Tomas A. Bedoya
Fecha: 06-06-2024
Descripcion: los juguetes de andy estan jugando a las escondidas
             pide al usuario a las escondidas. pide al usuario las
             ubicaciones donde buscar y usa estructuras "si" para determinar
             si los juguetes estan en la ubicacion correcta o no.
             Reportar la cantidad total de juguetes que fueron encontrados
             al finalizar 4 rondas
             // variables
             // estructura repititiva o ciclica
             // preguntar ubicaciones con estructura if
             // acumular juguetes encontrados
             // mostrar juguetes encontrados 
*/
using System;
class Program {
  static void Main() {
     
        int juguetesEncontrados = 0;

        for (int ronda = 1; ronda <= 4; ronda++)
        {
            Console.WriteLine("Ronda de las escondidas");
            Console.WriteLine("opciones del lugar del escondite");
            Console.WriteLine("1. baño");
            Console.WriteLine("2. sala");
            Console.WriteLine("3. cocina");
            Console.WriteLine("4. habitacion");
            Console.WriteLine("Ingrese la ubicación donde buscar:");
        
            string ubicacion = Console.ReadLine();

            if (ubicacion == "baño" || ubicacion == "Baño")
            {
                Console.WriteLine("Encontraste a Buzz");
                juguetesEncontrados++;
            }
            else
            if (ubicacion == "sala" || ubicacion == "Sala")
            {
                Console.WriteLine("Encontraste a Woody");
                juguetesEncontrados++;
            }
            else
            if (ubicacion == "cocina" || ubicacion == "Cocina")
            {
                Console.WriteLine("Encontraste a Rex");
                juguetesEncontrados++;
            }
            else
            if (ubicacion == "habitacion" || ubicacion == "Habitacion")
            {
                Console.WriteLine("Encontraste a Jessie");
                juguetesEncontrados++;
            }
            else
            {
                Console.WriteLine("No encontraste ningún juguete en esa ubicación.");
            }
        }

        Console.WriteLine($"Total de juguetes encontrados: {juguetesEncontrados}");
    }
}
