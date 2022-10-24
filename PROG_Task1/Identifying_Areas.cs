using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_Task1
{
    public partial class Identifying_Areas : Form
    {
        int count = 0;
        int win = 0;

        IDictionary<int, string> callNums = new Dictionary<int, string>();
        IDictionary<int, string> descrips = new Dictionary<int, string>();
        Random rnd = new Random();
        int callNum;
        int callNum2;
        int callNum3;
        int callNum4;

        public void populate() 
        {
            callNums.Add(1, "000");
            callNums.Add(2, "100");
            callNums.Add(3, "200");
            callNums.Add(4, "300");
            callNums.Add(5, "400");
            callNums.Add(6, "500");
            callNums.Add(7, "600");
            callNums.Add(8, "700");
            callNums.Add(9, "800");
            callNums.Add(10, "900");

            descrips.Add(1,"Knowledge about many things");
            descrips.Add(2,"Systematic study of the interplay between philosophical concerns in the study of cognition");
            descrips.Add(3,"Faith in a higher power");
            descrips.Add(4,"The study of human behaviour and social aspects");
            descrips.Add(5,"How humans express verbally/writtenly");
            descrips.Add(6,"Study of the structure and behaviour of the physical and natural world via observation/experiment");
            descrips.Add(7,"Application of scientific knowledge for practical purposes");
            descrips.Add(8,"Provide services to meet varied cultural");
            descrips.Add(9,"Imaginative works of poetry");
            descrips.Add(10,"Geographic phenomena have changed over time");


        }

        public Identifying_Areas()
        {
            InitializeComponent();
        }

        private void menuBTN_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Identifying_Areas_Load(object sender, EventArgs e)
        {
            populate();

            foreach (KeyValuePair<int, String> d in descrips)
            {
                descripBox.Items.Add(d.Value);
            }

            callNumberCreate();
        }

        public void callNumberCreate()
        {
            callNum = rnd.Next(9) + 1;

            
            callNum2 = rnd.Next(9) + 1;
            if(callNum2 == callNum)
            {
                callNum2 = rnd.Next(9) + 1;
            }


            callNum3 = rnd.Next(9) + 1;
            if(callNum3 == callNum2 || callNum3 == callNum)
            {
                callNum3 = rnd.Next(9) + 1;
            }

            callNum4 = rnd.Next(9) + 1;
            if(callNum4==callNum3 || callNum4==callNum2 || callNum4 == callNum)
            {
                callNum4 = rnd.Next(9) + 1;
            }


            first.Text = callNums[callNum];
            second.Text = callNums[callNum2];
            third.Text = callNums[callNum3];
            fourth.Text = callNums[callNum4];

        }

        private void CHECK_Click(object sender, EventArgs e)
        {
            count++;
            if (descripBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select A Description");
            }
            else
            {

                int key = descripBox.SelectedIndex + 1;

                if (count == 1)
                {
                    ASSESS(callNum, key);

                }
                else if (count == 2)
                {
                    ASSESS(callNum2, key);

                }

                else if (count == 3)
                {
                    ASSESS(callNum3, key);

                }

                else
                {
                    ASSESS(callNum4, key);


                }

            }
        }

        public void ASSESS(int anikey, int key)
        {


            if (anikey == key)
            {
                win++;

                if (count == 1)
                {
                    first.Text = callNums[callNum];
                    label1.Visible = true;
                    second.Text = "-> " + callNums[callNum2];


                }
                else if (count == 2)
                {
                    second.Text = callNums[callNum2];
                    label2.Visible = true;
                    third.Text = callNums[callNum3];


                }

                else if (count == 3)
                {

                    third.Text = callNums[callNum3];
                    label3.Visible = true;
                    fourth.Text = "-> " + callNums[callNum4];

                }

                else if (count == 4)
                {
                    fourth.Text = callNums[callNum4];
                    label4.Visible = true;
                    //Form1 f = new Form1();
                    // f.Show();
                    //this.Hide();



                }


            }


            else
            {

                if (count == 1)
                {
                    first.Text = callNums[callNum];
                    label5.Visible = true;
                    second.Text = "-> " + callNums[callNum2];


                }
                else if (count == 2)
                {
                    second.Text = callNums[callNum2];
                    label6.Visible = true;
                    third.Text = "-> " + callNums[callNum3];


                }

                else if (count == 3)
                {

                    third.Text = callNums[callNum3];
                    label7.Visible = true;
                    fourth.Text = "-> " + callNums[callNum4];

                }

                else if (count == 4)
                {
                    fourth.Text = callNums[callNum4];
                    label8.Visible = true;

                    if (win != 4)
                    {
                        MessageBox.Show("You LOOSE ! TRY AGAIN");

                        Form1 f = new Form1();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("You WON ! PLAY AGAIN");
                        Form1 f = new Form1();
                        f.Show();
                        this.Hide();
                    }

                }



            }
        }
    }

}
