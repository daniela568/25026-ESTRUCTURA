using System;

public class ArbolBST
{
    public Nodo Raiz;

    public void Insertar(int valor)
    {
        Raiz = InsertarRec(Raiz, valor);
    }

    private Nodo InsertarRec(Nodo nodo, int valor)
    {
        if (nodo == null) return new Nodo(valor);

        if (valor < nodo.Valor)
            nodo.Izquierdo = InsertarRec(nodo.Izquierdo, valor);
        else if (valor > nodo.Valor)
            nodo.Derecho = InsertarRec(nodo.Derecho, valor);

        return nodo;
    }

    public bool Buscar(int valor)
    {
        return BuscarRec(Raiz, valor);
    }

    private bool BuscarRec(Nodo nodo, int valor)
    {
        if (nodo == null) return false;
        if (valor == nodo.Valor) return true;
        if (valor < nodo.Valor) return BuscarRec(nodo.Izquierdo, valor);
        else return BuscarRec(nodo.Derecho, valor);
    }

    public void Eliminar(int valor)
    {
        Raiz = EliminarRec(Raiz, valor);
    }

    private Nodo EliminarRec(Nodo nodo, int valor)
    {
        if (nodo == null) return nodo;

        if (valor < nodo.Valor)
            nodo.Izquierdo = EliminarRec(nodo.Izquierdo, valor);
        else if (valor > nodo.Valor)
            nodo.Derecho = EliminarRec(nodo.Derecho, valor);
        else
        {
            if (nodo.Izquierdo == null) return nodo.Derecho;
            else if (nodo.Derecho == null) return nodo.Izquierdo;

            nodo.Valor = Minimo(nodo.Derecho);
            nodo.Derecho = EliminarRec(nodo.Derecho, nodo.Valor);
        }
        return nodo;
    }

    public void Preorden(Nodo nodo)
    {
        if (nodo != null)
        {
            Console.Write(nodo.Valor + " ");
            Preorden(nodo.Izquierdo);
            Preorden(nodo.Derecho);
        }
    }

    public void Inorden(Nodo nodo)
    {
        if (nodo != null)
        {
            Inorden(nodo.Izquierdo);
            Console.Write(nodo.Valor + " ");
            Inorden(nodo.Derecho);
        }
    }

    public void Postorden(Nodo nodo)
    {
        if (nodo != null)
        {
            Postorden(nodo.Izquierdo);
            Postorden(nodo.Derecho);
            Console.Write(nodo.Valor + " ");
        }
    }

    public int Minimo(Nodo nodo)
    {
        while (nodo.Izquierdo != null)
            nodo = nodo.Izquierdo;
        return nodo.Valor;
    }

    public int Maximo(Nodo nodo)
    {
        while (nodo.Derecho != null)
            nodo = nodo.Derecho;
        return nodo.Valor;
    }

    public int Altura(Nodo nodo)
    {
        if (nodo == null) return 0;
        int izq = Altura(nodo.Izquierdo);
        int der = Altura(nodo.Derecho);
        return Math.Max(izq, der) + 1;
    }

    public void Limpiar()
    {
        Raiz = null;
    }
}
