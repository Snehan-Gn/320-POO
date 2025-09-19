using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Factory : Building
    {
        private double _powerConsumption;

        public Factory(int x, int y, double powerConsumption) : base(x, y)
        {
            _powerConsumption = powerConsumption;
        }

        public void Show()
        {
            Console.WriteLine("Usine - Consommation d'énergie : " + _powerConsumption + "KwH");
        }
    }
}
