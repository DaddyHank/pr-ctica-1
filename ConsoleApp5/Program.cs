using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Suma
            int num1, num2;
            Console.WriteLine("Introduzca un número:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Iintroduzca otro número:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma de los números es: " + (num1 + num2));

            // Resta
            int num3, num4;
            Console.WriteLine("introduzca un número:");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca otro número:");
            num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("La resta de los números es: " + (num3 - num4));

            // Multiplicación
            int num5, num6;
            Console.WriteLine("Introduzca un número:");
            num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca otro número:");
            num6 = int.Parse(Console.ReadLine());
            Console.WriteLine("La multiplicación de los números es: " + (num5 * num6));

            // División
            int num7, num8;
            Console.WriteLine("Introduzca un número:");
            num7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserte otro número:");
            num8 = int.Parse(Console.ReadLine());
            Console.WriteLine("La división de los números es: " + (num7 / num8));
        }
    }
}
