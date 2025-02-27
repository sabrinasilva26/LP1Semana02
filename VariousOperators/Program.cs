using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira um número não negativo: ");
            int input = int.Parse(Console.ReadLine());

            byte n = (byte)input;

            byte divisao = (byte) (n / 2);

            Console.WriteLine($"{divisao}");

            byte left = (byte)(n<< 3);

            Console.WriteLine($"{left}");

            byte x = (byte)(n ^ 6);

            Console.WriteLine($"{x}");

            bool s = (bool)(n > 10);
            
            Console.WriteLine($"{s}");
            











        }
    }
}
