/*
Autor: Tomas A. Bedoya
Fecha: 29-05-24
Descripcion: Ejercicio de estructura de decision multiple
Se desea un programa que ayude diciendo las preferencias segun el genero:
-Si es un hombre menor de edad sus preferencias son:
    Figuras de accion, Caricaturas, Series TV
- Si es un hombre mayor de edad sus preferencias son:
    cine, picnic y filantropía
- Si es una mujer menor de edad sus preferencias son:
    Muñecas, Maquillaje, Series TV
- Si es una mujer mayor de edad sus preferencias son:
    Maquillaje, Series TV, Cine, filantropía
    
*/

using System;
class  Program {
  static void Main() {

    Console.Write("escribir hombre o mujer: ");
    string genero =(Console.ReadLine());

    Console.Write("escribir edad en números: ");
    int edad = Int32.Parse(Console.ReadLine());

    // 3 Validar opción elegida
    if(genero == "hombre"){
        if ( edad < 18 )
        Console.WriteLine("sus preferencias son: Figuras de acción. caricaturas, series tv" );
    }

    if(genero == "hombre" ){
        if ( edad >= 18 )
        Console.WriteLine("sus preferencias son: cine, picnic y filantropía " );
    }

    if(genero == "mujer" ){
        if ( edad < 18 )
        Console.WriteLine("sus preferencias son: muñecas, maquillaje, serie tv ");
    }

    if(genero == "mujer" ){
        if ( edad >= 18 )
       Console.WriteLine("sua preferencias son:  maquillaje,series tv, cine, filantropía " );    
    }

    }
  }  