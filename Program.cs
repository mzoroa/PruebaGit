using System;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Version 2:");

            Console.WriteLine("Ingrese un numero a sumar:");
            int numero1 = Console.Read();
            Console.WriteLine("Ingrese otro numero a sumar:");
            int numero2 = Console.Read();

            int resultado = numero1 + numero2;

            Console.WriteLine(string.Format("El resultado es {0}", resultado));

        }
    }
}
