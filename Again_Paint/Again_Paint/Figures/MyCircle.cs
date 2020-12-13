﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace Again_Paint
{
    class MyCircle : Drawer
    {
        private int radious = 2;

        private Color color = Color.Black;

        private int startX = 0;

        private int startY = 0;

        public override int Radius
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
                return startX;
            }
            set
            {
                startX = value;
            }
        }

        public override int Y
        {
            get
            {
                return startY;
            }
            set
            {
                startY = value;
            }
        }

        public override Color Clr
        {
            get { return color; }
            set { color = value; }
        }

        public MyCircle(int x, int y, int radious)
        {
            this.startX = x;
            this.startY = y;
            this.radious = radious;
        }

        public override void Move(int deltaX, int deltaY, int eX, int eY)
        {
            base.Move(deltaX, deltaY, eX, eY);
        }
        public override void Draw(Graphics G)
        {
            G.DrawEllipse(new Pen(new SolidBrush(Clr), 3), startX - Radius / 2, startY - Radius / 2, Radius, Radius);
        }

        public override bool IsPointInside(int x, int y)
        {
            if (Math.Pow((x - this.startX), 2) + Math.Pow((y - this.startY), 2) <= Math.Pow(Radius / 2, 2))
            {
                return true;
            }
            else { return false; }
        }
    }
}