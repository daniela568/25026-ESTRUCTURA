using System;
using System.Collections.Generic;

namespace CongresoAuditorio
{
    public class Registro
    {
        private string nombre;
        private Auditorio auditorio;
        private Queue<Asistente> cola;

        public Registro(string nombre, Auditorio auditorio, Queue<Asistente> cola)
        {
            this.nombre = nombre;
            this.auditorio = auditorio;
            this.cola = cola;
        }

        public void ProcesarCola()
        {
            while (cola.Count > 0)
            {
                Asistente asistente = cola.Dequeue();
                int? asiento = auditorio.AsignarAsiento(asistente.Nombre);

                if (asiento != null)
                {
                    Console.WriteLine($"{nombre} asignó el asiento {asiento} a {asistente.Nombre}");
                }
                else
                {
                    Console.WriteLine($"{nombre} no pudo asignar asiento a {asistente.Nombre} (auditorio lleno)");
                }
            }
        }
    }
}
