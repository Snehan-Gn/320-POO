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

        public Building(int x, int y, int depth, int width, string color)
        {
            this.x = x;
            this.y = y;
            this.depth = depth;
            this.width = width;
            this.color = color;
        }
    }
}
