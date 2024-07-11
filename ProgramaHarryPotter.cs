/******************************************************************************

Autor: Tomas A. Bedoya 

Fecha: 11-07-2024

Descripcion: Harry potter necesita un programa 
             en C# para listar sus hechizos.
             Completa el espacio en blanco
             para mostrar los hechizos en la consola:


*******************************************************************************/

using System;
using System.Threading;

class MiPrimerVector {
  static void Main() {
    
    string[] hechizos= {"expelliarmus", "espectro patronum", "wingardium leviosa"};
    
      Console.WriteLine("MMMMMMMMMMMMMMMMWWMMWWMMWWMMWWWNNWMMMMMM");
   Console.WriteLine("MMMMMMMMMMMMMMMMMWWWWWWWX0Oxdlc:xNMMMMMM");
   Console.WriteLine("MMMMMMMMMMMMMMMMXOxoooooollll,,xNMMMMMMM");
   Console.WriteLine("MMMMMMMMMMMMMMMKc:oddxO0KKKk:c0WMMMMMMMM");
   Console.WriteLine("MMMMMMMMMMMMWW0:cOK0KKKKKOo:dXWWMMMMMMMM");
   Console.WriteLine("MMMMMMMMMMWWW0:c0KKKKKKKk:lONWWMMMMMMMMM");
   Console.WriteLine("MMMMMMMMMWWWO:lOKKKKKK0o'.;dXMMMMMMMMMMM");
   Console.WriteLine("MMMMMMMMWWWO;lkk00KK00kd:'cKMMWMMMMMMMMM");
   Console.WriteLine("MMMMMMMWWWO;;:'l00KK000o;xNWMMMMMMMMMMMM");
   Console.WriteLine("MMMMMMMMWWXKO::OKKKKKkccONWWMMWMMMMMMMMM");
   Console.WriteLine("MMMMMMMMWWWK::OKKK0o:'.cxKWWMMMWWMMMMMMM");
   Console.WriteLine("MMMMMMMWWWK:,ox0KKk;..;xXWMMMMMWMMMMMMMM");
   Console.WriteLine("MMMMMMMMWNd:,'l00dclokNWWMMMMMMMMMMMMMMM");
   Console.WriteLine("MMMMMMMMWWk;:lco0WWWWWWMMMMMMMMMMMMMMMMM");
   Console.WriteLine("MMMMMMMMWk'.:dKWMMMMMMMMMMMMMMMMMMMMMMMM");
   Console.WriteLine("MMMMMMMWx',xXWWMMMMMMMMMMMMMMMMMMMMMMMMM");
   Console.WriteLine("MMMMMMWOokXWMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
   Console.WriteLine("MMMMMWNXNWWWMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
   Console.WriteLine("MMMMMMMMMWWMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
    Thread.Sleep(3000);
    Console.Clear();
    
    for (int i = 0; i <= 2; i++) {
        Console.WriteLine(hechizos[i]);
    }
  }
}