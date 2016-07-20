using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeSheet;

namespace TimeSheetWinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Control C in this.Controls)
            {
                if (C.GetType() == typeof(System.Windows.Forms.TextBox))
                {
                    lblOutput.Text += C.Name + " ";
                    lblOutput.Text += C.Text;
                }
            }

            //TimeCard card = new TimeCard(new DateTime(2016, 7, 3));

            //int offset = 0;

            //if (true)
            //{
            //    offset = 7;
            //} else
            //{
            //    offset = 0;
            //}

            //card.SetHours(0 + offset, TimeSheet.Day.HourTypes.REGULAR, Double.Parse(txtDay0.Text));
            //card.SetHours(1 + offset, TimeSheet.Day.HourTypes.REGULAR, Double.Parse(txtDay1.Text));
            //card.SetHours(2 + offset, TimeSheet.Day.HourTypes.REGULAR, Double.Parse(txtDay2.Text));

            //lblOutput.Text = card.GetHours(TimeSheet.Day.HourTypes.REGULAR).ToString();

        }
    }
}
