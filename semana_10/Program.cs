using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //  creo el conjunto principal de 500 ciudadanos ficticios
        //  usao HashSet porque representa un conjunto matemático y evita duplicados
        var ciudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add("Ciudadano " + i);
        }

        //  genero el conjunto de 75 ciudadanos vacunados con Pfizer
        // Tomo los primeros 75 ciudadanos para simplificar
        var vacunadosPfizer = new HashSet<string>();
        for (int i = 1; i <= 75; i++)
        {
            vacunadosPfizer.Add("Ciudadano " + i);
        }

        //  creo el conjunto de 75 ciudadanos vacunados con astrazeneca
        // para diferenciarlos, selecciono del 76 al 150
        var vacunadosAstraZeneca = new HashSet<string>();
        for (int i = 76; i <= 150; i++)
        {
            vacunadosAstraZeneca.Add("Ciudadano " + i);
        }

        //  Operaciones de teoría de conjuntos 
        // plico las operaciones matemáticas para obtener los listados solicitados

        // Obtengo los ciudadanos que NO se han vacunado
      
        var noVacunados = ciudadanos.Except(vacunadosPfizer.Union(vacunadosAstraZeneca));

        // obtengo los ciudadanos que recibieron ambas dosis 
        // Uso intersect para quedarme con los que están en ambos conjuntos
        var ambasDosis = vacunadosPfizer.Intersect(vacunadosAstraZeneca);

        // obtengo los ciudadanos que solo recibieron Pfizer
        // lico except para quitar los que también están en astrazeneca
        var soloPfizer = vacunadosPfizer.Except(vacunadosAstraZeneca);

        // obtengo los ciudadanos que solo recibieron astrazeneca
        // aplico except para quitar los que también están en ofizer
        var soloAstraZeneca = vacunadosAstraZeneca.Except(vacunadosPfizer);

        // Amuestro los conteos de cada grupo para verificar que todo funciona
        Console.WriteLine("Ciudadanos NO vacunados: " + noVacunados.Count());
        Console.WriteLine("Ciudadanos con ambas dosis: " + ambasDosis.Count());
        Console.WriteLine("Ciudadanos SOLO Pfizer: " + soloPfizer.Count());
        Console.WriteLine("Ciudadanos SOLO AstraZeneca: " + soloAstraZeneca.Count());

        // Finalmente, imprimo algunos ejemplos de ciudadanos no vacunados
     
        Console.WriteLine("\nEjemplo de ciudadanos no vacunados:");
        foreach (var c in noVacunados.Take(10))
        {
            Console.WriteLine(c);
        }
    }
}

