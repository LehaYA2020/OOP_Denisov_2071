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
        public virtual void Draw(int x, int y, Graphics G)
        {
        }
        public virtual void Move(int x, int y)
        {

        }
        public virtual bool IsPointInside(int x, int y)
        {
            return false;
        }
    }
}
