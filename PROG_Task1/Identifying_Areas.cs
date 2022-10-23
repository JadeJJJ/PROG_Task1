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

            descrips.Add(1, "knowledge about many things");
            descrips.Add(2, "systematic study of the interplay between philosophical concerns in the study of cognition");
            descrips.Add(3, "Faith in a higher power");
            descrips.Add(4, "The study of human behaviour and social aspects");
            descrips.Add(5, "How humans express verbally/writtenly");
            descrips.Add(6, "study of the structure and behaviour of the physical and natural world via observation/experiment");
            descrips.Add(7, "application of scientific knowledge for practical purposes");
            descrips.Add(8, " provide services to meet varied cultural");
            descrips.Add(9, "imaginative works of poetry");
            descrips.Add(10, "geographic phenomena have changed over time");


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

            foreach (KeyValuePair<int, String> f in descrips)
            {
                descripBox.Items.Add(f.Value);
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
    }

}
