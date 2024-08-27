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
            Paralelogramo p;
            Console.Write("Introduce la Base del paralelogramo: ");
            while (!double.TryParse(Console.ReadLine(), out p.Base) || p.Base <= 0)
            {
                Console.WriteLine("Error: El valor ingresado no es válido o es menor o igual a cero. Inténtalo de nuevo.");
                Console.Write("Introduce la Base del paralelogramo: ");
            }
            Console.Write("Introduce la Altura del paralelogramo: ");
            while (!double.TryParse(Console.ReadLine(), out p.Altura) || p.Altura <= 0)
            {
                Console.WriteLine("Error: El valor ingresado no es válido o es menor o igual a cero. Inténtalo de nuevo.");
                Console.Write("Introduce la Altura del paralelogramo: ");
            }
            Console.Write("Introduce el Lado del paralelogramo: ");
            while (!double.TryParse(Console.ReadLine(), out p.Lado) || p.Lado <= 0)
            {
                Console.WriteLine("Error: El valor ingresado no es válido o es menor o igual a cero. Inténtalo de nuevo.");
                Console.Write("Introduce el Lado del paralelogramo: ");
            }
            Console.WriteLine($"Base: {p.Base}");
            Console.WriteLine($"Altura: {p.Altura}");
            Console.WriteLine($"Lado: {p.Lado}");
            Console.WriteLine($"Perímetro del paralelogramo: {p.CalcularPerimetro()}");
            Console.WriteLine($"Superficie del paralelogramo: {p.CalcularSuperficie()}");
        }
    }
}

