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
        private int counter = 1;

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
                ListaDeTrabajadores.Add(
                    new Trabajador(
                        textBoxNombreDelTrabajador.Text,
                        int.Parse(comboBoxCategoria.Text),
                        double.Parse(textBoxCantidadDeHorasTrabajadas.Text))
                    );

                mostrarDatos();

                counter++;
                labelResultadoTotal.Text = "Añadido " + counter;

                limpiarFormulario();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public Formulario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Calcular_Salarios_Click(object sender, EventArgs e)
        {
        }



        private void CANT_TRABAJAORES_TextChanged(object sender, EventArgs e)
        {


        }

        private void labelResultadoTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
