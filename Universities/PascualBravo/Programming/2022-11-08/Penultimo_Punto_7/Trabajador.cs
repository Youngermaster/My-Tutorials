using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penultimo_Punto_7
{
    public class Trabajador
    {
        public string Nombre { get; set; }
        public double Salario { get; set; }
        public double HorasTrabajadas { get; set; }
        public int Categoria { get; set; }
        public double SalarioFinal { get; set; }
        public double impuestosPagados { get; set; }


        public Trabajador(string nombre, int categoria, double horasTrabajadas)
        {
            Nombre = nombre;
            Categoria = categoria;
            HorasTrabajadas = horasTrabajadas;
            calcularSalario();
            calcularSalarioFinal();
        }

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
                default:
                    Salario = 0;
                    break;
            }
        }

        public void calcularSalarioFinal()
        {
            const int SALARIO_LIMITE = 100000;
            const double RETENCION_FUENTE_IMPUESTOS = 5.0 / 100.0;
            const double RETENCION_FUENTE_SEGURIDAD = 3.0 / 100.0;
            const double AUXILIO_DE_TRANSPORTE = 80000;

            if (Salario >= SALARIO_LIMITE)
            {
                impuestosPagados = (Salario * RETENCION_FUENTE_IMPUESTOS) + (Salario * RETENCION_FUENTE_SEGURIDAD);
                SalarioFinal = Salario - impuestosPagados;
            }
            else if (Salario > 0 && Salario < SALARIO_LIMITE)
            {
                impuestosPagados = (Salario * RETENCION_FUENTE_SEGURIDAD) + AUXILIO_DE_TRANSPORTE;
                SalarioFinal = Salario - (Salario * RETENCION_FUENTE_SEGURIDAD) + AUXILIO_DE_TRANSPORTE;
            }
            else
            {
                impuestosPagados = 0;
                SalarioFinal = 0;
            }
        }
    }
}
