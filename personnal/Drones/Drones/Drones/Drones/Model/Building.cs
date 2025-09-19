using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Building
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public int Depth { get; set; }
        public int Width { get; set; }
        public string color { get; set; }

        public Building(int x, int y)
        {
            X = x;
            Y = y;
            depth = 10;
            width = 10;
            this.color = "red";
        }
    }
}
