using System;
using SEMANA_5;

class Program
{
    static void Main(string[] args)
    {
        // Ejercicio 1
        Ejercicio1 e1 = new Ejercicio1();
        e1.MostrarAsignaturas();

        Console.WriteLine();

        // Ejercicio 2
        Ejercicio2 e2 = new Ejercicio2();
        e2.MostrarAsignaturasConMensaje();

        Console.WriteLine();

        // Ejercicio 3
        Ejercicio3 e3 = new Ejercicio3();
        e3.MostrarNumerosInversos();

        Console.WriteLine();

        // Ejercicio 4
        Ejercicio4 e4 = new Ejercicio4();
        e4.PedirNumerosLoteria();

        Console.WriteLine();

        // Ejercicio 5
        Ejercicio5 e5 = new Ejercicio5();
        e5.PedirPalabra();
        e5.VerificarPalindromo();
    }
}

