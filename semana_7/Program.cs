using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Pedimos al usuario que ingrese la expresión matemática
        Console.WriteLine("Ingrese la expresión matemática:");
        string expresion = Console.ReadLine();

        // Llamamos a la función que verifica si está balanceada
        if (EstaBalanceada(expresion))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula NO balanceada.");
    }

    // Función que revisa si los paréntesis, llaves y corchetes están balanceados
    static bool EstaBalanceada(string expresion)
    {
        // Creamos una pila para guardar los símbolos de apertura
        Stack<char> pila = new Stack<char>();

        // Recorremos cada carácter de la expresión
        foreach (char c in expresion)
        {
            // Si encontramos un símbolo de apertura, lo guardamos en la pila
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            // Si encontramos un símbolo de cierre, verificamos con el último de la pila
            else if (c == ')' || c == '}' || c == ']')
            {
                // Si la pila está vacía, significa que no hay apertura correspondiente
                if (pila.Count == 0) return false;

                // Sacamos el último símbolo de apertura
                char ultimo = pila.Pop();

                // Comprobamos si coincide con el tipo correcto de cierre
                if ((c == ')' && ultimo != '(') ||
                    (c == '}' && ultimo != '{') ||
                    (c == ']' && ultimo != '['))
                {
                    return false; // No coincide, entonces está desbalanceada
                }
            }
        }

        // Al final, si la pila está vacía, todo estuvo balanceado
        return pila.Count == 0;
    }
}

