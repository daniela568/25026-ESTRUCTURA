using System;  


class Nodo
{
    public int dato;        // Aquí guardamos el valor del nodo
    public Nodo siguiente;  // Apunta al siguiente nodo en la lista
}

class ListaEnlazada
{
    public Nodo cabeza; // Primer nodo de la lista (inicio)

    // Agregar nodo al inicio
    public void Agregar(int valor)
    {
        Nodo nuevo = new Nodo();       // Creamos un nuevo nodo
        nuevo.dato = valor;            // Guardamos el valor dentro del nodo
        nuevo.siguiente = cabeza;      // El nuevo nodo apunta al que era la cabeza
        cabeza = nuevo;                // Ahora el nuevo nodo pasa a ser la cabeza
    }

    // Mostrar lista
    public void Mostrar()
    {
        Nodo actual = cabeza;          // Empezamos desde la cabeza
        while (actual != null)         // Mientras haya nodos
        {
            Console.Write(actual.dato + " "); // Mostramos el valor del nodo
            actual = actual.siguiente;        // Avanzamos al siguiente nodo
        }
        Console.WriteLine();            // Salto de línea al final
    }

    // Eliminar nodos fuera del rango
    public void EliminarFueraDeRango(int minimo, int maximo)
    {
        // Revisar desde la cabeza y eliminar si está fuera del rango
        while (cabeza != null && (cabeza.dato < minimo || cabeza.dato > maximo))
        {
            cabeza = cabeza.siguiente; // Saltamos al siguiente nodo
        }

        Nodo actual = cabeza;          // Empezamos desde la cabeza
        while (actual != null && actual.siguiente != null)
        {
            // Si el siguiente nodo está fuera del rango
            if (actual.siguiente.dato < minimo || actual.siguiente.dato > maximo)
            {
                // Lo eliminamos "saltando" ese nodo
                actual.siguiente = actual.siguiente.siguiente;
            }
            else
            {
                // Si está dentro del rango, avanzamos
                actual = actual.siguiente;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Random rnd = new Random();          // Generador de números aleatorios
        ListaEnlazada lista = new ListaEnlazada(); // Creamos la lista vacía

        // Crear lista con 50 números aleatorios
        for (int i = 0; i < 50; i++)
        {
            int numero = rnd.Next(1, 1000); // Genera un número entre 1 y 999
            lista.Agregar(numero);          // Lo agrega a la lista
        }

        Console.WriteLine("Lista original:");
        lista.Mostrar();                    // Muestra todos los números

        // Leer rango desde teclado
        Console.Write("Ingrese el valor minimo: ");
        int minimo = int.Parse(Console.ReadLine()); // Usuario escribe el mínimo

        Console.Write("Ingrese el valor maximo: ");
        int maximo = int.Parse(Console.ReadLine()); // Usuario escribe el máximo

        // Eliminar nodos fuera del rango
        lista.EliminarFueraDeRango(minimo, maximo);

        Console.WriteLine("Lista filtrada:");
        lista.Mostrar();                    // Muestra solo los números dentro del rango
    }
}
