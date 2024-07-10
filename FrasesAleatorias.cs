/*
Autor: Tomas A. Bedoya 
Fecha:10/07/2024
Descripcion: Un cliente solicita una mini app en consola que imprima frases
             de forma aleatoria cada que es ejecutado.
*/
using System;
class MiSegundoVector{
  static void Main() {
    string[] frases ={
       "Nunca sabras lo que puedes hacer si no lo intentas",
       "Dejar ir tambien es amar",
       "Nunca digas nunca",
       "Perdonar es de valientes"
    };
    
    // aleatorio
    Random aleatorio = new Random();
    int posicion = aleatorio.Next(0,3);
    
    // imprimir frase aleatoria 
    Console.WriteLine(frases[posicion]);
        }
     }