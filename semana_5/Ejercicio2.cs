using System;
using System.Collections.Generic;


namespace SEMANA_5
{
    public class Ejercicio2
    {
        private List<string> asignaturas;

        public Ejercicio2()
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

        public void MostrarAsignaturasConMensaje()
        {
            for (int i = 0; i < asignaturas.Count; i++)
            {
                Console.WriteLine("Yo estudio " + asignaturas[i]);
            }
        }
    }
}
