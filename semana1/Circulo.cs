using System;

// Clase Circulo: encapsula el radio como dato primitivo
public class Circulo
{
    private double radio; // Variable privada para almacenar el radio

    public Circulo(double radio) // En este constructor inicializo el radio cuando creo un objeto Circulo.
    {
        this.radio = radio;
    }

    //     // Con este método calculo  el área de un círculo
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    //  calculo la circunferencia del círculo
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}