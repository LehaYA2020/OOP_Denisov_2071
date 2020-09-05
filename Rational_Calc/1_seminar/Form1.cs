using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_seminar
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void bttnSum_Click(object sender, EventArgs e)
        {
            int Chisl_1 = Convert.ToInt32(textBox1.Text);
            int Znam_1 = Convert.ToInt32(textBox2.Text);
            int Chisl_2 = Convert.ToInt32(textBox3.Text);
            int Znam_2 = Convert.ToInt32(textBox4.Text);
            Rational x = new Rational(Chisl_1,Znam_1);
            Rational y = new Rational(Chisl_2, Znam_2);
            Rational z = x.Sum(y);
            textBox5.Text = Convert.ToString(z.numerator);
            textBox6.Text = Convert.ToString(z.denumerator);
        }

        private void bttnSubtraction_Click(object sender, EventArgs e)
        {
            int Chisl_1 = Convert.ToInt32(textBox1.Text);
            int Znam_1 = Convert.ToInt32(textBox2.Text);
            int Chisl_2 = Convert.ToInt32(textBox3.Text);
            int Znam_2 = Convert.ToInt32(textBox4.Text);
            Rational x = new Rational(Chisl_1, Znam_1);
            Rational y = new Rational(Chisl_2, Znam_2);
            Rational z = x.Subtraction(y);
            textBox5.Text = Convert.ToString(z.numerator);
            textBox6.Text = Convert.ToString(z.denumerator);
        }

        private void bttnMult_Click(object sender, EventArgs e)
        {
            int Chisl_1 = Convert.ToInt32(textBox1.Text);
            int Znam_1 = Convert.ToInt32(textBox2.Text);
            int Chisl_2 = Convert.ToInt32(textBox3.Text);
            int Znam_2 = Convert.ToInt32(textBox4.Text);
            Rational x = new Rational(Chisl_1, Znam_1);
            Rational y = new Rational(Chisl_2, Znam_2);
            Rational z = x.Mulryplier(y);
            textBox5.Text = Convert.ToString(z.numerator);
            textBox6.Text = Convert.ToString(z.denumerator);
        }

        private void bttnDiv_Click(object sender, EventArgs e)
        {
            int Chisl_1 = Convert.ToInt32(textBox1.Text);
            int Znam_1 = Convert.ToInt32(textBox2.Text);
            int Chisl_2 = Convert.ToInt32(textBox3.Text);
            int Znam_2 = Convert.ToInt32(textBox4.Text);
            Rational x = new Rational(Chisl_1, Znam_1);
            Rational y = new Rational(Chisl_2, Znam_2);
            Rational z = x.Division(y);
            textBox5.Text = Convert.ToString(z.numerator);
            textBox6.Text = Convert.ToString(z.denumerator);
        }
    }
}
