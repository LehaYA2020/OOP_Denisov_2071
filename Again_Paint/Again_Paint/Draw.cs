using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Again_Paint
{
    class Drawer
    {
        private int width=2;
        private int height=2;
        private Color color= Color.Black;
        public int Width
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
        public int Height { get { return height; } set { if (value > 1 && value <= 10) { height = value; } } }
        public Color Clr
        {
            get { return color; }
            set { color = value; }
        }
        public virtual void Draw(int x, int y, Graphics G)
        {
            G.FillRectangle(new SolidBrush(color), x, y, width, width);
        }
    }
}
