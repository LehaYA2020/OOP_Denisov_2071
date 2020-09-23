using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Again_Paint
{
    class MyCyrcle : Drawer
    {
        private int radious = 2;

        private Color color = Color.Black;

        private int x = 0;

        private int y = 0;
        private bool inside = false;

        public int Radious
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
        public int X
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
        public int Y
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
        public Color Clr
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


        public override void Draw(int x, int y, Graphics G)
        {
            G.DrawEllipse(new Pen(new SolidBrush(Clr), 3), x - Radious / 2, y - Radious / 2, Radious, Radious);
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
