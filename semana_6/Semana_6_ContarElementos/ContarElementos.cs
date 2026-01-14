using System;

class Nodo
{
    public int dato;        // valor del nodo
    public Nodo siguiente;  // referencia al siguiente nodo
}

class ListaEnlazada
{
    public Nodo cabeza; // primer nodo de la lista

    // Función para contar elementos
    public int ContarElementos()
    {
        int contador = 0;
        Nodo actual = cabeza;

        while (actual != null) // mientras haya nodos
        {
            contador = contador + 1;
            actual = actual.siguiente; // pasar al siguiente nodo
        }

        return contador;
    }
}

class Program
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();

        // Crear manualmente algunos nodos
        lista.cabeza = new Nodo();
        lista.cabeza.dato = 10;

        lista.cabeza.siguiente = new Nodo();
        lista.cabeza.siguiente.dato = 20;

        lista.cabeza.siguiente.siguiente = new Nodo();
        lista.cabeza.siguiente.siguiente.dato = 30;

        Console.WriteLine("Numero de elementos en la lista: " + lista.ContarElementos());
    }
}
