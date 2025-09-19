using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Store : Building
    {
        private string _openingHours;

        public Store(int x, int y, string openingHours) : base(x, y)
        {
            _openingHours = openingHours;
        }

        public void Show()
        {
            Console.WriteLine("Point de vente - Horaires : " + _openingHours);
        }
    }
}
