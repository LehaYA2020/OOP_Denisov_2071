using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calendar
{
    class Date
    {
        private int day, month, year;
        private int[] mnths = { 21, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
            }
        }
        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                month = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public Date()
        {
            day = DateTime.Now.Day;
            month = DateTime.Now.Month;
            year = DateTime.Now.Year;
        }

        public void Today(TextBox _day, TextBox mnth, TextBox _year)
        {
            day = DateTime.Now.Day;
            month = DateTime.Now.Month;
            year = DateTime.Now.Year;
        }

        public void Visual(TextBox _day, TextBox mnth, TextBox _year)
        {
            _day.Text = Convert.ToString(day);
            mnth.Text = Convert.ToString(month);
            _year.Text = Convert.ToString(year);
        }
        public void SetDate(int _day, int _mnth, int _year, Label lbl)
        {
            int sum = 0;
            year = _year;
            if ((year % 4 == 0 && year % 100 != 0) || (year % 4 == 0 && year % 400 == 0))
            {
                mnths[1] = 29;
                sum++;
            }
            if (_mnth <= 12)
            {
                month = _mnth;
                sum++;
            }
            else { lbl.Text = "Такого месяца нет"; }

            if (_day<=mnths[month-1])
            {
                day = _day;
                sum++;
            }
            else { lbl.Text = "В этом месяце не столько дней"; }

            if(sum==3)
            {
                lbl.Text = "Дата задана.";
            }

        }

        public void NextDate()
        {


            if ((year % 4 == 0 && year % 100 != 0) || (year % 4 == 0 && year % 400 == 0))
            {
                mnths[1] = 29;
            }
            if (month >= 12 && day >= mnths[month - 1] + 1)
            {
                year++;
                month = 1;
                day = 1;
            }
            if (day >= mnths[month - 1] + 1)
            {
                day = 1;
                month++;
            }
            day++;

        }
    }
}
