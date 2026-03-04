using System;
using System.Collections.Generic;

public class Traductor
{
    // Se mantiene una lista privada para almacenar las palabras ingresadas
    private List<string> palabras = new List<string>();

    // Método para agregar palabras nuevas al traductor
    public void AgregarPalabra()
    {
        Console.WriteLine("Ingrese la palabra que desea agregar:");
        string nuevaPalabra = Console.ReadLine();

        // Se valida que la palabra no esté vacía antes de guardarla
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

    // Método para mostrar todas las palabras almacenadas
    public void MostrarPalabras()
    {
        Console.WriteLine("Palabras almacenadas en el traductor:");

        // Se verifica si la lista está vacía
        if (palabras.Count == 0)
        {
            Console.WriteLine("No hay palabras registradas.");
        }
        else
        {
            // Se recorre la lista y se imprime cada palabra
            foreach (string palabra in palabras)
            {
                Console.WriteLine($"- {palabra}");
            }
        }
    }
}
