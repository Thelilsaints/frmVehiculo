using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmVehiculo
{

    public static class clsVehiculoFactory
    {
        // Método para crear un coche
        public static Coche CrearCoche(int numeroDeRuedas, double costoPorKilometro, double kilometraje, double costoSeguro)
        {
            return new Coche(numeroDeRuedas, costoPorKilometro, kilometraje, costoSeguro);
        }

        // Método para crear un camión
        public static Camion CrearCamion(int numeroDeRuedas, double costoPorKilometro, double kilometraje, double capacidadCarga, double costoPorTonelada)
        {
            return new Camion(numeroDeRuedas, costoPorKilometro, kilometraje, capacidadCarga, costoPorTonelada);
        }

        // Método para crear una moto
        public static Moto CrearMoto(int numeroDeRuedas, double costoPorKilometro, double kilometraje, double cilindrada, double costoPorCilindrada)
        {
            return new Moto(numeroDeRuedas, costoPorKilometro, kilometraje, cilindrada, costoPorCilindrada);
        }
    }
}
