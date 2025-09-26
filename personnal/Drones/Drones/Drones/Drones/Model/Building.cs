using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Building
    {
        protected int x;
        protected int y;
        protected int depth;
        protected int width;
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
}
