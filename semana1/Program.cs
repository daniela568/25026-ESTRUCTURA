using System;

class Program
{
    static void Main(string[] args)
    {
        // Creo un círculo con radio 5
        Circulo c = new Circulo(5);
         // Muestro el área del círculo
        Console.WriteLine("Área del círculo: " + c.CalcularArea());
// Muestro el perímetro del círculo
        Console.WriteLine("Perímetro del círculo: " + c.CalcularPerimetro());

        // Creo un rectángulo con base 10 y altura 4
        Rectangulo r = new Rectangulo(10, 4);
       // Muestro el área del rectángulo
        Console.WriteLine("Área del rectángulo: " + r.CalcularArea());
        // Muestro el perímetro del rectángulo en consola.
        Console.WriteLine("Perímetro del rectángulo: " + r.CalcularPerimetro());
    }
}