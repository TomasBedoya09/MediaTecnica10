/******************************************************************************
Autor:Tomas A. Bedoya
Fecha:2024-05-22
Descripcion: Programa con decisiones para 
determinar el sexo 

                    programa con decisiones
            
*******************************************************************************/

using System;
class Programa {
    static void Main(){
    // variables 
    bool sexoMasculino;
    // capturar informacion del usuario
    Console.Write("Digite true si es hombre: ");
    sexoMasculino = Convert.ToBoolean(Console.ReadLine());
    // validacion 
    if (sexoMasculino == true)
    { 
     Console.WriteLine("Felicidades , es hombre"); 
    }
    else{
        Console.WriteLine("Felicidades , es mujer");
    }
    Console.WriteLine("Finalizada la ejecucion");
  }
}