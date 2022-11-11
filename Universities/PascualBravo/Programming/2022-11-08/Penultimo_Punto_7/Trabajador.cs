namespace Penultimo_Punto_7
{
    public class Trabajador
    {
        // El literal { get; set; } nos sirve para definir que una variable sea accesible y editable.
        public string Nombre { get; set; }
        public int Categoria { get; set; }
        public double HorasTrabajadas { get; set; }
        public double Salario { get; set; }
        public double SalarioFinal { get; set; }
        public double impuestosPagados { get; set; }

        // Con el siguiente constructor creamos el objeto trabajador.
        public Trabajador(string nombre, int categoria, double horasTrabajadas)
        {
            // Definimos que el nombre, la categoria y las horasTrabajadas que nos pasen serán los atributos del nuevo Trabajador.
            Nombre = nombre;
            Categoria = categoria;
            HorasTrabajadas = horasTrabajadas;
            // Llamamos las siguientes 2 funciones para definir el salario y salario final del trabajador.
            calcularSalario();
            calcularSalarioFinal();
        }

        // Este método nos permite calcular el salario del trabajador dependiendo de la categoría que este tenga.
        public void calcularSalario()
        {
            switch (Categoria)
            {
                case 1:
                    Salario = HorasTrabajadas * 40000;
                    break;
                case 2:
                    Salario = HorasTrabajadas * 30000;
                    break;
                case 3:
                    Salario = HorasTrabajadas * 25000;
                    break;
                case 4:
                    Salario = HorasTrabajadas * 20000;
                    break;
                // En caso de que pase algo extraño como un número negativo o alguna otra eventualidad
                // por buenas prácticas tomamos estos casos problemáticos y los inicializamos a 0.
                default:
                    Salario = 0;
                    break;
            }
        }

        // Este método nos permite calcular el salario final que recibirá el trabajador.
        public void calcularSalarioFinal()
        {
            // Definimos las constantes para calcular los impuestos.
            const int SALARIO_LIMITE = 100000;
            const double RETENCION_FUENTE_IMPUESTOS = 5.0 / 100.0;
            const double RETENCION_FUENTE_SEGURIDAD = 3.0 / 100.0;
            const double AUXILIO_DE_TRANSPORTE = 80000;

            if (Salario >= SALARIO_LIMITE)
            {
                // Si el salario es mayor que el salario límite entonces
                // los impuestos se calcularán con la retención en la fuente del (5%)
                // y la retención en la fuente de seguridad (3%).
                impuestosPagados = (Salario * RETENCION_FUENTE_IMPUESTOS) + (Salario * RETENCION_FUENTE_SEGURIDAD);
                // Al salario le restamos los impuestos pagados y obtendremos el salario final recibido.
                SalarioFinal = Salario - impuestosPagados;
            }
            else if (Salario > 0 && Salario < SALARIO_LIMITE)
            {
                // Si el salario es menor que el salario límite entonces
                // los impuestos se calcularán con la retención en la fuente de seguridad (3%)
                // y una auxilio de transporte (80.000).
                impuestosPagados = (Salario * RETENCION_FUENTE_SEGURIDAD) + AUXILIO_DE_TRANSPORTE;
                // Al salario le restamos los impuestos pagados, le sumamos el auxilio de
                // transporte (80.000) y obtendremos el salario final recibido.
                SalarioFinal = Salario - (Salario * RETENCION_FUENTE_SEGURIDAD) + AUXILIO_DE_TRANSPORTE;
            }
            else
            {
                // En caso de que pase algo extraño como un número negativo o alguna otra eventualidad
                // por buenas prácticas tomamos estos casos problemáticos y los inicializamos a 0.
                impuestosPagados = 0;
                SalarioFinal = 0;
            }
        }
    }
}
