using System;

namespace StringChainManipulator
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // * Esta variable nos permite saber si se está ejecutando o no el programa.
            bool estaEjecutandose = true;
            // * Con esta variable revisamos qué opción estamos seleccionando en el menú.
            int opcionSeleccionada = 0;

            // * Realizamos este ciclo para poderlo ejecutarlo infinitamente hasta que decidamos terminarlo.
            while (estaEjecutandose)
            {
                imprimirMenuPrincipal();
                opcionSeleccionada = obtenerOpcion();

                switch (opcionSeleccionada)
                {
                    case 1:
                        Console.WriteLine("Uno.");
                        break;
                    case 2:
                        Console.WriteLine("Dos.");
                        break;
                    case 3:
                        estaEjecutandose = false;
                        break;
                    default:
                        Console.WriteLine("Por favor, selecciona una opción válida.");
                        continue;
                }
            }
        }

        static int obtenerOpcion()
        {
            string opcionString = Console.ReadLine();
            int opcionInt;

            bool isParsable = Int32.TryParse(opcionString, out opcionInt);

            if (isParsable)
                return opcionInt;
            else
                return 0;

        }
        public static void imprimirMenuPrincipal()
        {
            Console.WriteLine("|=================================|");
            Console.WriteLine("|       Proyecto Matemático       |");
            Console.WriteLine("|=================================|");
            Console.WriteLine("|                                 |");
            Console.WriteLine("| Selecciona una opción:          |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("| 1. Sustituir la aparición del   |");
            Console.WriteLine("|    primer carácter en la cadena |");
            Console.WriteLine("|    por el segundo carácter.     |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("| 2. Mostrar cuántas veces        |");
            Console.WriteLine("|    aparece un carácter dado en  |");
            Console.WriteLine("|    la cadena.                   |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("| 3. Salir.                       |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|=================================|");
        }
    }
}
