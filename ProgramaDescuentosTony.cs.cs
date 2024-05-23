
/*
Autor: Tomas A. Bedoya
Fecha: 2024-05-23
Descripción: Tony Stark, Iron Man, quiere saber cuánto 
    dinero debe tener para comprar X tornillos a 300 c/u, 
    pero en la tienda le dan descuentos según cantidad 
    comprada. Crear un algoritmo que ayude 
    a calcular si compra:
    1 sin descuento, 
    5 descuento del 30%, 
    10 descuento del 50%, 
*/
using System;
class ProgramaDescuentos{
  static void Main() {
      // variables
      int cantidadTornillos;
      int valorTornillos = 300;
      
      // solicitar cantidad Tornillos a Tony Stark
      Console.WriteLine("Señor Tony Stark, ¿Cuántos tornillos desea?");
      Console.Write("Cantidad: ");
      cantidadTornillos = Int32.Parse(Console.ReadLine());
      
      int valorSinDescuento = cantidadTornillos * valorTornillos;       
      
      // validación
      
      //1 - 4 sin descuento, 
      if(cantidadTornillos<=4){
          Console.WriteLine("Señor Tony Stark, usted debe pagar: " + (valorSinDescuento) );
      }  
      
      // 5 - 9 descuento del 30%, 
      if(cantidadTornillos>=5){
          if(cantidadTornillos<=9){
            Console.WriteLine("Señor Tony Stark, usted tiene 30% y debe pagar: " + (valorSinDescuento * 0.70) );    
          }
          
      }
        
      //10 o más descuento del 50%, 
      if(cantidadTornillos>=10){
          Console.WriteLine("Señor Tony Stark, usted tiene 50% y debe pagar: " + (valorSinDescuento * 0.50) );
      } 
      
  }
}