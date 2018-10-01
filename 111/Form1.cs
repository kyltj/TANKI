using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tank
{
    public partial class Form1 : Form
    {

        //Обьявление єкземпляра класса прямоугольник
        MyRect rect;
        //Обьявление єкземпляра класса круг
        MyEllipse ellipse;
        //Обьявление єкземпляра класса линия
        MyLine line;

        //Конструктор формы
        public Form1()
        {
            InitializeComponent(); //инициализация формы
            line = new MyLine(this, 10, 10, 100, 10);
            rect = new MyRect(this, 10, 50, 100, 100);
            ellipse = new MyEllipse(this, 10, 200, 100, 100);
        }

        //Событие которое вызываеться когда форма инициализировалась
        private void Form1_Shown(object sender, EventArgs e)
        {
            //рисуем басовые фигуры кастомномным графическим обьектом
            //линия
            line.Draw();
            //квадрат
            rect.Draw();
            //круг
            ellipse.Draw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            line.MoveX(10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            line.MoveY(10);
        }
    }
}
