using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tank
{
    class MyPath : MyCustomGraphics
    {
        public List<MyPoint> Points { get; set; } // масив точек X

        public MyPath(Form form, List<MyPoint> points):base(form)
        {
            this.Points = points;
        }

        public void Draw()
        {
            // Create rectangle for ellipse.
          //  Rectangle rect = new Rectangle(this.x, this.y, this.width, this.height);

            // Draw ellipse to screen.
           // this.g.DrawRectangle(this.pen, rect);
        }
    }
}
