using System;
using System.Collections.Generic;

namespace SEMANA_5
{
    public class Ejercicio4
    {
        public void PedirNumerosLoteria()
        {
            //  creo una lista para guardar los números ganadores
            List<int> numerosGanadores = new List<int>();

            // pregunto al usuario cuántos números quiere ingresar
            Console.Write("¿Cuántos números ganadores quieres ingresar? ");
            int cantidad = int.Parse(Console.ReadLine());

            // pido los números uno por uno
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingresa el número ganador " + (i + 1) + ": ");
                int numero = int.Parse(Console.ReadLine());
                numerosGanadores.Add(numero);
            }

            // ordeno la lista de menor a mayor
            numerosGanadores.Sort();

            // muestro los números ordenados
            Console.WriteLine("Números ganadores ordenados:");
            Console.WriteLine(string.Join(", ", numerosGanadores));
        }
    }
}
