﻿using System;
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
        private string operation;
        public int Chisl_1;
        public int Znam_1;
        public int Chisl_2;
        public int Znam_2;
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnSum_Click(object sender, EventArgs e)
        {
            operation = "+";
        }

        private void bttnSubtraction_Click(object sender, EventArgs e)
        {
            operation = "-";
        }

        private void bttnMult_Click(object sender, EventArgs e)
        {
            operation = "*";

        }

        private void bttnDiv_Click(object sender, EventArgs e)
        {
            operation = "/";
        }

        private void bttnClean_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void bttnEquality_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out Chisl_1) && int.TryParse(textBox2.Text, out Znam_1) && int.TryParse(textBox3.Text, out Chisl_2) && int.TryParse(textBox4.Text, out Znam_2))
            {
                Rational x = new Rational(Chisl_1, Znam_1);
                Rational y = new Rational(Chisl_2, Znam_2);
                switch (operation)
                {
                    case "+":
                        if (x.denumerator != 0 && y.denumerator != 0)
                        {
                            Rational z = x + y;
                            textBox5.Text = z.FracToString(z);
                        }
                        else { MessageBox.Show("Один из ваших знаменателей равен 0, исправьте!"); }
                        break;
                    case "-":
                        if (x.denumerator != 0 && y.denumerator != 0)
                        {
                            Rational z = x - y;
                            textBox5.Text = z.FracToString(z);
                        }
                        else { MessageBox.Show("Один из ваших знаменателей равен 0, исправьте!"); }
                        break;
                    case "*":

                        if (x.denumerator != 0 && y.denumerator != 0)
                        {
                            Rational z = x * y;
                            textBox5.Text = z.FracToString(z);
                        }
                        else { MessageBox.Show("Деление на 0 невозможно - проверьте введенные данные"); }
                        break;
                    case "/":
                        if (x.denumerator != 0 && y.numerator != 0 && y.denumerator != 0)
                        {
                            Rational z = x / y;
                            textBox5.Text = z.FracToString(z);
                        }
                        else { MessageBox.Show("Деление на 0 невозможно - проверьте введенные данные"); }
                        break;
                }
            }
            else { MessageBox.Show("Проверьте введенные данные"); }
        }
    }
}
