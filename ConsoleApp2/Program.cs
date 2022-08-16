using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            string firstname = "Darien";
            String lastname = "Molina";
            int edad = 22;
            // Concatenación de variables
            var name = firstname + " " + lastname;
            // imprimir
            Console.WriteLine("Su nombre es: {0} y su edad es: {1}", name, edad);
        }
    }
}
