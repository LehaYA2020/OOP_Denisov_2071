using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Again_Paint
{
    class MyWagon : Drawer
    {
        private MyRectangle Body;

        private MyCircle Wheel_1, Wheel_2;

        private int l = 2;

        private int width, height, x, y, radius, weight;
        private Random rnd = new Random();
        public override int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public override int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public override int L
        {
            get
            {
                return l;
            }
            set
            {
                l = value;
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
                width = value;
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
                height = value;
            }
        }
        public override int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }


        //public override int Radius
        //{
        //    get
        //    {
        //        return radius;
        //    }
        //    set
        //    {
        //        radius = value;
        //    }
        //}

        public MyWagon(int x, int y, int l)
        {
            L = l;

            height = l / 2;

            width = l;

            weight = rnd.Next(100);

            radius = width / 5;

            Body = new MyRectangle(x, y, width, height);

            Wheel_1 = new MyCircle(x - width / 3, y + height / 2 + (width / 5) / 2 + 1, radius);

            Wheel_2 = new MyCircle(x + width / 3, y + height / 2 + (width / 5) / 2 + 1, radius);
        }
        public override void Draw(Graphics G)
        {
            Body.Draw(G);
            Wheel_1.Draw(G);
            Wheel_2.Draw(G);
            G.DrawString(Convert.ToString(weight), new Font("Arial", L / 4), Brushes.Black, Body.X - L / 4, Body.Y - L / 4);
        }
        public override void Move(int StartX, int StartY, int eX, int eY)
        {
            Body.X = eX - x;
            Body.Y = eY - y;
            Wheel_1.X = eX - x - width / 4;
            Wheel_1.Y = eY - y + height / 2 + (width / 5) / 2 + 2;
            Wheel_2.X = eX - x + width / 4;
            Wheel_2.Y = eY - y + height / 2 + (width / 5) / 2 + 2;
        }
        public override bool IsPointInside(int Ex, int Ey)
        {
            if (Body.IsPointInside(Ex, Ey))
            {
                return true;
            }

            if (Wheel_1.IsPointInside(Ex, Ey))
            {
                return true;

            }

            if (Wheel_2.IsPointInside(Ex, Ey))
            {
                return true;
            }
            else { return false; }
        }
    }
}
