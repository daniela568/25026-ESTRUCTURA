using System;

class Program
{
    static void Main(string[] args)
    {
        // Se crea una instancia de la clase Traductor
        Traductor traductor = new Traductor();
        string opcion;

        // Se utiliza un ciclo para mostrar el menú hasta que el usuario decida salir
        do
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Mostrar palabras");
            Console.WriteLine("2. Agregar palabra");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");
            opcion = Console.ReadLine();

            // Se evalúa la opción ingresada
            if (opcion == "1")
            {
                traductor.MostrarPalabras();
            }
            else if (opcion == "2")
            {
                traductor.AgregarPalabra();
            }
            else if (opcion == "3")
            {
                Console.WriteLine("Saliendo del programa...");
            }
            else
            {
                Console.WriteLine("Opción no válida, intenta de nuevo.");
            }

        } while (opcion != "3"); // El ciclo termina cuando se elige salir
    }
}
