using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            {
                // CurrentYear - BirthDate  
                DateTime startTime = Convert.ToDateTime(dateTimePicker1.Value);
                DateTime endTime = DateTime.Today;
                TimeSpan span = endTime.Subtract(startTime);
                var totalDays = span.TotalDays;
                var totalYears = Math.Truncate(totalDays / 365);
                var totalMonths = Math.Truncate((totalDays % 365) / 30);
                var remainingDays = Math.Truncate((totalDays % 365) % 30);
                textBox1.Text = string.Format("{0} year(s), {1} month(s) and {2} day(s)", totalYears, totalMonths, remainingDays);
            }
        }
    }
}
