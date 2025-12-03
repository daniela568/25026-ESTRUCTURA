using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear un círculo con radio 5
        Circulo c = new Circulo(5);
        Console.WriteLine("Área del círculo: " + c.CalcularArea());
        Console.WriteLine("Perímetro del círculo: " + c.CalcularPerimetro());

        // Crear un rectángulo con base 10 y altura 4
        Rectangulo r = new Rectangulo(10, 4);
        Console.WriteLine("Área del rectángulo: " + r.CalcularArea());
        Console.WriteLine("Perímetro del rectángulo: " + r.CalcularPerimetro());
    }
}