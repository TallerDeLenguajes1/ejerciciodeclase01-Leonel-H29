using System;

namespace Problema02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            byte result;

            try
            {
                num1 = 5;
                num2 = 20;
                result = Convert.ToByte(num1 * num2);
                Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
                Console.ReadLine();
            }catch(OverflowException ex)
            {
                Console.WriteLine($"¡ERROR!: {ex}");
            }

        }
    }
}
