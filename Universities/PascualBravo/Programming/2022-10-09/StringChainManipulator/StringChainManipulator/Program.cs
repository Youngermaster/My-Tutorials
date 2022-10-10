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

            // * Realizamos este ciclo para ejecutarlo infinitamente hasta que decidamos terminarlo.
            while (estaEjecutandose)
            {
                imprimirMenuPrincipal();
                opcionSeleccionada = obtenerOpcion();

                switch (opcionSeleccionada)
                {
                    case 1:
                        opcionUno();
                        break;
                    case 2:
                        opcionDos();
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

        static void opcionUno()
        {
            Console.WriteLine("Por favor, digite la cadena: ");
            string cadena = Console.ReadLine();

            Console.WriteLine("Por favor, digite el carácter que quieres reemplazar: ");
            string caracterUno = Console.ReadLine();

            Console.WriteLine("Por favor, digite el carácter que quieres usar para el reemplazo: ");
            string caracterDos = Console.ReadLine();

            new EjercicioUno(cadena, caracterUno, caracterDos).funcionalidad();
        }

        static void opcionDos()
        {
            Console.WriteLine("Por favor, digite la cadena: ");
            string cadena = Console.ReadLine();

            Console.WriteLine("Por favor, digite el carácter que quieres contar: ");
            string caracterUno = Console.ReadLine();

            new EjercicioDos(cadena, caracterUno).funcionalidad();
        }

        public static void imprimirMenuPrincipal()
        {
            Console.WriteLine("|=================================|");
            Console.WriteLine("|        Proyecto Cadenas         |");
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
