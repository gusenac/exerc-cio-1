using System;

class Program {
  public static void Main (string[] args) {
   
 string entrada;
    Double t, celsius; 
    
Console.WriteLine ("digite temperatura em fahrenheit");

entrada=Console.ReadLine();

t = Double.Parse(entrada);

celsius = (t-32)/1.8 ;

Console.WriteLine ( celsius); 

 
    
  }

}