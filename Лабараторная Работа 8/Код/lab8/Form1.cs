using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            // Создание ручек с различными стилями линий
            Pen solidPen = new Pen(Color.Blue, 2);
            Pen dashPen = new Pen(Color.Red, 2) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };
            Pen dashDotPen = new Pen(Color.Green, 2) { DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot };

            // Рисование линий
            g.DrawLine(solidPen, 10, 10, 200, 10);
            g.DrawLine(dashPen, 10, 30, 200, 30);
            g.DrawLine(dashDotPen, 10, 50, 200, 50);

            // Рисование и заливка прямоугольников
            g.DrawRectangle(solidPen, 10, 70, 100, 50);
            g.FillRectangle(new SolidBrush(Color.Yellow), 120, 70, 100, 50);

            // Рисование и заливка эллипсов
            g.DrawEllipse(dashPen, 10, 130, 100, 50);
            g.FillEllipse(new SolidBrush(Color.Purple), 120, 130, 100, 50);

            // Рисование многоугольников
            Point[] points = { new Point(10, 200), new Point(60, 200), new Point(35, 250) };
            g.DrawPolygon(dashDotPen, points);
            Point[] points2 = { new Point(120, 200), new Point(170, 200), new Point(145, 250) };
            g.FillPolygon(new SolidBrush(Color.Orange), points2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
