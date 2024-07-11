/******************************************************************************

Autor: Tomas A. Bedoya

Fecha: 11/07/2024

Descripción:    Metro Aventura
Un juego de recorrido basado en el Metro de Medellín, 
donde el jugador debe visitar diferentes estaciones 
en un orden específico.
Uso de arreglos: Se utiliza un arreglo unidimensional 
para representar las estaciones del metro y otro para 
el orden de visita.
Conceptos reforzados: Declaración de arreglos, acceso 
a elementos, búsqueda en arreglos, comparación de valores.
Elementos culturales: Incorpora el sistema de Metro de 
Medellín y lugares emblemáticos de la ciudad como el 
Parque Explora, el Jardín Botánico y el Parque Arví.


*******************************************************************************/

using System;
using System.Threading;

class MetroAventura {
    static void Main() {
        
        // variables
        string[] estacionesMetro = {
            "Parque Berrio", 
            "Universidad",
            "Acevedo",
            "Arvi",
            "Niquia",
            "Bello"}; 
        
        string[] estacionesOrdenVisita = {
            "Universidad",
            "Arvi"};
        
        string[] jugador = new string[2]; 
    
        // pantalla bienvenida del juego
        Console.WriteLine("0l:cccccccccccccccccccccccccccccccccclxK");
        Console.WriteLine("o.*,**..****************......**.....**o");
        Console.WriteLine("l*xKOxoc;,*****************************o");
        Console.WriteLine("l*xNWMWNX0kdl:,**.................****,o");
        Console.WriteLine("l.cxk0KXNWWWWX0kdoc;,*............****,o");
        Console.WriteLine("l..*,;:loxO0KXXNNNX0Okxoc:,.....*******o");
        Console.WriteLine("l........*,;:ldxO0XXXXXXK0kc*.*********o");
        Console.WriteLine("l............*cdOKXXXXXKK0Ol*.******..*o");
        Console.WriteLine("l........;oxOKXNNNXK00Okdl:*..........*o");
        Console.WriteLine("l ......,kWWWWWNNKOdlc,*...............o");
        Console.WriteLine("l .......lO0KXNNNNX0Oxoc;,.............l");
        Console.WriteLine("l  .......*,:ldkO0XXXXXKKOx:...........l");
        Console.WriteLine("l  .... .. ..*:oO0XXXXXKK0Oc...........l");
        Console.WriteLine("l    ...,codOKXNNNXK00Okdo:*...........l");
        Console.WriteLine("l..;cdkKXWWWNXK0Okdlc:,*...............l");
        Console.WriteLine("c*xNWMWNXK0Oxoc;,*....  ...............l");
        Console.WriteLine("c*kXK0kdl:;*...  ......................l");
        Console.WriteLine("l           METRO DE MEDELLIN          l");
        Console.WriteLine("Kdc:;;;::::ccccccccccccccccccccccccccco0");
        Console.WriteLine("WWNXXXXNNNWWWWWWWWWWWWWWWWWWWWWWWWWWWWWM");
        Thread.Sleep(3000);
        Console.Clear();
        
        // desarrollo del juego
        Console.WriteLine("MENU AVENTURA EN METRO DE MEDELLIN");
        Console.WriteLine("1. Jugar");
        Console.WriteLine("2. Salir");
        Console.Write("Escribir el número de la opción: ");
        int opcionElegida = Int32.Parse(Console.ReadLine());
        if (opcionElegida == 1){
            // muestran las estaciones de destino
            Console.WriteLine("Elegir entre las opciones siguientes:");
            for (int i = 0; i < 6; i++) 
            {
                Console.WriteLine( estacionesMetro[i] );
            }
            
            // solicita al jugador las estaciones deseadas (2)
            Console.WriteLine("Escribir la ruta deseada, sólo dos estaciones");
            
            for (int i = 0; i < 2; i++) 
            {
                Console.Write("Estación " + (i+1) + ":");
                jugador[i] = Console.ReadLine();
            }
            
            // validar si cumple con el orden especificado
            bool haGanado = true;
            for (int i = 0; i < 2; i++) 
            {
                if (estacionesOrdenVisita[i] != jugador[i]) {
                    haGanado = false;
                }
            }
            
            // mostrar resultado
            if (haGanado){
                Console.WriteLine("Has ganado");
            }
            else{
                Console.WriteLine("Has perdido");
            }
        }
        if (opcionElegida == 2){
            Console.WriteLine("Saliendo del programa...");
        }
    }
}