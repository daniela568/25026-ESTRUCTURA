using System; // Importo la librería básica de C# para funcionalidades generales.

namespace AgendaTelefonica 
{
    public class Contacto // Creo la clase Contacto que representa a cada persona en la agenda.
    {
        public string Nombre { get; set; } // Declaro la propiedad pública para guardar el nombre.
        public string Telefono { get; set; } // Declaro la propiedad pública para guardar el teléfono.
        public string Email { get; set; } // Declaro la propiedad pública para guardar el email.

        public Contacto(string nombre, string telefono, string email) // Creo el constructor para inicializar un contacto.
        {
            Nombre = nombre; // Asigno el valor recibido al atributo Nombre.
            Telefono = telefono; // Asigno el valor recibido al atributo Teléfono.
            Email = email; // Asigno el valor recibido al atributo Email.
        }

        public override string ToString() // Sobrescribo el método ToString para mostrar la información del contacto.
        {
            return $"Nombre: {Nombre}, Teléfono: {Telefono}, Email: {Email}"; // Devuelvo una cadena con los datos del contacto.
        }
    }
}
