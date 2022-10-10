using System;

namespace StringChainManipulator
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            printMainMenu();
        }

        public static void printMainMenu()
        {
            Console.WriteLine("|===============================|");
            Console.WriteLine("|       Proyecto Matemático     |");
            Console.WriteLine("|===============================|");
            Console.WriteLine("|                               |");
            Console.WriteLine("| Selecciona una opción:        |");
            Console.WriteLine("|                               |");
            Console.WriteLine("| 1. Ejercicios aritméticos.    |");
            Console.WriteLine("| 2. Ejercicios de ciclos.      |");
            Console.WriteLine("| 3. Ejercicios de cálculos.    |");
            Console.WriteLine("| 4. Calcular factorial de N.   |");
            Console.WriteLine("| 5. Salir.                     |");
            Console.WriteLine("|                               |");
            Console.WriteLine("|===============================|");
        }
    }
}
