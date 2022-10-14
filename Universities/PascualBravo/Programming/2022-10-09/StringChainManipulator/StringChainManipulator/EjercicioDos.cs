using System;

namespace StringChainManipulator
{
    // * Cuando se añade los 2 puntos (:), esto indica
    // * que esta clase heredará de la clase que esté a
    // * la derecha de los 2 puntos (:). En este caso
    // * EjercicioDos herederá de ManipuladorDeCadena.
    internal class EjercicioDos : ManipuladorDeCadena
    {
        // * Este es el constructor de la clase.
        // * La instrucción base(cadena, caracter) nos indica que no tenemos que
        // * repetir código, dado que hacemos referencia a los atributos ya
        // * definidos por la clase padre y que esta clase heredó.
        public EjercicioDos(string cadena, string caracter) : base(cadena, caracter)
        {
            this.cadena = cadena;
            this.caracter = caracter;
        }

        // * Tiene el "keyword" override, lo que significa
        // * que como clase hija puede sobreescribirlas la
        // * de su padre para su beneficio.
        public override void funcionalidad()
        {
            // * El símbolo del dólar ($) indica que podemos realizar
            // * interpolación de strings, que en pocas palabras significa
            // * que podemos insertar variables dentro de un string.

            // * Lo primero que hacemos es imprimir la cadena y
            // * carácter que se nos dieron.
            Console.WriteLine($"La cadena es \"{cadena}\".");
            Console.WriteLine($"El carácter es '{caracter}'.");

            // * En este apartado lo que hacemos es lo siguiente:
            // * 1. Tomamos la cadena y la dividimos en las partes
            // *    en la que encuentre el carácter especificado,
            // *    esto devuelve un arreglo.
            // * 2. Después obtenemos el tamaño de ese arreglo
            // *    resultante.
            // * 3. A este le restamos 1 y obtenemos las veces
            // *    que se repite ese carácter.

            // * Ejemplo: Tenemos la cadena '1a2a3' y queremos encontrar
            // * cuántas veces está la 'a'.
            // * al usar el método '1a2a3'.Split('a') obtenemos el siguiente
            // * arrego => [1, 2, 3], si obtenemos su tamaño, este es de 3
            // * y si le restamos 1, el resultado es 2, que es la cantidad
            // * de veces que se repite la 'a'.
            int contador = cadena.Split(caracter).Length - 1;

            // * Finalmente imprimimos el resultado.
            Console.WriteLine($"El cantidad de veces que está '{caracter}' en \"{cadena}\" es {contador}.");
        }
    }
}
