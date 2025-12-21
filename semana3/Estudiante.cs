using System;

// Aquí defino la clase Estudiante
public class Estudiante
{
    // Declaro los atributos privados
    private int id;
    private string nombres;
    private string apellidos;
    private string direccion;
    private string[] telefonos; // Realizo la declaración de un array para 3 teléfonos

      // Ahora prosigo con el constructor que inicializa los datos del estudiante
    public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
    {
        this.id = id;
        this.nombres = nombres;
        this.apellidos = apellidos;
        this.direccion = direccion;

      // Verifico que el array tenga exactamente 3 números
        if (telefonos.Length == 3)
        {
            this.telefonos = telefonos; // Si cumple, asigno el array a mi atributo
        }
        else
        {
            throw new ArgumentException("Debe ingresar exactamente 3 números de teléfono.");// Si no cumple, lanzo una excepción
        }
    }

// Realizo un método para mostrar la información del estudiante
    
    public void MostrarInformacion()
    {
        Console.WriteLine("ID: " + id); // Muestro el ID del estudiante
        Console.WriteLine("Nombres: " + nombres); // Muestro los nombres del estudiante
        Console.WriteLine("Apellidos: " + apellidos); // Muestro los apellidos del estudiante
        Console.WriteLine("Dirección: " + direccion);// Muestro la dirección del estudiant

        Console.WriteLine("Teléfonos:");
        for (int i = 0; i < telefonos.Length; i++) // Realizo un bucle para recorrer el array de teléfonos
        {
            Console.WriteLine("Teléfono " + (i + 1) + ": " + telefonos[i]);  // Muestro cada teléfono con su índice
        }
    }
}