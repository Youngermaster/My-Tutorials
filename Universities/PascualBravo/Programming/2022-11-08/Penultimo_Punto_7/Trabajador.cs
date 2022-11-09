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
        public int SalarioFinal { get; set; }


        public Trabajador(string nombre, int categoria, double horasTrabajadas)
        {
            this.Nombre = nombre;
            this.Categoria = categoria;
            this.HorasTrabajadas = horasTrabajadas;
        }

        public void calcularSalario()
        {
            switch (this.Categoria)
            {
                case 1:
                    this.Salario = HorasTrabajadas * 40000;
                    break;
                case 2:
                    this.Salario = HorasTrabajadas * 30000;
                    break;
                case 3:
                    this.Salario = HorasTrabajadas * 25000;
                    break;
                case 4:
                    this.Salario = HorasTrabajadas * 20000;
                    break;
                default:
                    this.Salario = 0;
                    break;
            }
        }

    }
}
