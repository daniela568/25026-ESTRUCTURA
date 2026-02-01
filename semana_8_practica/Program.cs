using System;
using System.Collections.Generic;

namespace CongresoAuditorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear auditorio con 100 asientos
            Auditorio auditorio = new Auditorio(100);

            // Crear colas de asistentes
            Queue<Asistente> cola1 = new Queue<Asistente>();
            Queue<Asistente> cola2 = new Queue<Asistente>();

            // Simulamos 50 asistentes en cada cola
            for (int i = 1; i <= 50; i++)
            {
                cola1.Enqueue(new Asistente($"A1-{i}"));
                cola2.Enqueue(new Asistente($"A2-{i}"));
            }

            // Crear registradores
            Registro registro1 = new Registro("Registrador 1", auditorio, cola1);
            Registro registro2 = new Registro("Registrador 2", auditorio, cola2);

            // Procesar colas
            registro1.ProcesarCola();
            registro2.ProcesarCola();

            Console.WriteLine("\n--- Asignación finalizada ---");
            auditorio.MostrarAsignaciones();
        }
    }
}
