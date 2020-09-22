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
        public override void Draw(int x, int y, Graphics G)
        {
            G.DrawEllipse(new Pen(new SolidBrush(Clr), 3), x - Width / 2, y - Width / 2, Width, Width);
        }
    }
}
