using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Building
    {
        private int x {  get; set; }
        private int y { get; set; }
        public int depth;
        private int width;
        private string color;

        public Building(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.depth = 10;
            this.width = 10;
            this.color = "red";
        }
    }

    public partial class Factory : Building
    {
        private int PowerConsumption;

        public Factory(int powerConsumption) : base(x,y)
        {
            PowerConsumption = powerConsumption;
        }
    }

}
