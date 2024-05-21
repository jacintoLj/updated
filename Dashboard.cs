using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Grooming
{
    public partial class Dashboard : Form
    {
        int month, year;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays() 
        {
            DateTime now = DateTime.Now; 
            month = now.Month;
            year = now.Year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labelMonth.Text = monthname + " " + year;

            DateTime startofMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int weekdays = Convert.ToInt32(startofMonth.DayOfWeek.ToString("d"));
            
            for (int i = 0; i < weekdays; i++) 
            {
                UserControlBlank ucblank = new UserControlBlank();
                datecontainer.Controls.Add(ucblank);
            } 
            for (int i = 1;  i <= days; i++) 
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                datecontainer.Controls.Add(ucdays);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            datecontainer.Controls.Clear();
            month--;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labelMonth.Text = monthname + " " + year;

            DateTime startofMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int weekdays = Convert.ToInt32(startofMonth.DayOfWeek.ToString("d"));

            for (int i = 0; i < weekdays; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                datecontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                datecontainer.Controls.Add(ucdays);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            datecontainer.Controls.Clear();
            month++;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labelMonth.Text = monthname + " " + year;

            DateTime startofMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int weekdays = Convert.ToInt32(startofMonth.DayOfWeek.ToString("d"));

            for (int i = 0; i < weekdays; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                datecontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                datecontainer.Controls.Add(ucdays);
            }
        }
    }
}
