using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tank
{
    abstract class MyCustomGraphics
    {
        public Graphics g { get; set; } // компанент для отрисовки
        public Form form { get; set; } //компонент на котором будет происходить отрисовка
        public Pen pen { get; set; } //перо для нашего кастомного графического обьекта


        //Конструктор кастомного графического обьекта
        public MyCustomGraphics(Form form)
        {
            this.form = form; // иницируем форму на которой мі будем рисовать
            this.g = this.form.CreateGraphics(); ; // инициализируем компонент для отрисовки
            this.pen = new Pen(Color.Black, 3); // значение нашего пера по умолчанию
        }
    }
}
