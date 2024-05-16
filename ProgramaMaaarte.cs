/*******************************************************************************
autores: Tomas Bedoya 
Kevin Vera
fecha:16-05-2024
los Avengers necesitan un programa en C# para calcular la fuerza
necesaria para levantar un objeto en el planeta Marte. Completa el 
espacio en blanco para solicitar al usuario la masa del objeto a 
levantar:
Formula: fuerza = masa * gravedad 
*******************************************************************************/

using System;
class HelloWord {
    static void Main() {
    Console.WriteLine("ingrese la masa del objeto a levantar en kilogramos:");
     double masaObjeto = double.Parse(Console.ReadLine());
     double gravedad = 3.71;
     double fuerza = masaObjeto * gravedad;
     Console.WriteLine("La fuerza necesaria para levantar el objeto es de apreoximadamente" + fuerza + "Newtons");
     
}

}