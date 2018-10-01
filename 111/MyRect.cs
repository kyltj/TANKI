using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tank
{
    class MyRect : MyCustomGraphics
    {
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }

        public MyRect(Form form, int x, int y, int width, int height) : base(form)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        //ВСЕ КООРДИНАТЫ ЗАДАЮТЬСЯ ОТНОСИТЕЛЬНО ЛЕВОГО-ВЕРХНЕГО УГЛА ФОРМЫ

        //метод для отрисовки Прямоугольника
        public void Draw()
        {
            // Create rectangle for ellipse.
            Rectangle rect = new Rectangle(this.x, this.y, this.width, this.height);

            // Draw ellipse to screen.
            this.g.DrawRectangle(this.pen, rect);
        }

        //Удаление происходит путем закрашивания конкретной фигуру по тому же контуру что она и біла нарисована
        public void Clear()
        {
          
        }

        public void MoveX()
        {

        }

        public void MoveY()
        {

        }
    }
}
