using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penultimo_Punto_7
{
    public partial class Formulario : Form
    {

        public List<Trabajador> ListaDeTrabajadores = new List<Trabajador>();

        private double pagoTotalDeImpuestos = 0;
        private double pagoTotal = 0;

        private void limpiarFormulario()
        {
            textBoxNombreDelTrabajador.Text = "";
            comboBoxCategoria.Text = "";
            textBoxCantidadDeHorasTrabajadas.Text = "";
        }

        private void mostrarDatos()
        {
            dataGridViewTrabajadores.DataSource = null;
            dataGridViewTrabajadores.DataSource = ListaDeTrabajadores;
            dataGridViewTrabajadores.Update();
            dataGridViewTrabajadores.Refresh();
        }

        private void buttonAddUsuarioClick(object sender, EventArgs e)
        {
            if (textBoxNombreDelTrabajador.Text != "" && comboBoxCategoria.Text != "" && textBoxCantidadDeHorasTrabajadas.Text != "")
            {
                var trabajadorParaAñadir = new Trabajador(
                            textBoxNombreDelTrabajador.Text,
                            int.Parse(comboBoxCategoria.Text),
                            double.Parse(textBoxCantidadDeHorasTrabajadas.Text)
                    );

                ListaDeTrabajadores.Add(trabajadorParaAñadir);
                pagoTotalDeImpuestos += trabajadorParaAñadir.impuestosPagados;
                pagoTotal += trabajadorParaAñadir.SalarioFinal + trabajadorParaAñadir.impuestosPagados;

                labelFeedback.Text = "Trabajador añadido.";

                mostrarDatos();
                limpiarFormulario();
            }
        }

        public Formulario()
        {
            InitializeComponent();
        }

        private void button_Calcular_Salarios_Click(object sender, EventArgs e)
        {
            labelResultadoTotal.Text = "Total a Pagar: " + pagoTotal.ToString();
            labelTotalImpuestos.Text = "Total a Impuestos: " + pagoTotalDeImpuestos.ToString();
        }
    }
}
