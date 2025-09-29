using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numerosUsuario = new List<int>();

        Console.WriteLine("Ingresa 5 números:");
        for(int i = 0; i < 5; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numerosUsuario.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("\nNúmero par:");
        foreach (int numero in numerosUsuario)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine(numero);
            }
        }


    }
}
