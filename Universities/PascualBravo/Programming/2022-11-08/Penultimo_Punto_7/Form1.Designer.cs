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
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxCantidadDeHorasTrabajadas = new System.Windows.Forms.TextBox();
            this.textBoxNombreDelTrabajador = new System.Windows.Forms.TextBox();
            this.labelCantidadDeHorasTrabajadas = new System.Windows.Forms.Label();
            this.labelNombreDelTrabajador = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Calcular_Salarios = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(680, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "INGRESE   SU  CATEGORIA";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "40000",
            "30000",
            "25000",
            "20000"});
            this.comboBox1.Location = new System.Drawing.Point(693, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 16;
            // 
            // button_Calcular_Salarios
            // 
            this.button_Calcular_Salarios.Location = new System.Drawing.Point(473, 397);
            this.button_Calcular_Salarios.Name = "button_Calcular_Salarios";
            this.button_Calcular_Salarios.Size = new System.Drawing.Size(411, 23);
            this.button_Calcular_Salarios.TabIndex = 17;
            this.button_Calcular_Salarios.Text = "TOTAL  DE  APORTES  DE  LOS  TRABAJADORES  PARA  IMPUESTOS";
            this.button_Calcular_Salarios.UseVisualStyleBackColor = true;
            this.button_Calcular_Salarios.Click += new System.EventHandler(this.button_Calcular_Salarios_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Añadir Usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Calcular_Salarios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
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

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxCantidadDeHorasTrabajadas;
        private System.Windows.Forms.TextBox textBoxNombreDelTrabajador;
        private System.Windows.Forms.Label labelCantidadDeHorasTrabajadas;
        private System.Windows.Forms.Label labelNombreDelTrabajador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Calcular_Salarios;
        private System.Windows.Forms.Button button1;
    }
}

