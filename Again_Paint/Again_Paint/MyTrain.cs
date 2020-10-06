using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Again_Paint
{
    class MyTrain : MyWagon
    {
        private int x, y, l, length;
        private MyWagon Wagon;
        private List<MyWagon> Wagons = new List<MyWagon>();

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
        public override int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public MyTrain(int x, int y, int l, int length) : base(x, y, l)
        {
            L = l;
            Length = length;
            WagonsAdding(x, y);
        }
        public override void Draw(Graphics G)
        {
            foreach (MyWagon item in Wagons)
            {
                item.Draw(G);
            }
        }
        public override void WagonsAdding(int x, int y)
        {
            for (int i = 1; i <= Length; i++)
            {
                Wagon = new MyWagon(x, y, L);
                Wagons.Add(Wagon);
                x += (Wagon.Width + 4);
            }
        }
    }
}
