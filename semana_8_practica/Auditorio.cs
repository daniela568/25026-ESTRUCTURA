using System;
using System.Collections.Generic;

namespace CongresoAuditorio
{
    public class Auditorio
    {
        private Stack<int> asientos; // pila de asientos
        private Dictionary<int, string> asignaciones;

        public Auditorio(int capacidad)
        {
            asientos = new Stack<int>();
            asignaciones = new Dictionary<int, string>();

            // Llenamos la pila con los asientos (último en entrar será el primero en asignarse)
            for (int i = capacidad; i >= 1; i--)
            {
                asientos.Push(i);
            }
        }

        public int? AsignarAsiento(string nombreAsistente)
        {
            if (asientos.Count > 0)
            {
                int asiento = asientos.Pop();
                asignaciones[asiento] = nombreAsistente;
                return asiento;
            }
            return null;
        }

        public void MostrarAsignaciones()
        {
            foreach (var asignacion in asignaciones)
            {
                Console.WriteLine($"Asiento {asignacion.Key}: {asignacion.Value}");
            }
        }
    }
}
