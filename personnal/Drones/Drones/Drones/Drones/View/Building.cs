using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Building
    {
        private Pen buildingBrush = new Pen(new SolidBrush(Color.Blue), 5);

        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(buildingBrush, new Rectangle(x, y, depth, width));
        }
    }
}
