using System;
using System.Collections.Generic;

public class Traductor
{
    // Lista para almacenar las palabras
    private List<string> palabras = new List<string>();

    // Método para agregar palabras
    public void AgregarPalabra()
    {
        Console.WriteLine("Ingrese la palabra que desea agregar:");
        string nuevaPalabra = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(nuevaPalabra))
        {
            palabras.Add(nuevaPalabra);
            Console.WriteLine($"La palabra '{nuevaPalabra}' fue agregada correctamente.");
        }
        else
        {
            Console.WriteLine("No se ingresó ninguna palabra válida.");
        }
    }

    // Método para mostrar todas las palabras guardadas
    public void MostrarPalabras()
    {
        Console.WriteLine("Palabras almacenadas en el traductor:");
        if (palabras.Count == 0)
        {
            Console.WriteLine("No hay palabras registradas.");
        }
        else
        {
            foreach (string palabra in palabras)
            {
                Console.WriteLine($"- {palabra}");
            }
        }
    }
}
