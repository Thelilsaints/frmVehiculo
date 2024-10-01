namespace frmVehiculo
{
    partial class frmVehiculos
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
            this.txtCilindraje = new System.Windows.Forms.TextBox();
            this.lblCilindraje = new System.Windows.Forms.Label();
            this.lstVehiculos = new System.Windows.Forms.ListBox();
            this.btnCrearVehiculo = new System.Windows.Forms.Button();
            this.txtNumeroDeRuedas = new System.Windows.Forms.TextBox();
            this.lblNumeroDeRuedas = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtKilometraje = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtCostoPorKilometro = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.lblTipoVehiculos = new System.Windows.Forms.Label();
            this.lblKilometraje = new System.Windows.Forms.Label();
            this.lblCostoPorKilometro = new System.Windows.Forms.Label();
            this.lblVehículos = new System.Windows.Forms.Label();
            this.lblCostoSeguro = new System.Windows.Forms.Label();
            this.txtCostoSeguro = new System.Windows.Forms.TextBox();
            this.lblCapacidadDeCarga = new System.Windows.Forms.Label();
            this.txtCapacidadDeCarga = new System.Windows.Forms.TextBox();
            this.lblCostoPorTonelada = new System.Windows.Forms.Label();
            this.txtCostoPorTonelada = new System.Windows.Forms.TextBox();
            this.lblCostoPorCilindrada = new System.Windows.Forms.Label();
            this.txtCostoPorCilindrada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCilindraje
            // 
            this.txtCilindraje.Location = new System.Drawing.Point(125, 209);
            this.txtCilindraje.Margin = new System.Windows.Forms.Padding(2);
            this.txtCilindraje.Name = "txtCilindraje";
            this.txtCilindraje.Size = new System.Drawing.Size(200, 20);
            this.txtCilindraje.TabIndex = 27;
            // 
            // lblCilindraje
            // 
            this.lblCilindraje.AutoSize = true;
            this.lblCilindraje.Location = new System.Drawing.Point(65, 216);
            this.lblCilindraje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCilindraje.Name = "lblCilindraje";
            this.lblCilindraje.Size = new System.Drawing.Size(52, 13);
            this.lblCilindraje.TabIndex = 26;
            this.lblCilindraje.Text = "Cilindraje:";
            // 
            // lstVehiculos
            // 
            this.lstVehiculos.FormattingEnabled = true;
            this.lstVehiculos.Location = new System.Drawing.Point(363, 72);
            this.lstVehiculos.Margin = new System.Windows.Forms.Padding(2);
            this.lstVehiculos.Name = "lstVehiculos";
            this.lstVehiculos.Size = new System.Drawing.Size(349, 238);
            this.lstVehiculos.TabIndex = 25;
            this.lstVehiculos.SelectedIndexChanged += new System.EventHandler(this.lstVehiculos_SelectedIndexChanged);
            // 
            // btnCrearVehiculo
            // 
            this.btnCrearVehiculo.Location = new System.Drawing.Point(363, 322);
            this.btnCrearVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearVehiculo.Name = "btnCrearVehiculo";
            this.btnCrearVehiculo.Size = new System.Drawing.Size(129, 40);
            this.btnCrearVehiculo.TabIndex = 24;
            this.btnCrearVehiculo.Text = "Crear Vehículo";
            this.btnCrearVehiculo.UseVisualStyleBackColor = true;
            this.btnCrearVehiculo.Click += new System.EventHandler(this.btnCrearVehiculo_Click_1);
            // 
            // txtNumeroDeRuedas
            // 
            this.txtNumeroDeRuedas.Location = new System.Drawing.Point(125, 174);
            this.txtNumeroDeRuedas.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroDeRuedas.Name = "txtNumeroDeRuedas";
            this.txtNumeroDeRuedas.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroDeRuedas.TabIndex = 23;
            // 
            // lblNumeroDeRuedas
            // 
            this.lblNumeroDeRuedas.AutoSize = true;
            this.lblNumeroDeRuedas.Location = new System.Drawing.Point(17, 181);
            this.lblNumeroDeRuedas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroDeRuedas.Name = "lblNumeroDeRuedas";
            this.lblNumeroDeRuedas.Size = new System.Drawing.Size(97, 13);
            this.lblNumeroDeRuedas.TabIndex = 22;
            this.lblNumeroDeRuedas.Text = "Numero de ruedas:";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(-46, 180);
            this.lblAño.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 20;
            this.lblAño.Text = "Año";
            // 
            // txtKilometraje
            // 
            this.txtKilometraje.Location = new System.Drawing.Point(125, 137);
            this.txtKilometraje.Margin = new System.Windows.Forms.Padding(2);
            this.txtKilometraje.Name = "txtKilometraje";
            this.txtKilometraje.Size = new System.Drawing.Size(200, 20);
            this.txtKilometraje.TabIndex = 19;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(-46, 145);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 18;
            this.lblModelo.Text = "Modelo";
            // 
            // txtCostoPorKilometro
            // 
            this.txtCostoPorKilometro.Location = new System.Drawing.Point(125, 104);
            this.txtCostoPorKilometro.Margin = new System.Windows.Forms.Padding(2);
            this.txtCostoPorKilometro.Name = "txtCostoPorKilometro";
            this.txtCostoPorKilometro.Size = new System.Drawing.Size(200, 20);
            this.txtCostoPorKilometro.TabIndex = 17;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(-46, 112);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 16;
            this.lblMarca.Text = "Marca";
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(125, 72);
            this.cmbTipoVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(200, 21);
            this.cmbTipoVehiculo.TabIndex = 15;
            this.cmbTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVehiculo_SelectedIndexChanged);
            // 
            // lblTipoVehiculos
            // 
            this.lblTipoVehiculos.AutoSize = true;
            this.lblTipoVehiculos.Location = new System.Drawing.Point(24, 80);
            this.lblTipoVehiculos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoVehiculos.Name = "lblTipoVehiculos";
            this.lblTipoVehiculos.Size = new System.Drawing.Size(97, 13);
            this.lblTipoVehiculos.TabIndex = 14;
            this.lblTipoVehiculos.Text = "Tipo de Vehículos:";
            // 
            // lblKilometraje
            // 
            this.lblKilometraje.AutoSize = true;
            this.lblKilometraje.Location = new System.Drawing.Point(53, 144);
            this.lblKilometraje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKilometraje.Name = "lblKilometraje";
            this.lblKilometraje.Size = new System.Drawing.Size(61, 13);
            this.lblKilometraje.TabIndex = 29;
            this.lblKilometraje.Text = "Kilometraje:";
            // 
            // lblCostoPorKilometro
            // 
            this.lblCostoPorKilometro.AutoSize = true;
            this.lblCostoPorKilometro.Location = new System.Drawing.Point(17, 111);
            this.lblCostoPorKilometro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCostoPorKilometro.Name = "lblCostoPorKilometro";
            this.lblCostoPorKilometro.Size = new System.Drawing.Size(100, 13);
            this.lblCostoPorKilometro.TabIndex = 28;
            this.lblCostoPorKilometro.Text = "Costo por kilometro:";
            // 
            // lblVehículos
            // 
            this.lblVehículos.AutoSize = true;
            this.lblVehículos.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehículos.Location = new System.Drawing.Point(262, 9);
            this.lblVehículos.Name = "lblVehículos";
            this.lblVehículos.Size = new System.Drawing.Size(176, 31);
            this.lblVehículos.TabIndex = 30;
            this.lblVehículos.Text = "VEHÍCULOS";
            // 
            // lblCostoSeguro
            // 
            this.lblCostoSeguro.AutoSize = true;
            this.lblCostoSeguro.Location = new System.Drawing.Point(42, 282);
            this.lblCostoSeguro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCostoSeguro.Name = "lblCostoSeguro";
            this.lblCostoSeguro.Size = new System.Drawing.Size(72, 13);
            this.lblCostoSeguro.TabIndex = 26;
            this.lblCostoSeguro.Text = "Costo seguro:";
            // 
            // txtCostoSeguro
            // 
            this.txtCostoSeguro.Location = new System.Drawing.Point(125, 275);
            this.txtCostoSeguro.Margin = new System.Windows.Forms.Padding(2);
            this.txtCostoSeguro.Name = "txtCostoSeguro";
            this.txtCostoSeguro.Size = new System.Drawing.Size(200, 20);
            this.txtCostoSeguro.TabIndex = 27;
            // 
            // lblCapacidadDeCarga
            // 
            this.lblCapacidadDeCarga.AutoSize = true;
            this.lblCapacidadDeCarga.Location = new System.Drawing.Point(8, 316);
            this.lblCapacidadDeCarga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCapacidadDeCarga.Name = "lblCapacidadDeCarga";
            this.lblCapacidadDeCarga.Size = new System.Drawing.Size(106, 13);
            this.lblCapacidadDeCarga.TabIndex = 26;
            this.lblCapacidadDeCarga.Text = "Capacidad de carga:";
            // 
            // txtCapacidadDeCarga
            // 
            this.txtCapacidadDeCarga.Location = new System.Drawing.Point(125, 309);
            this.txtCapacidadDeCarga.Margin = new System.Windows.Forms.Padding(2);
            this.txtCapacidadDeCarga.Name = "txtCapacidadDeCarga";
            this.txtCapacidadDeCarga.Size = new System.Drawing.Size(200, 20);
            this.txtCapacidadDeCarga.TabIndex = 27;
            // 
            // lblCostoPorTonelada
            // 
            this.lblCostoPorTonelada.AutoSize = true;
            this.lblCostoPorTonelada.Location = new System.Drawing.Point(15, 349);
            this.lblCostoPorTonelada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCostoPorTonelada.Name = "lblCostoPorTonelada";
            this.lblCostoPorTonelada.Size = new System.Drawing.Size(99, 13);
            this.lblCostoPorTonelada.TabIndex = 26;
            this.lblCostoPorTonelada.Text = "Costo por tonelada:";
            // 
            // txtCostoPorTonelada
            // 
            this.txtCostoPorTonelada.Location = new System.Drawing.Point(125, 342);
            this.txtCostoPorTonelada.Margin = new System.Windows.Forms.Padding(2);
            this.txtCostoPorTonelada.Name = "txtCostoPorTonelada";
            this.txtCostoPorTonelada.Size = new System.Drawing.Size(200, 20);
            this.txtCostoPorTonelada.TabIndex = 27;
            // 
            // lblCostoPorCilindrada
            // 
            this.lblCostoPorCilindrada.AutoSize = true;
            this.lblCostoPorCilindrada.Location = new System.Drawing.Point(8, 250);
            this.lblCostoPorCilindrada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCostoPorCilindrada.Name = "lblCostoPorCilindrada";
            this.lblCostoPorCilindrada.Size = new System.Drawing.Size(103, 13);
            this.lblCostoPorCilindrada.TabIndex = 26;
            this.lblCostoPorCilindrada.Text = "Costo por cilindrada:";
            // 
            // txtCostoPorCilindrada
            // 
            this.txtCostoPorCilindrada.Location = new System.Drawing.Point(125, 247);
            this.txtCostoPorCilindrada.Margin = new System.Windows.Forms.Padding(2);
            this.txtCostoPorCilindrada.Name = "txtCostoPorCilindrada";
            this.txtCostoPorCilindrada.Size = new System.Drawing.Size(200, 20);
            this.txtCostoPorCilindrada.TabIndex = 27;
            // 
            // frmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 396);
            this.Controls.Add(this.lblVehículos);
            this.Controls.Add(this.lblKilometraje);
            this.Controls.Add(this.lblCostoPorKilometro);
            this.Controls.Add(this.txtCostoPorTonelada);
            this.Controls.Add(this.lblCostoPorTonelada);
            this.Controls.Add(this.txtCostoSeguro);
            this.Controls.Add(this.txtCapacidadDeCarga);
            this.Controls.Add(this.lblCostoSeguro);
            this.Controls.Add(this.lblCapacidadDeCarga);
            this.Controls.Add(this.txtCostoPorCilindrada);
            this.Controls.Add(this.lblCostoPorCilindrada);
            this.Controls.Add(this.txtCilindraje);
            this.Controls.Add(this.lblCilindraje);
            this.Controls.Add(this.lstVehiculos);
            this.Controls.Add(this.btnCrearVehiculo);
            this.Controls.Add(this.txtNumeroDeRuedas);
            this.Controls.Add(this.lblNumeroDeRuedas);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.txtKilometraje);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtCostoPorKilometro);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cmbTipoVehiculo);
            this.Controls.Add(this.lblTipoVehiculos);
            this.Name = "frmVehiculos";
            this.Text = "Vehiculos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCilindraje;
        private System.Windows.Forms.Label lblCilindraje;
        private System.Windows.Forms.ListBox lstVehiculos;
        private System.Windows.Forms.Button btnCrearVehiculo;
        private System.Windows.Forms.TextBox txtNumeroDeRuedas;
        private System.Windows.Forms.Label lblNumeroDeRuedas;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.TextBox txtKilometraje;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtCostoPorKilometro;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.Label lblTipoVehiculos;
        private System.Windows.Forms.Label lblKilometraje;
        private System.Windows.Forms.Label lblCostoPorKilometro;
        private System.Windows.Forms.Label lblVehículos;
        private System.Windows.Forms.Label lblCostoSeguro;
        private System.Windows.Forms.TextBox txtCostoSeguro;
        private System.Windows.Forms.Label lblCapacidadDeCarga;
        private System.Windows.Forms.TextBox txtCapacidadDeCarga;
        private System.Windows.Forms.Label lblCostoPorTonelada;
        private System.Windows.Forms.TextBox txtCostoPorTonelada;
        private System.Windows.Forms.Label lblCostoPorCilindrada;
        private System.Windows.Forms.TextBox txtCostoPorCilindrada;
    }
}

