using System;

namespace StringChainManipulator
{
    // ! Esta es la cadena padre.
    public class ManipuladorDeCadena
    {
        // * Estos son los 2 atributos principales de la clase.
        // * La instrucción { get; set; } en frente de los atributos
        // * indica que podemos obtener y modificar los atributos
        public string cadena { get; set; }
        public string caracter { get; set; }

        // * Este es el constructor de la clase.
        // * Acá le pasamos como parámetro una cadena y un carácter.
        public ManipuladorDeCadena(string cadena, string caracter)
        {
            // * Estas 2 líneas implican que aquello que
            // * sea entregado a través del constructor
            // * será parte del objeto.
            this.cadena = cadena;
            this.caracter = caracter;
        }

        // * Esta es un método de la clase padre creada solo como ejemplo
        // * en este caso sólo imprime sus atributos.
        // * Tiene el "keyword" virtual, lo que significa
        // * que las clases hijas pueden sobreescribirlas para su beneficio.
        public virtual void funcionalidad()
        {
            // * El símbolo del dólar ($) indica que podemos realizar
            // * interpolación de strings, que en pocas palabras significa
            // * que podemos insertar variables dentro de un string.
            Console.WriteLine($"La cadena es \"{cadena}\".");
            Console.WriteLine($"El carácter es '{caracter}'.");
        }
    }
}
