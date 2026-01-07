using System; // Importo funcionalidades básicas de C#.
using System.Collections.Generic; 

namespace AgendaTelefonica 
{
    public class Agenda // Creo la clase Agenda que maneja la lista de contactos.
    {
        private List<Contacto> contactos; // Declaro una lista privada que almacena los contactos.

        public Agenda() // Creo el constructor de la clase Agenda.
        {
            contactos = new List<Contacto>(); // Inicializo la lista de contactos vacía.
        }

        public void AgregarContacto(Contacto c) // Defino el método para agregar un contacto.
        {
            contactos.Add(c); // Agrego el contacto recibido a la lista.
            Console.WriteLine(" Contacto agregado correctamente."); // Muestro un mensaje de confirmación.
        }

        public void EliminarContacto(string nombre) // Defino el método para eliminar un contacto por nombre.
        {
            Contacto c = contactos.Find(x => x.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)); // Busco el contacto en la lista.
            if (c != null) // Verifico si lo encontré.
            {
                contactos.Remove(c); // Elimino el contacto de la lista.
                Console.WriteLine(" Contacto eliminado."); // Muestro un mensaje de confirmación.
            }
            else
            {
                Console.WriteLine(" Contacto no encontrado."); // Muestro un mensaje si no existe.
            }
        }

        public void BuscarContacto(string nombre) // Defino el método para buscar un contacto por nombre.
        {
            Contacto c = contactos.Find(x => x.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)); // Busco el contacto en la lista.
            if (c != null) // Verifico si lo encontré.
                Console.WriteLine(" Encontrado: " + c); // Muestro el contacto encontrado.
            else
                Console.WriteLine(" No existe ese contacto."); // Muestro un mensaje si no existe.
        }

        public void ListarContactos() // Defino el método para listar todos los contactos.
        {
            Console.WriteLine("\n Agenda Telefónica:"); // Muestro un título para la lista.
            foreach (var c in contactos) // Recorro cada contacto en la lista.
            {
                Console.WriteLine(c); // Muestro la información de cada contacto usando ToString().
            }
        }
    }
}
