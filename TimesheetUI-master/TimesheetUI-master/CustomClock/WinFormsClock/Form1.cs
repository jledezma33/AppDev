using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsClock
{
    public partial class Form1 : Form, ClockLibrary.ITickable
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void TimeChanged(int elapsedSeconds)
        {
            label1.Text = elapsedSeconds.ToString();
            Application.DoEvents(); //this is a cheap shortcut because we're only using one thread
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClockLibrary.Clock c = new ClockLibrary.Clock();
            c.Start(this);
        }
    }
}
