using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmVehiculo
{
    public class clsVehiculo
    {
        public int NumeroDeRuedas { get; set; }
        public double CostoPorKilometro { get; set; }
        public double Kilometraje { get; set; }

        public clsVehiculo(int numeroDeRuedas, double costoPorKilometro, double kilometraje)
        {
            NumeroDeRuedas = numeroDeRuedas;
            CostoPorKilometro = costoPorKilometro;
            Kilometraje = kilometraje;
        }

        public virtual double CalcularCostoTotal()
        {
            return Kilometraje * CostoPorKilometro;
        }
    }
}
