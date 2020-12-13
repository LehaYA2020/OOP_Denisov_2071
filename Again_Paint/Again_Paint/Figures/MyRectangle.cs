using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Again_Paint
{
    class MyRectangle : Drawer
    {
        private int width = 2;

        private int height = 2;

        private int startX = 0;

        private int startY = 0;

        private Color color = Color.Black;

        public override Color Clr
        {
            get { return color; }
            set { color = value; }
        }
        public override int X
        {
            get
            {
                return startX;
            }
            set
            {
                startX = value;
            }
        }

        public override int Y
        {
            get
            {
                return startY;
            }
            set
            {
                startY = value;
            }
        }

        public override int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0 && value <= 500)
                {
                    width = value;
                }
                else { throw new Exception("Диапазон ширины от 0 до 500"); }
            }
        }

        public override int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 1 && value <= 500)
                {
                    height = value;
                }
            }
        }

        public MyRectangle(int x, int y, int width, int height)
        {
            this.startX = x;
            this.startY = y;
            this.width = width;
            this.height = height;
        }

        public override void Move(int deltaX, int deltaY, int eX, int eY)
        {
            base.Move(deltaX, deltaY, eX, eY);
        }

        public override void Draw(Graphics G)
        {
            G.DrawRectangle(new Pen(new SolidBrush(Clr), 2), startX - Width / 2, startY - Height / 2, Width, Height);
        }
        public override void DrawCargo(Graphics G)
        {
            G.FillRectangle(new SolidBrush(Clr), startX - Width / 2, startY - Height / 2, Width, Height);
        }

        public override bool IsPointInside(int x, int y)
        {
            if ((x > this.startX - Width / 2) && (x < this.startX + Width / 2) && (y > this.startY - Height / 2) && (y < this.startY + Height / 2))
            {
                return true;
            }
            else { return false; }
        }
    }
}