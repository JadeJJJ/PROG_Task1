using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_Task1
{
    public partial class Finding_Call_Numbers : Form
    {
        Stopwatch stopwatch;
        public Finding_Call_Numbers()
        {
            InitializeComponent();
        }

        private void Finding_Call_Numbers_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            //When the user presses start the Timer starts
            stopwatch.Start();
            if (start_btn.Text.Equals("START"))
            {

                start_btn.Text = "STOP";
            }
            else
            {
                stopwatch.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            Finding_Call_Numbers f2 = new Finding_Call_Numbers();
            f2.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = string.Format("{0:hh\\:mm\\:ss\\.ff}", stopwatch.Elapsed);
        }
    }
}
