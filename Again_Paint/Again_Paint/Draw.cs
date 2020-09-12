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
        private int width = 50;
        private Color color;
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
        public virtual void Draw(int x, int y, Graphics G)
        {
            G.FillRectangle(Brushes.Black, x, y, width, width);
        }
    }
}
