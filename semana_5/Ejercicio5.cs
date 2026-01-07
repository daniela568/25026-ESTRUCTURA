using System;

namespace SEMANA_5
{
    public class Ejercicio5
    {
        private string palabra;

        public void PedirPalabra()
        {
            // pido al usuario que escriba una palabra
            Console.Write("Escribe una palabra: ");
            palabra = Console.ReadLine();
        }

        public void VerificarPalindromo()
        {
            //  convierto la palabra en un arreglo de caracteres y la invierto
            char[] letras = palabra.ToCharArray();
            Array.Reverse(letras);
            string invertida = new string(letras);

            //  comparo la palabra original con la invertida
            if (palabra.Equals(invertida, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("La palabra es un palíndromo.");
            }
            else
            {
                Console.WriteLine("La palabra no es un palíndromo.");
            }
        }
    }
}
