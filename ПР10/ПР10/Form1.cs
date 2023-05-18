using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР10
{
    public partial class Form1 : Form
    {
        Rectangle rectangle = new Rectangle(10, 10, 200, 100);
        Rectangle circle = new Rectangle(220, 10, 150, 150);
        Rectangle square = new Rectangle(380, 10, 150, 150);

        bool rectClick = false;
        bool circClick = false;
        bool SqurClick = false;

        int rectX = 0;
        int rectY = 0;

        int circX = 0;
        int circY = 0;

        int squrX = 0;
        int squrY = 0;

        int X, Y, dX, dY;
        int LastClicked = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, circle);
            e.Graphics.FillRectangle(Brushes.Pink, square);
            e.Graphics.FillRectangle(Brushes.Black, rectangle);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            if ((e.X < rectangle.X + rectangle.Width) && (e.X > rectangle.X))
            {
                if ((e.Y < rectangle.Y + rectangle.Height) && (e.Y > rectangle.Y))
                {
                    rectClick = true;

                    rectX = e.X - rectangle.X;
                    rectY = e.Y - rectangle.Y;
                }
            }

            if ((e.X < circle.X + circle.Width) && (e.X > circle.X))
            {
                if ((e.Y < circle.Y + circle.Height) && (e.Y > circle.Y))
                {
                    circClick = true;

                    circX = e.X - circle.X;
                    circY = e.Y - circle.Y;
                }
            }

            if ((e.X < square.X + square.Width) && (e.X > square.X))
            {
                if ((e.Y < square.Y + square.Height) && (e.Y > square.Y))
                {
                    SqurClick = true;

                    squrX = e.X - square.X;
                    squrY = e.Y - square.Y;
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (rectClick == true)
            {
                LastClicked = 1; //прямоугольник
            }
            if (circClick == true)
            {
                LastClicked = 2; //круг
            }
            if (SqurClick == true)
            {
                LastClicked = 3; //квадрат
            }

            if(LastClicked == 1)
            {
                label1.Text = "прямогульник"; //не работает
            }
            if (LastClicked == 2)
            {
                label1.Text = "круг"; //не работает
            }
            if (LastClicked == 3)
            {
                label1.Text = "квадрат";
            }
            else
            {
                label1.Text = "не работает";
            }

            rectClick = false;
            circClick = false;
            SqurClick = false;

            if ((labelForm.Location.X < square.X + square.Width) && (labelForm.Location.X > square.X))
            {
                if ((labelForm.Location.Y < square.Y + square.Height) && (labelForm.Location.Y > square.Y))
                {
                    if (LastClicked == 3)
                    {
                        label1.Text = "работает";
                        X = square.X;
                        Y = square.Y;
                        dX = squrX;
                        dY = squrY;
                        square.X = circle.X;
                        square.Y = circle.Y;
                        squrX = circX;
                        squrY = circY;
                        circle.X = X;
                        square.Y = Y;
                        squrX = dX;
                        squrY = dY;
                    }
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (rectClick)
            {
                rectangle.X = e.X - rectX;
                rectangle.Y = e.Y - rectY;
            }

            if (circClick)
            {
                circle.X = e.X - circX;
                circle.Y = e.Y - circY;
            }

            if (SqurClick)
            {
                square.X = e.X - squrX;
                square.Y = e.Y - squrY;
            }

            pictureBox1.Invalidate();

            if ((labelVid.Location.X < rectangle.X + rectangle.Width) && (labelVid.Location.X > rectangle.X))
            {
                if ((labelVid.Location.Y < rectangle.Y + rectangle.Height) && (labelVid.Location.Y > rectangle.Y))
                {
                    labelInfo.Text = "Черный прямульник";
                }
            }

            if ((labelVid.Location.X < circle.X + circle.Width) && (labelVid.Location.X > circle.X))
            {
                if ((labelVid.Location.Y < circle.Y + circle.Height) && (labelVid.Location.Y > circle.Y))
                {
                    labelInfo.Text = "Красный круг";
                }
            }

            if ((labelVid.Location.X < square.X + square.Width) && (labelVid.Location.X > square.X))
            {
                if ((labelVid.Location.Y < square.Y + square.Height) && (labelVid.Location.Y > square.Y))
                {
                    labelInfo.Text = "Розовый квадрат";
                }
            }

            



        }
    }
}
