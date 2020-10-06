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
        Drawer MovingItem;
        bool isDown = false;
        int deltaX = 0;
        int deltaY = 0;

        Graphics G;
        public Paint()
        {
            InitializeComponent();
        }

        private void Paint_Load(object sender, EventArgs e)
        {
            G = panel1.CreateGraphics();
        }



        private void bttnClean_Click(object sender, EventArgs e)
        {
            G.Clear(panel1.BackColor);
            figures.Clear();
        }

        private void button_Color_Click(object sender, EventArgs e)
        {
            ColorDialog tmpDialog = new ColorDialog();
            tmpDialog.ShowDialog();
            button_Color.BackColor = tmpDialog.Color;
            draw.Clr = tmpDialog.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(figures.Count);
            //draw = new MyWagon(333, 333, 150);
            //draw.Draw(G);
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
            panel1.Invalidate();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Drawer item in figures)
            {
                if (item.IsPointInside(e.X, e.Y) && radioButton3.Checked)
                {
                    deltaX = e.X - item.X;
                    deltaY = e.Y - item.Y;
                    isDown = true;
                    MovingItem = item;
                }
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown && radioButton3.Checked)
            {
                MovingItem.Move(deltaX, deltaY, e.X, e.Y);
                panel1.Invalidate();
            }
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            panelCir.Visible = true;
            panelRec.Visible = false;
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            panelCir.Visible = false;
            panelRec.Visible = true;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked)
            {
                int Radius = (int)RadiusValue.Value;
                draw = new MyCircle(e.X, e.Y, Radius);
            }
            if (radioButton2.Checked)
            {
                int Width = (int)WidthValue.Value;
                int Height = (int)HeightValue.Value;
                draw = new MyRectangle(e.X, e.Y, Width, Height);
            }
            if (radioButton4.Checked)
            {
                int L = (int)lValue.Value;
                draw = new MyWagon(e.X, e.Y, L);
                draw.Draw(G);
                draw.Weight(e.X, e.Y, G);
            }
            if (radioButton5.Checked)
            {
                int length = 4;
                int L = (int)lValue.Value;
                draw = new MyTrain(e.X, e.Y, L, length);
            }
            if (radioButton3.Checked)
            {
            }
            figures.Add(draw);
        }
    }
}