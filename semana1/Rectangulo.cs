// Clase Rectangulo: encapsula base y altura como datos primitivos
    public class Rectangulo
    {
        private double baseRect;   // Variable privada para la base
        private double altura;     // Variable privada para la altura

        public Rectangulo(double baseRect, double altura)
        {
            this.baseRect = baseRect;
            this.altura = altura;
        }

        // CalcularArea devuelve un valor double, calcula el área del rectángulo
        public double CalcularArea()
        {
            return baseRect * altura;
        }

        // CalcularPerimetro devuelve un valor double, calcula el perímetro del rectángulo
        public double CalcularPerimetro()
        {
            return 2 * (baseRect + altura);
        }
    }
