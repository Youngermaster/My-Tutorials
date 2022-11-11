using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Penultimo_Punto_7
{
    public partial class Formulario : Form
    {
        // En esta lista guardaremos todos los trabajadores que se vayan añadiendo en el formulario.
        public List<Trabajador> ListaDeTrabajadores = new List<Trabajador>();
        // En esta variable iremos guardando los impuestos totales pagados.
        private double pagoTotalDeImpuestos = 0;
        // En esta variable iremos guardando el total pagado.
        private double pagoTotal = 0;

        public Formulario()
        {
            // Inicializa todos los componentes del Windows Forms.
            InitializeComponent();
        }

        // Este método limpiará el formulario del Windows Forms para añadir más trabajadores.
        private void limpiarFormulario()
        {
            // Vacíamos los valores digitados por el usuario.
            textBoxNombreDelTrabajador.Text = "";
            textBoxCantidadDeHorasTrabajadas.Text = "";
            comboBoxCategoria.Text = "";
        }

        // Este método mostrará la lista de trabajadores en ele Data Grid View.
        private void mostrarDatos()
        {
            // Reiniciamos el valor de la fuente de datos del DataGridView a vacío.
            dataGridViewTrabajadores.DataSource = null;
            // Reiniciamos el valor de la fuente de datos del DataGridView a la lista de Trabajadores ya actualizada.
            dataGridViewTrabajadores.DataSource = ListaDeTrabajadores;
        }

        // Este método se ejecuta cuando presionamos el "botón de añadir Trabajador".
        private void buttonAddUsuarioClick(object sender, EventArgs e)
        {
            // Primero revisamos que el formulario no tenga ningún valor vacío.
            if (textBoxNombreDelTrabajador.Text != "" && comboBoxCategoria.Text != "" && textBoxCantidadDeHorasTrabajadas.Text != "")
            {
                // Creamos un trabajador con los valores que el usuario digite.
                var trabajadorParaAñadir = new Trabajador(
                            textBoxNombreDelTrabajador.Text,
                            int.Parse(comboBoxCategoria.Text), // El "int.Parse()" es para convertir el string a entero.
                            double.Parse(textBoxCantidadDeHorasTrabajadas.Text) // El "double.Parse()" es para convertir el string a double.
                    );
                // Añadimos el nuevo trabajador creado a la lista de trabajadores.
                ListaDeTrabajadores.Add(trabajadorParaAñadir);
                // Acumulamos el valor pagado en impuestos por el trabajador creado.
                pagoTotalDeImpuestos += trabajadorParaAñadir.impuestosPagados;
                // Acumulamos el valor total pagado por el trabajador creado.
                pagoTotal += trabajadorParaAñadir.SalarioFinal + trabajadorParaAñadir.impuestosPagados;

                // Actualizamos el valor de un "Label" para dar la confianza al usuario de que se añadió un nuevo usuario.
                labelFeedback.Text = "Trabajador añadido.";

                // EJecutamos el método "mostrarDatos()" para actualizar el DataGridView con la nueva lista.
                mostrarDatos();
                // EJecutamos el método "limpiarFormulario()" para limpiar el formulario y añadir más usuarios.
                limpiarFormulario();
            }
        }

        // Este método se ejecuta cuando presionamos el "botón Calcular pago total".
        private void button_Calcular_Salarios_Click(object sender, EventArgs e)
        {
            // Al texto del Label Resultado Total le actualizamos su valor con el pago total que hemos acumulado.
            labelResultadoTotal.Text = "Total a Pagar: " + pagoTotal.ToString();
            // Al texto del Label Resultado Total le actualizamos su valor con el pago total de impuestos que hemos acumulado.
            labelTotalImpuestos.Text = "Total a Impuestos: " + pagoTotalDeImpuestos.ToString();
        }
    }
}
