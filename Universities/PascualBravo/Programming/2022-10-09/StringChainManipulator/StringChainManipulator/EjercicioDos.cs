using System;

namespace StringChainManipulator
{
    internal class EjercicioDos : ManipuladorDeCadena
    {
        public EjercicioDos(string cadena, string caracter) : base(cadena, caracter)
        {
            this.cadena = cadena;
            this.caracter = caracter;
        }

        public override void funcionalidad()
        {
            Console.WriteLine($"La cadena es \"{cadena}\".");
            Console.WriteLine($"El carácter es '{caracter}'.");
            int contador = cadena.Split(caracter).Length - 1;

            Console.WriteLine($"El cantidad de veces que está '{caracter}' en \"{cadena}\" es ${contador}.");
        }
    }
}
