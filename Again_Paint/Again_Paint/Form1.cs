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
        bool isDown = false;
        int x;
        int y;

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

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Paint_Load(object sender, EventArgs e)
        {
            G = pictureBox1.CreateGraphics();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(Convert.ToString(e.X) + " " + Convert.ToString(e.Y));
            if (draw.IsPointInside(e.X, e.Y))
            {
                MessageBox.Show("Loles");
            }
            else { MessageBox.Show("Suck"); }
        }

        private void bttnClean_Click(object sender, EventArgs e)
        {
            G.Clear(pictureBox1.BackColor);
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

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Drawer r in figures)
            {
                r.Draw(G);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(figures.Count + " " + figures[0].X + " " + figures[0].Y + " " + figures[0].Radious);
        }

        private void coordinatesX_MouseClick(object sender, MouseEventArgs e)
        {
            coordinatesX.Clear();
        }

        private void coordinatesY_MouseClick(object sender, MouseEventArgs e)
        {
            coordinatesY.Clear();
        }
    }
}