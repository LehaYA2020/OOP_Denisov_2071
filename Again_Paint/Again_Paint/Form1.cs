using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Again_Paint
{
    public partial class Paint : Form
    {
        List<Drawer> figures = new List<Drawer>();
        Drawer draw;
        Drawer Count;
        bool isDown = false;
        int x;
        int y;
        int deltaX = 0;
        int deltaY = 0;

        Graphics G;
        public Paint()
        {
            InitializeComponent();
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            draw = new MyCyrcle(50, 50, 50);
            panelCir.Visible = true;
            panelRec.Visible = false;
        }

        private void Paint_Load(object sender, EventArgs e)
        {
            G = panel1.CreateGraphics();
        }

        

        private void bttnClean_Click(object sender, EventArgs e)
        {
            G.Clear(panel1.BackColor);
        }

        private void WidthValue_ValueChanged(object sender, EventArgs e)
        {
            draw.Width = (int)WidthValue.Value;
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            draw = new MyRectangle(0, 0, 0, 0);
            panelRec.Visible = true;
            panelCir.Visible = false;
        }

        private void button_Color_Click(object sender, EventArgs e)
        {
            ColorDialog tmpDialog = new ColorDialog();
            tmpDialog.ShowDialog();
            button_Color.BackColor = tmpDialog.Color;
            draw.Clr = tmpDialog.Color;
        }

        private void RadiusValue_ValueChanged(object sender, EventArgs e)
        {
            draw.Radious = (int)RadiusValue.Value;
        }

        private void HeightValue_ValueChanged(object sender, EventArgs e)
        {
            draw.Height = (int)HeightValue.Value;
        }

        private void bttnPaint_Click(object sender, EventArgs e)
        {
            Assign();
            draw.X = Convert.ToInt32(coordinatesX.Text);
            draw.Y = Convert.ToInt32(coordinatesY.Text);
            draw.Draw(G);
            figures.Add(draw);
        }

        private void Assign()
        {
            x = Convert.ToInt32(coordinatesX.Text);
            y = Convert.ToInt32(coordinatesY.Text);
        }

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{
        //    foreach (Drawer r in figures)
        //    {
        //        r.Draw(G);
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(figures.Count );
        }

        private void coordinatesX_MouseClick(object sender, MouseEventArgs e)
        {
            coordinatesX.Clear();
        }

        private void coordinatesY_MouseClick(object sender, MouseEventArgs e)
        {
            coordinatesY.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Drawer r in figures)
            {
                r.Draw(G);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Drawer item in figures)
            {
                if (item.IsPointInside(e.X, e.Y))
                {
                    deltaX = e.X - item.X;
                    deltaY = e.Y - item.Y;
                    isDown = true;
                    Count = item;
                }
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown)
            {
                Count.X = e.X - deltaX;
                Count.Y = e.Y - deltaY;
                panel1.Invalidate();
            }
        }

        //private void panel1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    foreach (Drawer i in figures)
        //    {
        //        if (i.IsPointInside(e.X, e.Y))
        //        {
        //            deltaX = e.X - i.X;
        //            deltaY = e.Y - i.Y;
        //            isDown = true;
        //        }
        //    }
        //}

        //private void panel1_MouseUp(object sender, MouseEventArgs e)
        //{
        //    isDown = false;
        //    panel1.Invalidate();
        //}
    }
}