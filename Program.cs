using System;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Suma V.2:");

            Console.WriteLine("Ingrese un numero a sumar:");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero a sumar:");
            int numero2 = int.Parse(Console.ReadLine());

            int resultado = numero1 + numero2;

            Console.WriteLine(string.Format("El resultado es {0}", resultado));

        }
    }
}
