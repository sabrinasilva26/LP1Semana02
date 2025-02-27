using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Indica a altura do cilindro: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Indica o raio do cilindro: ");
            double r = double.Parse(Console.ReadLine());

             

            double volume =  Math.PI * Math.Pow(r, 2) *  a;

            Console.WriteLine($"{volume:F3}");

            double area = 2 * Math.PI * r * (r + a);

            Console.WriteLine($"{area:F3}"); 
    
        }
    }
}
