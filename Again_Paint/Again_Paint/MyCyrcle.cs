using System;
using System.Collections.Generic;
using System.Drawing;

namespace Again_Paint
{
    class MyCyrcle : Drawer
    {
        private int radious = 2;

        private Color color = Color.Black;

        private int x = 0;

        private int y = 0;
        private bool inside = false;

        public override int Radious
        {
            get
            {
                return radious;
            }
            set
            {
                radious = value;
            }
        }
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
        public override Color Clr
        {
            get { return color; }
            set { color = value; }
        }

        public MyCyrcle(int x, int y, int radious)
        {
            this.x = x;
            this.y = y;
            this.radious = radious;
        }


        public override void Draw(Graphics G)
        {
            G.DrawEllipse(new Pen(new SolidBrush(Clr), 3), x - Radious / 2, y - Radious / 2, Radious, Radious);
        }

        public override void Move(int x, int y)
        {
        }
        public override bool IsPointInside(int x, int y)
        {
            if (x + Radious <= Radious && x - Radious >= Radious && y + Radious <= Radious && x - Radious >= Radious)
            {
                inside= true;
            }
            return inside;
        }
    }
}
