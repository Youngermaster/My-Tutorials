using System;

namespace StringChainManipulator
{
    internal class EjercicioUno : ManipuladorDeCadena
    {
        private string caracterDos { get; set; }

        public EjercicioUno(string cadena, string caracter, string caracterDos) : base(cadena, caracter)
        {
            this.cadena = cadena;
            this.caracter = caracter;
            this.caracterDos = caracterDos;
        }

        public override void funcionalidad()
        {
            Console.WriteLine($"La cadena es \"{cadena}\".");
            Console.WriteLine($"El carácter a reemplazar es '{caracter}'.");
            Console.WriteLine($"El carácter que reemplazar es '{caracterDos}'.");

            string nuevaCadena = cadena.Replace(caracter, caracterDos);
            Console.WriteLine($"La nueva cadena es \"{nuevaCadena}\".");
        }
    }
}
