namespace Penultimo_Punto_7
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCategoriaDelEmpleado = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.textBoxCantidadDeHorasTrabajadas = new System.Windows.Forms.TextBox();
            this.textBoxNombreDelTrabajador = new System.Windows.Forms.TextBox();
            this.labelCantidadDeHorasTrabajadas = new System.Windows.Forms.Label();
            this.labelNombreDelTrabajador = new System.Windows.Forms.Label();
            this.labelResultadoTotal = new System.Windows.Forms.Label();
            this.buttonCalcularPagoTotal = new System.Windows.Forms.Button();
            this.buttonAñadirUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCategoriaDelEmpleado
            // 
            this.labelCategoriaDelEmpleado.AutoSize = true;
            this.labelCategoriaDelEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoriaDelEmpleado.Location = new System.Drawing.Point(25, 263);
            this.labelCategoriaDelEmpleado.Name = "labelCategoriaDelEmpleado";
            this.labelCategoriaDelEmpleado.Size = new System.Drawing.Size(310, 20);
            this.labelCategoriaDelEmpleado.TabIndex = 15;
            this.labelCategoriaDelEmpleado.Text = "Seleccione la categoría del Empleado";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "40000",
            "30000",
            "25000",
            "20000"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(30, 304);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategoria.TabIndex = 14;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxCantidadDeHorasTrabajadas
            // 
            this.textBoxCantidadDeHorasTrabajadas.Location = new System.Drawing.Point(30, 215);
            this.textBoxCantidadDeHorasTrabajadas.Name = "textBoxCantidadDeHorasTrabajadas";
            this.textBoxCantidadDeHorasTrabajadas.Size = new System.Drawing.Size(269, 20);
            this.textBoxCantidadDeHorasTrabajadas.TabIndex = 13;
            // 
            // textBoxNombreDelTrabajador
            // 
            this.textBoxNombreDelTrabajador.Location = new System.Drawing.Point(29, 117);
            this.textBoxNombreDelTrabajador.Name = "textBoxNombreDelTrabajador";
            this.textBoxNombreDelTrabajador.Size = new System.Drawing.Size(270, 20);
            this.textBoxNombreDelTrabajador.TabIndex = 12;
            // 
            // labelCantidadDeHorasTrabajadas
            // 
            this.labelCantidadDeHorasTrabajadas.AutoSize = true;
            this.labelCantidadDeHorasTrabajadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadDeHorasTrabajadas.Location = new System.Drawing.Point(26, 167);
            this.labelCantidadDeHorasTrabajadas.Name = "labelCantidadDeHorasTrabajadas";
            this.labelCantidadDeHorasTrabajadas.Size = new System.Drawing.Size(253, 20);
            this.labelCantidadDeHorasTrabajadas.TabIndex = 10;
            this.labelCantidadDeHorasTrabajadas.Text = "Cantidad de Horas Trabajadas";
            this.labelCantidadDeHorasTrabajadas.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelNombreDelTrabajador
            // 
            this.labelNombreDelTrabajador.AutoSize = true;
            this.labelNombreDelTrabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreDelTrabajador.Location = new System.Drawing.Point(25, 83);
            this.labelNombreDelTrabajador.Name = "labelNombreDelTrabajador";
            this.labelNombreDelTrabajador.Size = new System.Drawing.Size(191, 20);
            this.labelNombreDelTrabajador.TabIndex = 9;
            this.labelNombreDelTrabajador.Text = "Nombre del Trabajador";
            this.labelNombreDelTrabajador.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelResultadoTotal
            // 
            this.labelResultadoTotal.AutoSize = true;
            this.labelResultadoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultadoTotal.Location = new System.Drawing.Point(534, 167);
            this.labelResultadoTotal.Name = "labelResultadoTotal";
            this.labelResultadoTotal.Size = new System.Drawing.Size(345, 55);
            this.labelResultadoTotal.TabIndex = 16;
            this.labelResultadoTotal.Text = "Total: 150.000";
            this.labelResultadoTotal.Click += new System.EventHandler(this.labelResultadoTotal_Click);
            // 
            // buttonCalcularPagoTotal
            // 
            this.buttonCalcularPagoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcularPagoTotal.Location = new System.Drawing.Point(544, 372);
            this.buttonCalcularPagoTotal.Name = "buttonCalcularPagoTotal";
            this.buttonCalcularPagoTotal.Size = new System.Drawing.Size(416, 48);
            this.buttonCalcularPagoTotal.TabIndex = 17;
            this.buttonCalcularPagoTotal.Text = "Calcular Pago Total";
            this.buttonCalcularPagoTotal.UseVisualStyleBackColor = true;
            this.buttonCalcularPagoTotal.Click += new System.EventHandler(this.button_Calcular_Salarios_Click);
            // 
            // buttonAñadirUsuario
            // 
            this.buttonAñadirUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAñadirUsuario.Location = new System.Drawing.Point(30, 372);
            this.buttonAñadirUsuario.Name = "buttonAñadirUsuario";
            this.buttonAñadirUsuario.Size = new System.Drawing.Size(215, 48);
            this.buttonAñadirUsuario.TabIndex = 36;
            this.buttonAñadirUsuario.Text = "Añadir Usuario";
            this.buttonAñadirUsuario.UseVisualStyleBackColor = true;
            this.buttonAñadirUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.buttonAñadirUsuario);
            this.Controls.Add(this.buttonCalcularPagoTotal);
            this.Controls.Add(this.labelResultadoTotal);
            this.Controls.Add(this.labelCategoriaDelEmpleado);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.textBoxCantidadDeHorasTrabajadas);
            this.Controls.Add(this.textBoxNombreDelTrabajador);
            this.Controls.Add(this.labelCantidadDeHorasTrabajadas);
            this.Controls.Add(this.labelNombreDelTrabajador);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCategoriaDelEmpleado;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.TextBox textBoxCantidadDeHorasTrabajadas;
        private System.Windows.Forms.TextBox textBoxNombreDelTrabajador;
        private System.Windows.Forms.Label labelCantidadDeHorasTrabajadas;
        private System.Windows.Forms.Label labelNombreDelTrabajador;
        private System.Windows.Forms.Label labelResultadoTotal;
        private System.Windows.Forms.Button buttonCalcularPagoTotal;
        private System.Windows.Forms.Button buttonAñadirUsuario;
    }
}

