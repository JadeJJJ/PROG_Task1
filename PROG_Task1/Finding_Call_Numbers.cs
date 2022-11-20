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
        int ques;
        Random rand = new Random();
        Boolean lastLevel = false;
        Stopwatch stopwatch;
        public Finding_Call_Numbers()
        {
            InitializeComponent();
        }

        private void Finding_Call_Numbers_Load(object sender, EventArgs e)
        {
            generateQuestion();
            stopwatch = new Stopwatch();
        }
        public void generateQuestion()
        {

            ques = rand.Next(0, 8);
            int quesl2 = rand.Next(0, 1);
            int option = rand.Next(0, 3);
            int op1 = rand.Next(0, 8);
            int op2 = rand.Next(0, 8);
            int op3 = rand.Next(0, 8);
            while (true)
            {
                if (op1 == op2 || op2 == ques)
                {
                    op2 = rand.Next(1, 8);
                }
                else if (op1 == op3 || op3 == ques)
                {
                    op3 = rand.Next(1, 8);
                }
                else if (op2 == op3 || op1 == ques)
                {
                    op3 = rand.Next(1, 8);

                }

                else
                {
                    break;
                }
            }

            try
            {
                String PrintQ = "";
                String q = Database.root.Children[ques].Children[quesl2].Children[option].Val() + "";
                q = q.Trim();
                String[] tokens = q.Split(' ');
                for (int i = 1; i < tokens.Length; i++)
                {
                    PrintQ = PrintQ + tokens[i] + " ";

                }

                Question.Text = PrintQ;

            }
            catch (Exception e)
            {

            }
            o1.Text = Database.root.Children[op1].Val();
            o2.Text = Database.root.Children[op2].Val();
            o3.Text = Database.root.Children[op3].Val();
            o4.Text = Database.root.Children[ques].Val();


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
                o1.Visible = true;
                o2.Visible = true;
                o3.Visible = true;
                o4.Visible = true;

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

        private void o1_Click(object sender, EventArgs e)
        {
            checkAnswer(sender);
        }

        private void o2_Click(object sender, EventArgs e)
        {
            checkAnswer(sender);
        }

        private void o3_Click(object sender, EventArgs e)
        {
            checkAnswer(sender);
        }

        private void o4_Click(object sender, EventArgs e)
        {
            checkAnswer(sender);
        }

        private void checkAnswer(object sender)
        {
            Label l = sender as Label;

            if (lastLevel == false)
            {

                if (l == o4)
                {
                    gotoLevel2();
                    lastLevel = true;

                }

                else
                {
                    MessageBox.Show("Wrong Answer!");
                }
            }
            else
            {
                if (l == o2)
                {
                    stopwatch.Stop();
                    MessageBox.Show("CONGRATS! GAME ENDED\n"+string.Format("{0:hh\\:mm\\:ss\\.ff}", stopwatch.Elapsed));
                    Finding_Call_Numbers fcn = new Finding_Call_Numbers();
                    fcn.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Answer");
                }

            }

        }

        private void gotoLevel2()
        {
            int options = rand.Next(0, 1);
            int quest = rand.Next(0, 8);
            int quest2 = rand.Next(0, 8);
            int quest3 = rand.Next(0, 8);
            int quest4 = rand.Next(0, 8);
            int oo1 = rand.Next(0, 2);
            int oo3 = rand.Next(0, 2);
            int oo4 = rand.Next(0, 2);



            o1.Text = Database.root.Children[quest4].Children[oo1].Val();
            o2.Text = Database.root.Children[ques].Children[options].Val();
            o3.Text = Database.root.Children[quest2].Children[oo3].Val();
            o4.Text = Database.root.Children[quest3].Children[oo4].Val();
        }
    }
}
