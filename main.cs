using System;

class Program {
  public static void Main (string[] args) {
    string entrada;
    double fahren, celsius; 
  Console.WriteLine ("Escreva a Temperatura em Fahrenheit: ");
  entrada = Console.ReadLine();
  fahren = Double.Parse(entrada);
  celsius = (fahren - 32) * (5.0/9.0);
    Console.WriteLine ("A temperatura em Graus Celsius é de: " + celsius);
  }
}