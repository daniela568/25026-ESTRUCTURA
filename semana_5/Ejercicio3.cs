using System;
using System.Collections.Generic;

namespace SEMANA_5
{
    public class Ejercicio3
    {
        public void MostrarNumerosInversos()
        {
            //  creo una lista para guardar los números del 1 al 10
            List<int> numeros = new List<int>();

            // agrego los números del 1 al 10 a la lista
            for (int i = 1; i <= 10; i++)
            {
                numeros.Add(i);
            }

            //  invierto la lista
            numeros.Reverse();

            //  muestro los números separados por comas
            Console.WriteLine("Números en orden inverso:");
            Console.WriteLine(string.Join(", ", numeros));
        }
    }
}
