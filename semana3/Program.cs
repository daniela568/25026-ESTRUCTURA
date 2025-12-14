using System;

class Program
{
    static void Main(string[] args) // Defino el método principal del programa
    {
        // Crear un array con 3 números de teléfono
        string[] telefonos = new string[3];
        telefonos[0] = "0991234567";
        telefonos[1] = "022345678";
        telefonos[2] = "0987654321";

   // Ahora prosigo creando un objeto Estudiante con datos de ejemplo
        Estudiante estudiante = new Estudiante(
            1,
            "Daniela",
            "Camacho",
            "Pichincha, Ecuador",
            telefonos // Paso el array de teléfonos
        );

   // Muestro un título para el registro
        Console.WriteLine("=== Registro del Estudiante ===");
        estudiante.MostrarInformacion(); // Finalmente llamo al método para mostrar toda la información
    }
}