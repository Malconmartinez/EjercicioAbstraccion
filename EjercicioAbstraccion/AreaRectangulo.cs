using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public class AreaRectangulo : FormulaMatematia
    {
        private double ancho;
        private double alto;
        private double area;

        public AreaRectangulo(double ancho, double alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }
        public override void Calcular()
        {
            area = ancho * alto;
        }
        public override void Imprimir()
        {
            Console.WriteLine($"El area del rectangulo es {area} unidades cuadradas.");
        }
    }
}
