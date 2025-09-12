using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public partial class Building
    {
        private int x;
        private int y;
        private int depth;
        private int width;
        private string color;

        public Building(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.depth = 4;
            this.width = 4;
            this.color = "red";
        }
    }
}
