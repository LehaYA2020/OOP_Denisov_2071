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
        private int length;
        private List<MyWagon> Wagons = new List<MyWagon>();
        private int weightSum;

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
        public  int Length
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
            MyWagon Wagon;
            Random rnd = new Random();
            Random rndWagon = new Random();
            for (int i = 1; i <= Length; i++)
            {
                int rndWag = rndWagon.Next(2);
                if (rndWag == 1)
                {
                    Wagon = new CoalWagon(x, y, L);
                    Wagon.Weight = rnd.Next(100);
                    Wagons.Add(Wagon);
                    x += (Wagon.Width + 4);
                }
                if (rndWag == 0)
                {
                    Wagon = new SandWagon(x, y, L);
                    Wagon.Weight = rnd.Next(100);
                    Wagons.Add(Wagon);
                    x += (Wagon.Width + 4);
                }

            }
        }
        public override void Move(int StartX, int StartY, int eX, int eY)
        {
            foreach (MyWagon item in Wagons)
            {
                item.Move(StartX, StartY, eX, eY);

                eX += (item.Width + 4);
            }
        }
        public override bool IsPointInside(int Ex, int Ey)
        {
            foreach (MyWagon item in Wagons)
            {
                if (item.IsPointInside(Ex, Ey)) { return true; }
                return false;
            }
            return false;
        }
        public override int WeightSum()
        {
            foreach (MyWagon item in Wagons)
            {
                weightSum += item.Weight;
            }
            return weightSum;
        }
    }
}