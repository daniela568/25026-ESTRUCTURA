using System;
using System.Collections.Generic;

class ProgramaPremiacion
{
    static void Main()
    {
        // Diccionario: disciplina -> conjunto de deportistas
        Dictionary<string, HashSet<string>> disciplinas = new Dictionary<string, HashSet<string>>();

        // Diccionario: disciplina -> ganador
        Dictionary<string, string> ganadores = new Dictionary<string, string>();

        Console.WriteLine("=== Aplicación de Premiación Deportiva ===");

        // --- Ingreso de disciplinas y deportistas ---
        Console.Write("¿Cuántas disciplinas deseas registrar? ");
        int cantidadDisciplinas = int.Parse(Console.ReadLine());

        for (int i = 0; i < cantidadDisciplinas; i++)
        {
            Console.WriteLine($"\nDisciplina #{i + 1}: ");
            Console.Write("Nombre de la disciplina: ");
            string nombreDisciplina = Console.ReadLine();

            // Crear conjunto de deportistas
            HashSet<string> deportistas = new HashSet<string>();

            Console.Write($"¿Cuántos deportistas participan en {nombreDisciplina}? ");
            int cantidadDeportistas = int.Parse(Console.ReadLine());

            for (int j = 0; j < cantidadDeportistas; j++)
            {
                Console.Write($"Nombre del deportista #{j + 1}: ");
                string nombreDeportista = Console.ReadLine();
                deportistas.Add(nombreDeportista); // HashSet evita duplicados
            }

            // Guardar disciplina y deportistas
            disciplinas[nombreDisciplina] = deportistas;

            // Registrar ganador
            Console.Write($"¿Quién ganó en {nombreDisciplina}? ");
            string ganador = Console.ReadLine();
            ganadores[nombreDisciplina] = ganador;
        }

        // --- Reportería ---
        Console.WriteLine("\n=== Reporte Final ===");
        foreach (var disciplina in disciplinas)
        {
            Console.WriteLine($"\nDisciplina: {disciplina.Key}");
            Console.WriteLine("Participantes:");
            foreach (var deportista in disciplina.Value)
            {
                Console.WriteLine($" - {deportista}");
            }

            if (ganadores.ContainsKey(disciplina.Key))
            {
                Console.WriteLine($"Ganador: {ganadores[disciplina.Key]}");
            }
        }

        // --- Consulta específica ---
        Console.WriteLine("\nConsulta rápida: escribe el nombre de una disciplina para ver su ganador");
        string consulta = Console.ReadLine();

        if (ganadores.ContainsKey(consulta))
        {
            Console.WriteLine($"Ganador en {consulta}: {ganadores[consulta]}");
        }
        else
        {
            Console.WriteLine("No se encontró esa disciplina.");
        }
    }
}
