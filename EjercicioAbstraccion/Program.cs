using System;
namespace EjercicioAbstraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Selecione una formula para calcular: ");
                Console.WriteLine("1. Area del Rectangulo ");
                Console.WriteLine("2. Conversión de Kilogramos a Libras");
                Console.WriteLine("3. Volumen de un Cilindro ");
                Console.WriteLine("4 Salir");

                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 4) break;
                FormulaMatematia formula   = null;
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el ancho del rectángulo: ");
                        double ancho = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el alto del rectángulo: ");
                        double alto = Convert.ToDouble(Console.ReadLine());
                        formula = new AreaRectangulo(ancho, alto);
                        break;
                    case 2:
                        Console.Write("Ingrese los kilogramos a convertir: ");
                        double kilogramos = Convert.ToDouble(Console.ReadLine());
                        formula = new conversionKgALibras(kilogramos);
                        break;
                    case 3:
                        Console.Write("Ingrese el radio del cilindro: ");
                        double radio = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la altura del cilindro: ");
                        double altura = Convert.ToDouble(Console.ReadLine());
                        formula = new VolumenCilindro(radio, altura);
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        continue;
                }
                formula.Calcular();
                formula.Imprimir();
            }
        }
    }
}