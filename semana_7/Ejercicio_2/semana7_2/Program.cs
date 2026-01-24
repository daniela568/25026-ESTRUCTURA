using System;
using System.Collections.Generic;

class TorresDeHanoi
{
    static void Main()
    {
        // Número de discos
        int n = 3;

        // Creamos las tres pilas (torres)
        Stack<int> torreA = new Stack<int>();
        Stack<int> torreB = new Stack<int>();
        Stack<int> torreC = new Stack<int>();

        // Inicializamos la torre A con los discos (del más grande al más pequeño)
        for (int i = n; i >= 1; i--)
        {
            torreA.Push(i);
        }

        // Mostramos el estado inicial
        Console.WriteLine("Estado inicial:");
        MostrarTorres(torreA, torreB, torreC);

        // Llamamos a la función recursiva para resolver el problema
        Hanoi(n, torreA, torreB, torreC, "A", "B", "C");
    }

    // Función recursiva que mueve los discos
    static void Hanoi(int n, Stack<int> origen, Stack<int> auxiliar, Stack<int> destino,
                      string nombreOrigen, string nombreAuxiliar, string nombreDestino)
    {
        if (n == 1)
        {
            // Caso base: mover un solo disco
            destino.Push(origen.Pop());
            Console.WriteLine($"Mover disco de {nombreOrigen} a {nombreDestino}");
            MostrarTorres(origen, auxiliar, destino);
        }
        else
        {
            // Paso 1: mover n-1 discos de origen a auxiliar
            Hanoi(n - 1, origen, destino, auxiliar, nombreOrigen, nombreDestino, nombreAuxiliar);

            // Paso 2: mover el disco restante de origen a destino
            destino.Push(origen.Pop());
            Console.WriteLine($"Mover disco de {nombreOrigen} a {nombreDestino}");
            MostrarTorres(origen, auxiliar, destino);

            // Paso 3: mover los n-1 discos de auxiliar a destino
            Hanoi(n - 1, auxiliar, origen, destino, nombreAuxiliar, nombreOrigen, nombreDestino);
        }
    }

    // Función para mostrar el estado actual de las torres
    static void MostrarTorres(Stack<int> A, Stack<int> B, Stack<int> C)
    {
        Console.WriteLine($"Torre A: [{string.Join(",", A)}]");
        Console.WriteLine($"Torre B: [{string.Join(",", B)}]");
        Console.WriteLine($"Torre C: [{string.Join(",", C)}]");

    }
}
