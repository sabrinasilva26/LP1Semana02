using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Indica um número inteiro: ");
            int input = int.Parse(Console.ReadLine());

            sbyte n = (sbyte)input;

            sbyte incremento = --n;
            sbyte decremento = ++n;

            Console.WriteLine("Número inserido: " + n);

            Console.WriteLine($"Operação de decremento de n: {incremento}");
            Console.WriteLine($"Operação de decremento de n: {decremento}");

            
        }
    }
}
