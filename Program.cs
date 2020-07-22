using System;

namespace ConsolaTerceroA
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine(args[0]);
            }
            Console.WriteLine("Ingrese un dato!!!");
            string datosLeidos = Console.ReadLine();
            Console.WriteLine($"Usted ingresó lo siguiente {datosLeidos}");
            Console.ReadKey();
        }
    }
}