using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PROG_Task1
{
    public partial class Identifying_Areas : Form
    {   //Allows the stopwatch function to work
        Stopwatch stopwatch;
        int count = 0;
        
        //Call Number Dicitonary
        IDictionary<int, string> callNums = new Dictionary<int, string>();
        //Descriptions Dictionary
        IDictionary<int, string> descrips = new Dictionary<int, string>();
        
        //Used to choose random Numbers
        Random rand = new Random();
        int callNum;
        int callNum2;
        int callNum3;
        int callNum4;

        public void populate() 
        {
            //Populating the Call number Dictionary
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

            //Populating the description dictionary
            descrips.Add(1,"Knowledge about many things");
            descrips.Add(2,"Study of the interplay between philosophical concerns in the study of cognition");
            descrips.Add(3,"Faith in a higher power");
            descrips.Add(4,"The study of human behaviour and social aspects");
            descrips.Add(5,"How humans express verbally/writtenly");
            descrips.Add(6,"Study of the behaviour of the physical/natural world via observation/experiment");
            descrips.Add(7,"Application of scientific knowledge for practical purposes");
            descrips.Add(8,"Provide services to meet varied cultural");
            descrips.Add(9,"Imaginative works of poetry");
            descrips.Add(10,"Geographic phenomena have changed over time");


        }

        public Identifying_Areas()
        {
            InitializeComponent();
        }

        //Formats the Tabel to act as a stopwatch
        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = string.Format("{0:hh\\:mm\\:ss\\.ff}", stopwatch.Elapsed);
        }


        //When the user clicks the menu button,they are directed to the menu/selection screen
        private void menuBTN_Click(object sender, EventArgs e)
        {
            //When the user Clicks Menu,they are directed to the Home/selection Page
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Identifying_Areas_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
            
            //The dictionaries are populated with the Call numbers and Descriptions
            populate();

            // The Descriptions are added to the listBox
            foreach (KeyValuePair<int, String> d in descrips)
            {
                descripBox.Items.Add(d.Value);
            }

            callNumberCreate();
        }


        //Uses the random function to select a number from 1 - 10 which coreelates with the Call number stored in the Dictionary
        public void callNumberCreate()
        {
            callNum = rand.Next(9) + 1;

            
            //If the Call Number selected for the 2nd question is the same,it tries again.
            callNum2 = rand.Next(9) + 1;
            if(callNum2 == callNum)
            {
                callNum2 = rand.Next(9) + 1;
            }


            callNum3 = rand.Next(9) + 1;
            if(callNum3 == callNum2 || callNum3 == callNum)
            {
                callNum3 = rand.Next(9) + 1;
            }

            callNum4 = rand.Next(9) + 1;
            if(callNum4==callNum3 || callNum4==callNum2 || callNum4 == callNum)
            {
                callNum4 = rand.Next(9) + 1;
            }

            //Populates the Textboxes with the random Call Numbers e.g 000
            first.Text = callNums[callNum];
            second.Text = callNums[callNum2];
            third.Text = callNums[callNum3];
            fourth.Text = callNums[callNum4];

        }

        //Whenever the user selects a description, they use the Click Button to check the answer
        private void CHECK_Click(object sender, EventArgs e)
        {
            
            count++;
            //If no description has been selected and Message will pop up
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

        public void ASSESS(int callkey, int key)
        {


            if (callkey == key)
            {
                

                if (count == 1)
                {
                    first.Text = callNums[callNum];
                    label1.Visible = true;
                    second.Text = ">" + callNums[callNum2]+"<";
                }
                else if (count == 2)
                {
                    second.Text = callNums[callNum2];
                    label2.Visible = true;
                    third.Text = ">"+callNums[callNum3]+"<";
                }

                else if (count == 3)
                {
                    third.Text = callNums[callNum3];
                    label3.Visible = true;
                    fourth.Text = ">" + callNums[callNum4]+"<";
                }

                else if (count == 4)
                {
                    fourth.Text = callNums[callNum4];
                    label4.Visible = true;
                }
             }
            else
            {

                if (count == 1)
                {
                    first.Text = callNums[callNum];
                    label5.Visible = true;
                    second.Text = ">" + callNums[callNum2]+"<";
                }
                else if (count == 2)
                {
                    second.Text = callNums[callNum2];
                    label6.Visible = true;
                    third.Text = ">" + callNums[callNum3]+"<";
                }

                else if (count == 3)
                {
                    third.Text = callNums[callNum3];
                    label7.Visible = true;
                    fourth.Text = ">" + callNums[callNum4]+"<";
                }

                else if (count == 4)
                {
                    fourth.Text = callNums[callNum4];
                    label8.Visible = true;
                    stopwatch.Stop();
                    startBTN.Text = "STOP";
                }
              }
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            //When the user presses start the Timer starts
            stopwatch.Start();
            if (startBTN.Text.Equals("START"))
            {
                //User can only start playing after the timer has started,once started the Button will become usable.
                CHECK.Visible = true;
                startBTN.Text = "STOP";
            }
            else
            {
                stopwatch.Stop();
            }
        }

        private void resetBTN_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            Identifying_Areas f2 = new Identifying_Areas();
            f2.Show();
            this.Hide();
        }
    }
}
//----------------------------------------------------END 0F PR0GR@M-------------------------------------------------------------------------------------------------
//---------------------------------------------By @J@DE J@ll@HR$-----------------------------------------------------------------------------------------------------