using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zzzzzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Hola! Vamos a hacer algunas preguntas.");

            Console.Write("¿Cuál es tu nombre? ");
            string nombre = Console.ReadLine();

            Console.Write("¿Cuál es tu edad? ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("¿Qué te gusta hacer? ");
            string gusta = Console.ReadLine();

            Console.WriteLine("\nTus respuestas son:");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad} años");
            Console.WriteLine($"Te gusta: {gusta}");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
