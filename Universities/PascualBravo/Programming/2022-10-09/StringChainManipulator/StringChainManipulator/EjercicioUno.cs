using System;

namespace StringChainManipulator
{
    // * Cuando se añade los 2 puntos (:), esto indica
    // * que esta clase heredará de la clase que esté a
    // * la derecha de los 2 puntos (:). En este caso
    // * EjercicioUno herederá de ManipuladorDeCadena.
    internal class EjercicioUno : ManipuladorDeCadena
    {
        // * Este es un atributo adicional de la clase
        // * por lo que sólo se ha creado específicamente para esta clase.
        // * La instrucción { get; set; } en frente de los atributos
        // * indica que podemos obtener y modificar los atributos
        private string caracterDos { get; set; }

        // * Este es el constructor de la clase.
        // * La instrucción base(cadena, caracter) nos indica que no tenemos que
        // * repetir código, dado que hacemos referencia a los atributos ya
        // * definidos por la clase padre y que esta clase heredó.
        public EjercicioUno(string cadena, string caracter, string caracterDos) : base(cadena, caracter)
        {
            // * Estas 3 líneas implican que aquello que
            // * sea entregado a través del constructor
            // * será parte del objeto, incluso el nuevo
            // * atributo que es exclusivo para esta clase.
            this.cadena = cadena;
            this.caracter = caracter;
            this.caracterDos = caracterDos;
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
            // * carácteres que se nos dieron.
            Console.WriteLine($"La cadena es \"{cadena}\".");
            Console.WriteLine($"El carácter a reemplazar es '{caracter}'.");
            Console.WriteLine($"El carácter que reemplazar es '{caracterDos}'.");

            // * En esta parte creamos una variable para guardar
            // * el resultado del método Replace(valorViejo, valorNuevo),
            // * este método reemplaza el carácter 1 por el carácter 2
            // * y se guarda en la variable nuevaCadena.
            // * Ahora bien si no hay nada para cambiar, la cadena permanece igual.
            string nuevaCadena = cadena.Replace(caracter, caracterDos);

            // * Ahora imprimimos el cómo quedó la nueva cadena.
            Console.WriteLine($"La nueva cadena es \"{nuevaCadena}\".");
        }
    }
}
