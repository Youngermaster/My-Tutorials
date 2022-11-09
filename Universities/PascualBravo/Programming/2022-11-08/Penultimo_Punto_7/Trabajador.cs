using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penultimo_Punto_7
{
    internal class Trabajador
    {
        public string nombre { get; set; }
        public double salario { get; set; }
        public double horasTrabajadas { get; set; }
        public int categoria { get; set; }
        public int salarioFinal { get; set; }


        Trabajador(string nombre, int categoria, double horasTrabajadas)
        {
            this.nombre = nombre;
            this.categoria = categoria;
            this.horasTrabajadas = horasTrabajadas;
        }
        public void calcularSalario()
        {
            switch (this.categoria)
            {
                case 1:
                    this.salario = horasTrabajadas * 40000;
                    break;
                case 2:
                    this.salario = horasTrabajadas * 30000;
                    break;
                case 3:
                    this.salario = horasTrabajadas * 25000;
                    break;
                case 4:
                    this.salario = horasTrabajadas * 20000;
                    break;
                default:
                    this.salario = 0;
                    break;
            }
        }

    }
}
