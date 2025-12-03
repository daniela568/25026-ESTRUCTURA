using System;

// Clase Circulo: encapsula el radio como dato primitivo
public class Circulo
{
    private double radio; // Variable privada para almacenar el radio

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // CalcularArea devuelve un valor double, calcula el área de un círculo
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // CalcularPerimetro devuelve un valor double, calcula la circunferencia del círculo
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}