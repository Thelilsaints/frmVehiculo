using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmVehiculo
{
    public partial class frmVehiculos : Form
    {
        // Lista para almacenar los vehículos creados
        private List<clsVehiculo> listaDeVehiculos = new List<clsVehiculo>();

        public frmVehiculos()
        {
            InitializeComponent();
            cmbTipoVehiculo.Items.Add("Coche");
            cmbTipoVehiculo.Items.Add("Camion");
            cmbTipoVehiculo.Items.Add("Moto");
            cmbTipoVehiculo.SelectedIndex = 0;

            // Ajustar campos según el tipo de vehículo seleccionado
            AjustarCampos();
        }
        private void ActualizarListaVehiculos()
        {
            // Limpiar la lista y agregar los detalles de cada vehículo creado
            lstVehiculos.Items.Clear();
            foreach (var vehiculo in listaDeVehiculos)
            {
                lstVehiculos.Items.Add($"Tipo: {vehiculo.GetType().Name}, Costo total de mantenimiento: {vehiculo.CalcularCostoTotal():C}");
            }
        }

        private void cmbTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ajustar campos según el tipo de vehículo seleccionado
            AjustarCampos();
        }

        private void AjustarCampos()
        {
            // Obtener el tipo de vehículo seleccionado
            string tipoVehiculo = cmbTipoVehiculo.SelectedItem.ToString();

            // Deshabilitar todos los campos primero
            txtCostoSeguro.Enabled = false;
            txtCapacidadDeCarga.Enabled = false;
            txtCostoPorTonelada.Enabled = false;
            txtCilindraje.Enabled = false;
            txtCostoPorCilindrada.Enabled = false;

            // Habilitar campos según el tipo de vehículo
            switch (tipoVehiculo)
            {
                case "Coche":
                    txtCostoSeguro.Enabled = true;
                    break;
                case "Camion":
                    txtCapacidadDeCarga.Enabled = true;
                    txtCostoPorTonelada.Enabled = true;
                    break;
                case "Moto":
                    txtCilindraje.Enabled = true;
                    txtCostoPorCilindrada.Enabled = true;
                    break;
            }
        }

        private void btnCrearVehiculo_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Recoger valores comunes
                int numeroDeRuedas = int.Parse(txtNumeroDeRuedas.Text);
                double costoPorKilometro = double.Parse(txtCostoPorKilometro.Text);
                double kilometraje = double.Parse(txtKilometraje.Text);

                // Validaciones generales para clsVehiculo
                if (numeroDeRuedas < 2 || numeroDeRuedas > 18)
                    throw new ArgumentOutOfRangeException("El número de ruedas debe estar entre 2 y 18.");

                if (costoPorKilometro <= 0)
                    throw new ArgumentException("El costo por kilómetro debe ser mayor a 0.");

                if (kilometraje < 0)
                    throw new ArgumentException("El kilometraje no puede ser negativo.");

                // Obtener el tipo de vehículo seleccionado
                string tipoVehiculo = cmbTipoVehiculo.SelectedItem.ToString();
                clsVehiculo vehiculo = null;

                // Crear el vehículo según el tipo seleccionado y validar campos
                if (tipoVehiculo == "Coche")
                {
                    double costoSeguro = double.Parse(txtCostoSeguro.Text);
                    if (costoSeguro < 100 || costoSeguro > 2000)
                        throw new ArgumentOutOfRangeException("El costo del seguro debe estar entre $100 y $2000.");

                    vehiculo = clsVehiculoFactory.CrearCoche(numeroDeRuedas, costoPorKilometro, kilometraje, costoSeguro);
                }
                else if (tipoVehiculo == "Camion")
                {
                    double capacidadCarga = double.Parse(txtCapacidadDeCarga.Text);
                    double costoPorTonelada = double.Parse(txtCostoPorTonelada.Text);

                    if (capacidadCarga > 30)
                        throw new ArgumentOutOfRangeException("El camión no puede transportar más de 30 toneladas.");

                    if (costoPorTonelada < 50)
                        throw new ArgumentException("El costo por tonelada transportada no puede ser menor que $50.");

                    vehiculo = clsVehiculoFactory.CrearCamion(numeroDeRuedas, costoPorKilometro, kilometraje, capacidadCarga, costoPorTonelada);
                }
                else if (tipoVehiculo == "Moto")
                {
                    double cilindrada = double.Parse(txtCilindraje.Text);
                    double costoPorCilindrada = double.Parse(txtCostoPorCilindrada.Text);

                    vehiculo = clsVehiculoFactory.CrearMoto(numeroDeRuedas, costoPorKilometro, kilometraje, cilindrada, costoPorCilindrada);
                }
                else
                {
                    MessageBox.Show("Tipo de vehículo desconocido.");
                    return;
                }

                // Añadir el vehículo a la lista y actualizar el ListBox
                listaDeVehiculos.Add(vehiculo);
                ActualizarListaVehiculos();
                MessageBox.Show("Vehículo creado correctamente.");

                LimpiarCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en los campos requeridos.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }
        private void LimpiarCampos()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        private void lstVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}