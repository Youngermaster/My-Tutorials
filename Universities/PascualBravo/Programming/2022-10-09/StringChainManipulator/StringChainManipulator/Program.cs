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
                // * Este método lo que hace es simplemente imprimir el menú del programa.
                imprimirMenuPrincipal();
                // * Lo que hacemos es obtener el valor de alguna opción del menún.
                opcionSeleccionada = obtenerOpcion();

                switch (opcionSeleccionada)
                {
                    case 1:
                        // * En este apartado se ejecuta el reto 1.
                        opcionUno();
                        break;
                    case 2:
                        // * En este apartado se ejecuta el reto 2.
                        opcionDos();
                        break;
                    case 3:
                        // * En este apartado se cambia el estado de la ejecución
                        // * para salirnos del ciclo.
                        estaEjecutandose = false;
                        break;
                    default:
                        // * En este apartado si no se pasa ninguna opción válida
                        // * entonces volvemos repetimos el ciclo y le avisamos al usuario
                        // * que no digitó correctamente las opciones.
                        Console.WriteLine("Por favor, selecciona una opción válida.");
                        continue;
                }
            }
        }

        static int obtenerOpcion()
        {
            // * Leemos la entrada del usuario.
            string opcionString = Console.ReadLine();
            // * Esta variable va a guardar la opción en formato entero.
            int opcionInt;

            // * Lo que realizamos en este apartado es a través del método
            // * TryParse(cadena, resultado) es simplemente revisar que la cadena
            // * si se pueda convertir a un entero.
            // * Si se puede convertir a entero nos devuelve un True.
            // * Si no se puede convertir a entero nos devuelve un False.
            bool esConvertibleAEntero = Int32.TryParse(opcionString, out opcionInt);

            // * Si se puede convertir a un entero, entonces devolvemos el entero. 
            if (esConvertibleAEntero)
                return opcionInt;
            else
                return 0; // Si no se puede convertir devolvemos un cero.
        }

        static void opcionUno()
        {
            // ! En este apartado tomamos los valores cadena, caracterUno y caracterDos
            // ! por parte del usuario.
            Console.WriteLine("Por favor, digite la cadena: ");
            string cadena = Console.ReadLine();

            Console.WriteLine("Por favor, digite el carácter que quieres reemplazar: ");
            string caracterUno = Console.ReadLine();

            Console.WriteLine("Por favor, digite el carácter que quieres usar para el reemplazo: ");
            string caracterDos = Console.ReadLine();

            // * Acá creamos el objeto EjercicioUno e inmediatamente llamamos el método
            // * funcionalidad(), el cual realiza los pasos necesarios para darnos
            // * el resultado necesario.
            new EjercicioUno(cadena, caracterUno, caracterDos).funcionalidad();
        }

        static void opcionDos()
        {
            // ! En este apartado tomamos los valores cadena y caracterUno
            // ! por parte del usuario.
            Console.WriteLine("Por favor, digite la cadena: ");
            string cadena = Console.ReadLine();

            Console.WriteLine("Por favor, digite el carácter que quieres contar: ");
            string caracterUno = Console.ReadLine();

            // * Acá creamos el objeto EjercicioDos e inmediatamente llamamos el método
            // * funcionalidad(), el cual realiza los pasos necesarios para darnos
            // * el resultado necesario.
            new EjercicioDos(cadena, caracterUno).funcionalidad();
        }

        // * Este método lo que hace es simplemente imprimir el menú del programa.
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
