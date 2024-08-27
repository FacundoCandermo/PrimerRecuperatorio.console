namespace Punto2
{
    internal class Program
    {
        struct Paralelogramo
        {
            public double Base;
            public double Altura;
            public double Lado;
            public double CalcularPerimetro()
            {
                return 2 * (Base + Lado);
            }
            public double CalcularSuperficie()
            {
                return Base * Altura;
            }
        }
        static void Main()
        {
            Paralelogramo[] paralelogramos = new Paralelogramo[10];
            int contador = 0;
            double sumaSuperficies = 0;
            while (true)
            {
                Paralelogramo p;
                Console.Write("Introduce la Base: ");
                if (!double.TryParse(Console.ReadLine(), out p.Base) || p.Base <= 0)
                {
                    Console.WriteLine("Error: Valor inválido. Debe ser un número positivo.");
                    continue;
                }
                Console.Write("Introduce la Altura: ");
                if (!double.TryParse(Console.ReadLine(), out p.Altura) || p.Altura <= 0)
                {
                    Console.WriteLine("Error: Valor inválido. Debe ser un número positivo.");
                    continue;
                }
                Console.Write("Introduce el Lado: ");
                if (!double.TryParse(Console.ReadLine(), out p.Lado) || p.Lado <= 0)
                {
                    Console.WriteLine("Error: Valor inválido. Debe ser un número positivo.");
                    continue;
                }
                paralelogramos[contador] = p;
                sumaSuperficies += p.CalcularSuperficie();
                contador++;
                Console.WriteLine($"Paralelogramo {contador}:");
                Console.WriteLine($"Base: {p.Base}");
                Console.WriteLine($"Altura: {p.Altura}");
                Console.WriteLine($"Lado: {p.Lado}");
                Console.WriteLine($"Perímetro: {p.CalcularPerimetro()}");
                Console.WriteLine($"Superficie: {p.CalcularSuperficie()}");
                Console.Write("¿Desea agregar otro paralelogramo? (s/n): ");
                string respuesta = Console.ReadLine().Trim().ToLower();
                if (respuesta != "s")
                    break;
                if (contador >= paralelogramos.Length)
                {
                    Console.WriteLine("No se pueden agregar más paralelogramos. El array está lleno.");
                    break;
                }
            }
            if (contador > 0)
            {
                Paralelogramo maxPerimetro = paralelogramos[0];
                int iteracionMaxPerimetro = 1;

                for (int i = 1; i < contador; i++)
                {
                    if (paralelogramos[i].CalcularPerimetro() > maxPerimetro.CalcularPerimetro())
                    {
                        maxPerimetro = paralelogramos[i];
                        iteracionMaxPerimetro = i + 1;
                    }
                }
                Console.WriteLine($"Paralelogramo con mayor perímetro (Iteración {iteracionMaxPerimetro}):");
                Console.WriteLine($"Base: {maxPerimetro.Base}");
                Console.WriteLine($"Altura: {maxPerimetro.Altura}");
                Console.WriteLine($"Lado: {maxPerimetro.Lado}");
                Console.WriteLine($"Perímetro: {maxPerimetro.CalcularPerimetro()}");
                Console.WriteLine($"Superficie: {maxPerimetro.CalcularSuperficie()}");
                double promedioSuperficies = sumaSuperficies / contador;
                Console.WriteLine($"Promedio de las superficies: {promedioSuperficies}");
            }
            else
            {
                Console.WriteLine("No se ingresaron paralelogramos.");
            }
        }
    }

}
