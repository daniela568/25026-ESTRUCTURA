using System;

// Clase principal con el menú interactivo
class Program
{
    static void Main()
    {
        ArbolBST arbol = new ArbolBST(); // Creo el árbol
        int opcion;

        // Ciclo para mostrar el menú hasta que se elija salir
        do
        {
            Console.WriteLine("\n--- MENU BST ---");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Buscar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Mostrar Preorden");
            Console.WriteLine("5. Mostrar Inorden");
            Console.WriteLine("6. Mostrar Postorden");
            Console.WriteLine("7. Mostrar Minimo");
            Console.WriteLine("8. Mostrar Maximo");
            Console.WriteLine("9. Mostrar Altura");
            Console.WriteLine("10. Limpiar Arbol");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine()); // Leo la opción del usuario

            // Ejecuto la acción según la opción elegida
            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese valor: ");
                    int val = int.Parse(Console.ReadLine()); // Leo valor
                    arbol.Insertar(val);                     // Inserto en el árbol
                    break;
                case 2:
                    Console.Write("Ingrese valor a buscar: ");
                    val = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol.Buscar(val) ? "Encontrado" : "No encontrado");
                    break;
                case 3:
                    Console.Write("Ingrese valor a eliminar: ");
                    val = int.Parse(Console.ReadLine());
                    arbol.Eliminar(val);
                    break;
                case 4:
                    Console.Write("Preorden: ");
                    arbol.Preorden(arbol.Raiz);
                    Console.WriteLine();
                    break;
                case 5:
                    Console.Write("Inorden: ");
                    arbol.Inorden(arbol.Raiz);
                    Console.WriteLine();
                    break;
                case 6:
                    Console.Write("Postorden: ");
                    arbol.Postorden(arbol.Raiz);
                    Console.WriteLine();
                    break;
                case 7:
                    if (arbol.Raiz != null)
                        Console.WriteLine("Minimo: " + arbol.Minimo(arbol.Raiz));
                    else Console.WriteLine("Árbol vacío");
                    break;
                case 8:
                    if (arbol.Raiz != null)
                        Console.WriteLine("Maximo: " + arbol.Maximo(arbol.Raiz));
                    else Console.WriteLine("Árbol vacío");
                    break;
                case 9:
                    Console.WriteLine("Altura: " + arbol.Altura(arbol.Raiz));
                    break;
                case 10:
                    arbol.Limpiar();
                    Console.WriteLine("Árbol limpiado");
                    break;
            }
        } while (opcion != 0); // Repite hasta que se elija salir
    }
}
