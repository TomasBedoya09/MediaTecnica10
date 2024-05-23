/******************************************************************************
 Autor: Tomas A. Bedoya
 Fecha: 2024-05-23
 Descripcion:
         Un docente requiere de un sistema de notas
         donde recibe 4 calificaciones generando un promedio
         y luego determinando si gana o pierde.
         Si su promedio es menor a 3 pierde 
         Si es mayor gana 
         Si tiene un promedio mayor a 4.5 emitir mensaje:
         "Felicidades, te hasganado una beca"
         
*/
using System;

class ProgramaCalificaciones
{
    static void Main(string[] args)
    {
        // calcular el promedio
        double calificacion1, calificacion2, calificacion3, calificacion4;
        double promedio;

        // calcular notas
        Console.WriteLine("Ingrese la primera nota:");
        calificacion1 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la segunda nota:");
        calificacion2 = Int32.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese la tercera nota:");
        calificacion3 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la cuarta nota:");
        calificacion4 = Int32.Parse(Console.ReadLine());

       
        // promedio de las notas
        promedio = (calificacion1 + calificacion2 + calificacion3 + calificacion4) / 4;
        Console.WriteLine("el promedio es:" + promedio);
        if (promedio < 3)
            Console.WriteLine("Perdiste ");
        if (promedio > 4.5)
            Console.WriteLine("Felicidades, te has ganado una beca ");
        if (promedio >= 3 && promedio <= 4.5)
            Console.WriteLine("Ganaste ");
            Console.WriteLine("ganaste ");
           
    }
}