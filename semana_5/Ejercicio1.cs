using System;
using System.Collections.Generic;

namespace SEMANA_5
{
    public class Ejercicio1
    {
        private List<string> asignaturas;

        public Ejercicio1()
        {
            asignaturas = new List<string>
            {
                "Matemáticas",
                "Física",
                "Química",
                "Historia",
                "Lengua"
            };
        }

        public void MostrarAsignaturas()
        {
            Console.WriteLine("Asignaturas del curso:");
            for (int i = 0; i < asignaturas.Count; i++)
            {
                Console.WriteLine("- " + asignaturas[i]);
            }
        }
    }
}
