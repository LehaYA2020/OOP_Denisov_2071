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
        ColorDialog tmpDialog = new ColorDialog();
        Container c = new Container();

        Graphics G;
        public Paint()
        {
            InitializeComponent();
        }

        private void Paint_Load(object sender, EventArgs e)
        {
            G = panel1.CreateGraphics();
        }

        void fillContainer(object sender, MouseEventArgs e)
        {
            foreach (Drawer item in figures)
            {
                if (item.IsPointInside(e.X, e.Y) && AddRadioButton.Checked)
                {
                    //c.AddToContainer(item);
                    WeightSumVal.Text = "Y.";
                }
            }
        }
        private void bttnClean_Click(object sender, EventArgs e)
        {
            G.Clear(panel1.BackColor);
            WeightSumVal.Clear();
            figures.Clear();
        }

        private void button_Color_Click(object sender, EventArgs e)
        {
            tmpDialog.ShowDialog();
            button_Color.BackColor = tmpDialog.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //draw = new CoalWagon(333,333,60);
            //figures.Add(draw);
            //draw.Draw(G);

            //WeightSumVal.Text = Convert.ToString(figures.Count);
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
            panelTrain.Visible = false;
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            panelCir.Visible = false;
            panelRec.Visible = true;
            panelTrain.Visible = false;
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
            }
            if (radioButton5.Checked)
            {
                int length = (int)lengthValue.Value;
                int L = (int)lValue.Value;
                draw = new MyTrain(e.X, e.Y, L, length);
                WeightSumVal.Text = Convert.ToString(draw.WeightSum());
            }
            if (AddRadioButton.Checked)
            {
                foreach (Drawer item in figures)
                {
                    if (item.IsPointInside(e.X, e.Y))
                    {
                        c.AddToContainer(item);
                        WeightSumVal.Text = Convert.ToString(c.Count);
                    }
                }
            }
            if (radioButton3.Checked)
            {
            }

            draw.Draw(G);
            figures.Add(draw);
        }

        private void radioButton5_MouseClick(object sender, MouseEventArgs e)
        {
            panelCir.Visible = false;
            panelRec.Visible = false;
            panelTrain.Visible = true;
        }

        private void radioButton4_MouseClick(object sender, MouseEventArgs e)
        {
            panelCir.Visible = false;
            panelRec.Visible = false;
            panelTrain.Visible = true;
        }

        private void unloadBttn_Click(object sender, EventArgs e)
        {
            foreach (Drawer f in c)
            {
                f.Draw(G);
            }
        }
    }
}