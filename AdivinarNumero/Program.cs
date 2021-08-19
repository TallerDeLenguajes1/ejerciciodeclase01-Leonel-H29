using System;

namespace AdivinarNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int numero = random.Next(101); //Numero entre 0 - 100
            int intentos = 0; // Contador de intentos
            int numero_elegido;

            do
            {
                Console.WriteLine("**Escriba un numero: ");

                try
                {
                    numero_elegido = Convert.ToInt32(Console.ReadLine());
                    if (numero_elegido > numero)
                    {
                        Console.WriteLine($"EL NUMERO INGRESADO {numero_elegido} ES MAYOR QUE EL NUMERO ALEATORIO");
                        intentos++;
                    }
                    else
                    {
                        if (numero_elegido < numero)
                        {
                            Console.WriteLine($"EL NUMERO INGRESADO {numero_elegido} ES MENOR QUE EL NUMERO ALEATORIO \n");
                            intentos++;
                        }
                        else
                        {
                            Console.WriteLine($"¡FELICITACIONES! ENCONTRO EL NUMERO EN {intentos} INTENTOS \n");
                        }
                    }
                }

                catch (OverflowException ex)
                {
                    Console.WriteLine($"¡ERROR! ESTO SE DEBE AL QUE VALOR INGRESADO ES DEMASIADO GRANDE: {ex} \n");
                    numero_elegido = -1;
                }


                catch (Exception ex)
                {
                    Console.WriteLine($"¡ERROR! ESTO PUEDE DEBERSE AL TIPO DE DATO DEL VALOR INGRESADO:{ex} \n");
                    numero_elegido = -1;
                }

            } while (numero_elegido != numero);


        }
    }
}
