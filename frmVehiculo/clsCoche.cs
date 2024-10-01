using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmVehiculo
{
    public class Coche : clsVehiculo
    {
        public double CostoSeguro { get; set; }

        public Coche(int numeroDeRuedas, double costoPorKilometro, double kilometraje, double costoSeguro)
            : base(numeroDeRuedas, costoPorKilometro, kilometraje)
        {
            CostoSeguro = costoSeguro;
        }

        public override double CalcularCostoTotal()
        {
            return base.CalcularCostoTotal() + CostoSeguro;
        }
    }
}
