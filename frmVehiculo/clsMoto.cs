using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmVehiculo
{
    public class Moto : clsVehiculo
    {
        public double Cilindrada { get; set; }
        public double CostoPorCilindrada { get; set; }

        public Moto(int numeroDeRuedas, double costoPorKilometro, double kilometraje, double cilindrada, double costoPorCilindrada)
            : base(numeroDeRuedas, costoPorKilometro, kilometraje)
        {
            Cilindrada = cilindrada;
            CostoPorCilindrada = costoPorCilindrada;
        }

        public override double CalcularCostoTotal()
        {
            return base.CalcularCostoTotal() + (Cilindrada * CostoPorCilindrada);
        }
    }
}
