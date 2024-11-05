using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public class conversionKgALibras : FormulaMatematia
    {
        private double kilogramos;
        private double libras;

        public conversionKgALibras(double kilogramos)
        {
            this.kilogramos = kilogramos;
        }

        public override void Calcular()
        {
            libras = kilogramos * 2.20462;
        }
        public override void Imprimir()
        {
            Console.WriteLine($"{kilogramos} kg es igual a {libras} libras.");
        }
    }
}
