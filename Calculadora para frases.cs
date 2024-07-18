/******************************************************************************

Autor: Tomas A.Bedoya 
Fecha:18/07/2024
Descripcion: 
      Calculadora para frases 
      que incluya un menu para ingresar a opcion 
      Debe de permitir ingresar la frase y luego calcular 
      cantidad de letras que tiene.
*******************************************************************************/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine();
        int cantidadLetras = frase.Length;
        Console.WriteLine($"La frase '{frase}' tiene {cantidadLetras} letras.");
    }
}