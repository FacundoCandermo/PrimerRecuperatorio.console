namespace Punto3
{
    struct Paralelogramo
    {
        public double Base;
        public double Altura;
        public double Lado;
        public void EstablecerValores(double baseP, double alturaP, double ladoP)
        {
            if (baseP <= 0 || alturaP <= 0 || ladoP <= 0)
            {
                Console.WriteLine("Error: Todos los valores deben ser mayores que cero.");
                Base = 0;
                Altura = 0;
                Lado = 0;
            }
            else
            {
                Base = baseP;
                Altura = alturaP;
                Lado = ladoP;
            }
        }
        public double CalcularPerimetro()
        {
            return 2 * (Base + Lado);
        }
        public double CalcularSuperficie()
        {
            return Base * Altura;
        }
        public void InformarValores()
        {
            Console.WriteLine($"Base: {Base}");
            Console.WriteLine($"Altura: {Altura}");
            Console.WriteLine($"Lado: {Lado}");
        }
        public void InformarPerimetro()
        {
            Console.WriteLine($"Perímetro del paralelogramo: {CalcularPerimetro()}");
        }

        public void InformarSuperficie()
        {
            Console.WriteLine($"Superficie del paralelogramo: {CalcularSuperficie()}");
        }
    }
    class Program
    {
        static void Main()
        {
            Paralelogramo p = new Paralelogramo();
            Console.Write("Introduce la Base del paralelogramo: ");
            double baseP = LeerValorPositivo();
            Console.Write("Introduce la Altura del paralelogramo: ");
            double alturaP = LeerValorPositivo();
            Console.Write("Introduce el Lado del paralelogramo: ");
            double ladoP = LeerValorPositivo();
            p.EstablecerValores(baseP, alturaP, ladoP);
            if (p.Base > 0 && p.Altura > 0 && p.Lado > 0)
            {
                Console.WriteLine("\nDatos del paralelogramo:");
                p.InformarValores();
                p.InformarPerimetro();
                p.InformarSuperficie();
            }
            else
            {
                Console.WriteLine("No se pudieron calcular los valores debido a datos incorrectos.");
            }
        }
        static double LeerValorPositivo()
        {
            double valor;
            while (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0)
            {
                Console.WriteLine("Error: El valor debe ser un número positivo. Inténtalo de nuevo.");
                Console.Write("Introduce un valor positivo: ");
            }
            return valor;
        }
    }
}

