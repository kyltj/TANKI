using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tank
{
    class MyLine : MyCustomGraphics
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }

        public MyLine(Form form, int x1, int y1, int x2, int y2) : base(form)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

        //ВСЕ КООРДИНАТЫ ЗАДАЮТЬСЯ ОТНОСИТЕЛЬНО ЛЕВОГО-ВЕРХНЕГО УГЛА ФОРМЫ

        //метод для отрисовки линии
        public void Draw()
        {
            // Draw ellipse to screen.
            this.g.DrawLine(this.pen, x1, y1, x2, y2);
        }

        //Удаление происходит путем закрашивания конкретной фигуру по тому же контуру что она и біла нарисована
        public void Clear()
        {
            //меняем цвет пера на цвет фона
            this.pen.Color = this.form.BackColor;
            // Draw ellipse to screen.
            this.g.DrawLine(this.pen, x1, y1, x2, y2);
            //меняем цвет пера на цвет снова на дефолтный
            this.pen.Color = Color.Black;
        }

        public void MoveX(int x)
        {
            this.Clear();
            this.x1 = this.x1 + x;
            this.x2 = this.x2 + x;
            this.Draw();
        }

        public void MoveY(int y)
        {
            this.Clear();
            this.y1 = this.y1 + y;
            this.y2 = this.y2 + y;
            this.Draw();
        }

    }
}
