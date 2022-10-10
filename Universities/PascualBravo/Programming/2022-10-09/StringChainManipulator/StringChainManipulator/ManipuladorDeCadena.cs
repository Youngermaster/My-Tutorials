using System;

namespace StringChainManipulator
{
    public class ManipuladorDeCadena
    {
        public string cadena { get; set; }
        public string caracter { get; set; }

        public ManipuladorDeCadena(string cadena, string caracter)
        {
            this.cadena = cadena;
            this.caracter = caracter;
        }

        public virtual void funcionalidad()
        {
            Console.WriteLine($"La cadena es \"{cadena}\".");
            Console.WriteLine($"El carácter es '{caracter}'.");
        }
    }
}
