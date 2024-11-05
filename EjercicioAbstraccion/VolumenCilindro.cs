using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    internal class VolumenCilindro : FormulaMatematia
    {
        private double radio;
        private double altura;
        private double volumen;

        public VolumenCilindro(double radio, double altura)
        {
            this.radio = radio;
            this.altura = altura;
        }

        public override void Calcular()
        {
            volumen = Math.PI * Math.Pow(radio, 2) * altura;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El volumen del cilindro es: {volumen} unidades cúbicas.");
        }
    }
}
