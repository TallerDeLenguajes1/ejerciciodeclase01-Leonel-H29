using System;


namespace Problema04
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 1;
                int b = 2;
                int c = 50;
                Console.WriteLine("{0} - {1} - {2}", a, b, c);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"ERROR: Hubo un error al mostrar los datos por consola {ex}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex}");
            }
            
            Console.ReadLine();
        }
    }
}
