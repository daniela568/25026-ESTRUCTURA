using System; // Importo funcionalidades básicas de C#.

namespace AgendaTelefonica 
{
    class Program // Creo la clase principal Program.
    {
        static void Main(string[] args) // Defino el método Main, punto de entrada del programa.
        {
            Agenda agenda = new Agenda(); // Creo una nueva instancia de Agenda.
            int opcion; // Declaro la variable para guardar la opción del menú.

            do // Inicio un ciclo para mostrar el menú repetidamente.
            {
                Console.WriteLine("\n--- MENÚ AGENDA ---"); // Muestro el título del menú.
                Console.WriteLine("1. Agregar contacto"); // Muestro la opción para agregar.
                Console.WriteLine("2. Eliminar contacto"); // Muestro la opción para eliminar.
                Console.WriteLine("3. Buscar contacto"); // Muestro la opción para buscar.
                Console.WriteLine("4. Listar contactos"); // Muestro la opción para listar.
                Console.WriteLine("5. Salir"); // Muestro la opción para salir.
                Console.Write("Seleccione una opción: "); // Pido al usuario que ingrese una opción.
                opcion = int.Parse(Console.ReadLine()); // Leo la opción ingresada y la convierto a número.

                switch (opcion) // Evalúo la opción seleccionada.
                {
                    case 1: // Opción para agregar contacto.
                        Console.Write("Nombre: "); // Pido el nombre.
                        string nombre = Console.ReadLine(); // Leo el nombre.
                        Console.Write("Teléfono: "); // Pido el teléfono.
                        string telefono = Console.ReadLine(); // Leo el teléfono.
                        Console.Write("Email: "); // Pido el email.
                        string email = Console.ReadLine(); // Leo el email.
                        agenda.AgregarContacto(new Contacto(nombre, telefono, email)); // Creo un nuevo contacto y lo agrego a la agenda.
                        break;

                    case 2: // Opción para eliminar contacto.
                        Console.Write("Ingrese el nombre a eliminar: "); // Pido el nombre del contacto a eliminar.
                        string nombreEliminar = Console.ReadLine(); // Leo el nombre.
                        agenda.EliminarContacto(nombreEliminar); // Llamo al método para eliminarlo.
                        break;

                    case 3: // Opción para buscar contacto.
                        Console.Write("Ingrese el nombre a buscar: "); // Pido el nombre del contacto a buscar.
                        string nombreBuscar = Console.ReadLine(); // Leo el nombre.
                        agenda.BuscarContacto(nombreBuscar); // Llamo al método para buscarlo.
                        break;

                    case 4: // Opción para listar contactos.
                        agenda.ListarContactos(); // Muestro todos los contactos.
                        break;
                }

            } while (opcion != 5); // Repito el menú mientras la opción no sea salir.

            Console.WriteLine(" Gracias por usar la Agenda Telefónica."); // Muestro un mensaje de despedida.
        }
    }
}
