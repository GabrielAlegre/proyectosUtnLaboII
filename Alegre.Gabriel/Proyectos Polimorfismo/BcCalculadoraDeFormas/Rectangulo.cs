using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcCalculadoraDeFormas
{
    public class Rectangulo : Figura
    {
        private double lado;
        private double altura;

        public Rectangulo(double lado, double altura)
        {
            this.lado = lado;
            this.altura = altura;
        }

        public override string Dibujar()
        {
            return "Dibujando Rectángulo...";
        }

        public override double CalcularPerimetro()
        {
            return 2 * (lado + altura);

        }

        public override double CalcularSuperficie()
        {
            return lado * altura;
        }
    }
}
