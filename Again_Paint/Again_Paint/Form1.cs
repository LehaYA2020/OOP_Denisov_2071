using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Again_Paint
{
    public partial class Paint : Form
    {
        Drawer draw = new Drawer();
        MyCyrcle Cyrcle;
        MyRectangle Rectangle;
        bool isDown = false;
        int x;
        int y;
        string figure;

        Graphics G;
        public Paint()
        {
            InitializeComponent();
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            Cyrcle = new MyCyrcle(50, 50, 50);
            figure = "Круг";
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
            if (Rectangle.IsPointInside(e.X, e.Y))
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
            Rectangle.Width = (int)WidthValue.Value;
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            Assign();
            Rectangle = new MyRectangle(x, y, 0, 0);
            figure = "Квадрат";
        }

        private void button_Color_Click(object sender, EventArgs e)
        {
            ColorDialog tmpDialog = new ColorDialog();
            tmpDialog.ShowDialog();
            button_Color.BackColor = tmpDialog.Color;
            switch (figure)
            {
                case ("Квадрат"):
                    Rectangle.Clr = tmpDialog.Color;
                    break;
                case ("Круг"):
                    Cyrcle.Clr = tmpDialog.Color;
                    break;
            }
        }

        private void RadiusValue_ValueChanged(object sender, EventArgs e)
        {
            Cyrcle.Radious = (int)RadiusValue.Value;
        }

        private void HeightValue_ValueChanged(object sender, EventArgs e)
        {
            Rectangle.Height = (int)HeightValue.Value;
        }

        private void bttnPaint_Click(object sender, EventArgs e)
        {
            Assign();
            switch (figure)
            {
                case ("Квадрат"):
                    Rectangle.Draw(x, y, G);
                    break;
                case ("Круг"):
                    Cyrcle.Draw(x, y, G);
                    break;
            }
        }
        private void Assign()
        {
            x = Convert.ToInt32(coordinatesX.Text);
            y = Convert.ToInt32(coordinatesY.Text);
        }
    }
}