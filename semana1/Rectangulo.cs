// Esta clase representa un rectángulo. 
    public class Rectangulo
    {
        private double baseRect;   // Variable privada para la base
        private double altura;     // Variable privada para la altura

        public Rectangulo(double baseRect, double altura)  // En este constructor inicializo la base y la altura 
        {
            this.baseRect = baseRect;
            this.altura = altura;
        }

          // Con este método calculo el área multiplicando base por altura.
        public double CalcularArea()
        {
            return baseRect * altura;
        }

// Aquí calculo el perímetro sumando dos veces la base y dos veces la altura.
        public double CalcularPerimetro()
        {
            return 2 * (baseRect + altura);
        }
    }
