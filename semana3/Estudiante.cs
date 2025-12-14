using System;

// Clase que representa a un estudiante
public class Estudiante
{
    // Atributos privados
    private int id;
    private string nombres;
    private string apellidos;
    private string direccion;
    private string[] telefonos; // Array para almacenar 3 números de teléfono

    // Constructor: inicializa los datos del estudiante
    public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
    {
        this.id = id;
        this.nombres = nombres;
        this.apellidos = apellidos;
        this.direccion = direccion;

        // Validar que el array tenga exactamente 3 números
        if (telefonos.Length == 3)
        {
            this.telefonos = telefonos;
        }
        else
        {
            throw new ArgumentException("Debe ingresar exactamente 3 números de teléfono.");
        }
    }

    // Método para mostrar la información del estudiante
    public void MostrarInformacion()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Nombres: " + nombres);
        Console.WriteLine("Apellidos: " + apellidos);
        Console.WriteLine("Dirección: " + direccion);

        Console.WriteLine("Teléfonos:");
        for (int i = 0; i < telefonos.Length; i++)
        {
            Console.WriteLine("Teléfono " + (i + 1) + ": " + telefonos[i]);
        }
    }
}