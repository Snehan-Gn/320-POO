using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.View
{
    public partial class Building
    {
        private Pen buildingBrush = new Pen(new SolidBrush(Color.Red), 3);

        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawEllipse(buildingBrush, new Rectangle(50,50, 4, 4));
        }
    }
}
