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
        bool isDown = false;
        Graphics G;
        public Paint()
        {
            InitializeComponent();
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            draw = new MyCyrcle();
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
            draw.Draw(e.X, e.Y, G);
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
            draw = new MyRectangle();
        }

        private void button_Color_Click(object sender, EventArgs e)
        {
            ColorDialog tmpDialog = new ColorDialog();
            tmpDialog.ShowDialog();
            button_Color.BackColor = tmpDialog.Color;
            draw.Clr = tmpDialog.Color;
        }
    }
}
