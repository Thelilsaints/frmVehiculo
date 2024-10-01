using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmVehiculo
{
    public class Camion : clsVehiculo
    {
        public double CapacidadCarga { get; set; }
        public double CostoPorTonelada { get; set; }

        public Camion(int numeroDeRuedas, double costoPorKilometro, double kilometraje, double capacidadCarga, double costoPorTonelada)
            : base(numeroDeRuedas, costoPorKilometro, kilometraje)
        {
          
            CapacidadCarga = capacidadCarga;
            CostoPorTonelada = costoPorTonelada;
        }

        public override double CalcularCostoTotal()
        {
            return base.CalcularCostoTotal() + (CapacidadCarga * CostoPorTonelada);
        }
    }
}
