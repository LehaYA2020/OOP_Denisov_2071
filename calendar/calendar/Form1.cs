using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calendar
{
    public partial class Form1 : Form
    {
        Date date;
        public Form1()
        {
            InitializeComponent();
        }

        private void setDateBttn_Click(object sender, EventArgs e)
        {
            date = new Date();
            date.Visual(textBoxDay, textBoxMnth, textBoxYear);
        }

        private void nextDateBttn_Click(object sender, EventArgs e)
        {
            date.NextDate();
            date.Visual(textBoxDay, textBoxMnth, textBoxYear);
        }

        private void bttnSet_Click(object sender, EventArgs e)
        {
            date = new Date();
            int day = Convert.ToInt32(textBoxDay.Text);
            int mnth = Convert.ToInt32(textBoxMnth.Text);
            int year = Convert.ToInt32(textBoxYear.Text);
            date.SetDate(day, mnth, year, label4);
        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMnth_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
