using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
          sbyte sb = sbyte.MaxValue;
          sbyte sb1 = sbyte.MinValue;
          double db = sbyte.MaxValue;
          double db1 = sbyte.MinValue;
          ulong ul = ulong.MaxValue;
          ulong ul1 = ulong.MinValue;
          float ft = float.MaxValue;
          float ft1 = float.MinValue;
          int it = int.MaxValue;
          int it1 = int.MinValue;
          byte bt = byte.MaxValue;
          byte bt1 = byte.MinValue;
          short st = short.MaxValue;
          short st1 = short.MinValue;

          float a = float.PositiveInfinity;
          float b = float.NegativeInfinity;
          double d = double.NaN;

          Console.WriteLine($"{sb}");
          Console.WriteLine($"{sb1}");
          Console.WriteLine($"{db}");
          Console.WriteLine($"{db1}");
          Console.WriteLine($"{ul}");
          Console.WriteLine($"{ul1}");
          Console.WriteLine($"{ft}");
          Console.WriteLine($"{ft1}");
          Console.WriteLine($"{it}");
          Console.WriteLine($"{it1}");
          Console.WriteLine($"{bt}");
          Console.WriteLine($"{bt1}");
          Console.WriteLine($"{st}");
          Console.WriteLine($"{st1}");

          Console.WriteLine($"{a}");
          Console.WriteLine($"{b}");
          Console.WriteLine($"{d}");

          Console.WriteLine((sbyte)(sb+ 1));
          Console.WriteLine((sbyte)(sb1 - 1));
          Console.WriteLine((byte)(2 * bt));




        }
    }
}
