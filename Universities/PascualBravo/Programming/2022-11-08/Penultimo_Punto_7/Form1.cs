using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penultimo_Punto_7
{
    public partial class Form1 : Form
    {
        
        private List<Trabajador> ListaDeTrabajadores = new List<Trabajador>(); 

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("AÑADIR ");
            this.label5.Text = " Añadio Exitosamente";
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

        private string[] Nombres;
        public Form1()
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
    }
}
