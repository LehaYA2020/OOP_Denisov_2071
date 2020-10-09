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
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public virtual int Radius { get; set; }
        public virtual int Length { get; set; }
        public virtual int Weight { get; set; }
        public virtual int L { get; set; }
        public virtual int X { get; set; }
        public virtual int Y { get; set; }
        public virtual Color Clr { get; set; }
        public virtual void WagonsAdding(int x, int y) 
        {

        }
        public virtual void Draw(Graphics G)
        {
        }
        public virtual void Move(int deltaX, int deltaY, int eX, int eY)
        {
            X = eX - deltaX;
            Y = eY - deltaY;
        }
        public virtual bool IsPointInside(int x, int y)
        {
            return false;
        }
        public virtual int WeightSum()
        {
            return 0;
        }
    }
}
