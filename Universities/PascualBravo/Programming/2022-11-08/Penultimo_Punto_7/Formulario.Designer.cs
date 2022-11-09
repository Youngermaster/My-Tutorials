namespace Penultimo_Punto_7
{
    partial class Formulario
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
            this.buttonAddUsuario = new System.Windows.Forms.Button();
            this.dataGridViewTrabajadores = new System.Windows.Forms.DataGridView();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.labelTotalImpuestos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrabajadores)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCategoriaDelEmpleado
            // 
            this.labelCategoriaDelEmpleado.AutoSize = true;
            this.labelCategoriaDelEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoriaDelEmpleado.Location = new System.Drawing.Point(15, 216);
            this.labelCategoriaDelEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategoriaDelEmpleado.Name = "labelCategoriaDelEmpleado";
            this.labelCategoriaDelEmpleado.Size = new System.Drawing.Size(374, 25);
            this.labelCategoriaDelEmpleado.TabIndex = 15;
            this.labelCategoriaDelEmpleado.Text = "Seleccione la categoría del Empleado";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(20, 245);
            this.comboBoxCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(160, 24);
            this.comboBoxCategoria.TabIndex = 14;
            // 
            // textBoxCantidadDeHorasTrabajadas
            // 
            this.textBoxCantidadDeHorasTrabajadas.Location = new System.Drawing.Point(21, 175);
            this.textBoxCantidadDeHorasTrabajadas.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCantidadDeHorasTrabajadas.Name = "textBoxCantidadDeHorasTrabajadas";
            this.textBoxCantidadDeHorasTrabajadas.Size = new System.Drawing.Size(357, 22);
            this.textBoxCantidadDeHorasTrabajadas.TabIndex = 13;
            // 
            // textBoxNombreDelTrabajador
            // 
            this.textBoxNombreDelTrabajador.Location = new System.Drawing.Point(20, 105);
            this.textBoxNombreDelTrabajador.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombreDelTrabajador.Name = "textBoxNombreDelTrabajador";
            this.textBoxNombreDelTrabajador.Size = new System.Drawing.Size(359, 22);
            this.textBoxNombreDelTrabajador.TabIndex = 12;
            // 
            // labelCantidadDeHorasTrabajadas
            // 
            this.labelCantidadDeHorasTrabajadas.AutoSize = true;
            this.labelCantidadDeHorasTrabajadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadDeHorasTrabajadas.Location = new System.Drawing.Point(14, 146);
            this.labelCantidadDeHorasTrabajadas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCantidadDeHorasTrabajadas.Name = "labelCantidadDeHorasTrabajadas";
            this.labelCantidadDeHorasTrabajadas.Size = new System.Drawing.Size(307, 25);
            this.labelCantidadDeHorasTrabajadas.TabIndex = 10;
            this.labelCantidadDeHorasTrabajadas.Text = "Cantidad de Horas Trabajadas";
            // 
            // labelNombreDelTrabajador
            // 
            this.labelNombreDelTrabajador.AutoSize = true;
            this.labelNombreDelTrabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreDelTrabajador.Location = new System.Drawing.Point(15, 76);
            this.labelNombreDelTrabajador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombreDelTrabajador.Name = "labelNombreDelTrabajador";
            this.labelNombreDelTrabajador.Size = new System.Drawing.Size(233, 25);
            this.labelNombreDelTrabajador.TabIndex = 9;
            this.labelNombreDelTrabajador.Text = "Nombre del Trabajador";
            // 
            // labelResultadoTotal
            // 
            this.labelResultadoTotal.AutoSize = true;
            this.labelResultadoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.labelResultadoTotal.Location = new System.Drawing.Point(9, 410);
            this.labelResultadoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultadoTotal.Name = "labelResultadoTotal";
            this.labelResultadoTotal.Size = new System.Drawing.Size(262, 42);
            this.labelResultadoTotal.TabIndex = 16;
            this.labelResultadoTotal.Text = "Total a pagar:";
            // 
            // buttonCalcularPagoTotal
            // 
            this.buttonCalcularPagoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcularPagoTotal.Location = new System.Drawing.Point(220, 289);
            this.buttonCalcularPagoTotal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalcularPagoTotal.Name = "buttonCalcularPagoTotal";
            this.buttonCalcularPagoTotal.Size = new System.Drawing.Size(233, 59);
            this.buttonCalcularPagoTotal.TabIndex = 17;
            this.buttonCalcularPagoTotal.Text = "Calcular Pago Total";
            this.buttonCalcularPagoTotal.UseVisualStyleBackColor = true;
            this.buttonCalcularPagoTotal.Click += new System.EventHandler(this.button_Calcular_Salarios_Click);
            // 
            // buttonAddUsuario
            // 
            this.buttonAddUsuario.AccessibleName = "buttonAddUsuario";
            this.buttonAddUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUsuario.Location = new System.Drawing.Point(19, 289);
            this.buttonAddUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddUsuario.Name = "buttonAddUsuario";
            this.buttonAddUsuario.Size = new System.Drawing.Size(193, 59);
            this.buttonAddUsuario.TabIndex = 36;
            this.buttonAddUsuario.Text = "Añadir Usuario";
            this.buttonAddUsuario.UseVisualStyleBackColor = true;
            this.buttonAddUsuario.Click += new System.EventHandler(this.buttonAddUsuarioClick);
            // 
            // dataGridViewTrabajadores
            // 
            this.dataGridViewTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrabajadores.Location = new System.Drawing.Point(567, 11);
            this.dataGridViewTrabajadores.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTrabajadores.Name = "dataGridViewTrabajadores";
            this.dataGridViewTrabajadores.RowHeadersWidth = 51;
            this.dataGridViewTrabajadores.Size = new System.Drawing.Size(853, 528);
            this.dataGridViewTrabajadores.TabIndex = 37;
            // 
            // labelProjectName
            // 
            this.labelProjectName.AutoSize = true;
            this.labelProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProjectName.Location = new System.Drawing.Point(12, 11);
            this.labelProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(451, 42);
            this.labelProjectName.TabIndex = 38;
            this.labelProjectName.Text = "Nómina de Trabajadores";
            // 
            // labelFeedback
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeedback.Location = new System.Drawing.Point(18, 363);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(0, 25);
            this.labelFeedback.TabIndex = 39;
            // 
            // labelTotalImpuestos
            // 
            this.labelTotalImpuestos.AutoSize = true;
            this.labelTotalImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.labelTotalImpuestos.Location = new System.Drawing.Point(14, 476);
            this.labelTotalImpuestos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalImpuestos.Name = "labelTotalImpuestos";
            this.labelTotalImpuestos.Size = new System.Drawing.Size(307, 42);
            this.labelTotalImpuestos.TabIndex = 40;
            this.labelTotalImpuestos.Text = "Total impuestos:";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 555);
            this.Controls.Add(this.labelTotalImpuestos);
            this.Controls.Add(this.labelFeedback);
            this.Controls.Add(this.labelProjectName);
            this.Controls.Add(this.dataGridViewTrabajadores);
            this.Controls.Add(this.buttonAddUsuario);
            this.Controls.Add(this.buttonCalcularPagoTotal);
            this.Controls.Add(this.labelResultadoTotal);
            this.Controls.Add(this.labelCategoriaDelEmpleado);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.textBoxCantidadDeHorasTrabajadas);
            this.Controls.Add(this.textBoxNombreDelTrabajador);
            this.Controls.Add(this.labelCantidadDeHorasTrabajadas);
            this.Controls.Add(this.labelNombreDelTrabajador);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Formulario";
            this.Text = "Formulario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrabajadores)).EndInit();
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
        private System.Windows.Forms.Button buttonAddUsuario;
        private System.Windows.Forms.DataGridView dataGridViewTrabajadores;
        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.Label labelFeedback;
        private System.Windows.Forms.Label labelTotalImpuestos;
    }
}

