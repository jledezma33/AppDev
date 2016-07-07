using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTimesheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter = 0;

       /* private void button1_Click(object sender, EventArgs e)
        {
            TimeSheet.Day d = new TimeSheet.Day(new DateTime(2016,2,3));
            //MessageBox.Show("You clicked the button", "Box caption", MessageBoxButtons.OK);
            //label1.Text = "Button clicked " + ++ counter + " times";
            label1.Text = String.Format("Button clicked {0} times. {1}", ++counter, "Yay" );
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            double timeForWeek = 0, placeholder = 0;
            Double.TryParse(textBox1.Text, out placeholder);
            timeForWeek += placeholder;
            Double.TryParse(textBox9.Text, out placeholder);
            timeForWeek += placeholder;
            label1.Text = timeForWeek.ToString();
        }

    }
}
