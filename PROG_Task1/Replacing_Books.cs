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
    public partial class Replacing_Books : Form
    {
        //List to store books
        List<Button> books = new List<Button>();
        Random rnd = new Random();
        Stopwatch stopwatch;
        public Replacing_Books()
        {
            InitializeComponent();

            //On start Up the Books are filled with the Call numbers 
            textbox1.Text = callnumber();
            textbox2.Text = callnumber();
            textbox3.Text = callnumber();
            textbox4.Text = callnumber();
            textbox5.Text = callnumber();
            textbox6.Text = callnumber();
            textbox7.Text = callnumber();
            textbox8.Text = callnumber();
            textbox9.Text = callnumber();
            textbox10.Text = callnumber();


            //Adds books to the list
            books.Add(textbox1);
            books.Add(textbox2);
            books.Add(textbox3);
            books.Add(textbox4);
            books.Add(textbox5);
            books.Add(textbox6);
            books.Add(textbox7);
            books.Add(textbox8);
            books.Add(textbox9);
            books.Add(textbox10);




        }
        //Call numbers are generated 
        public String callnumber()
        {
            String randomLetters = "";
            String randomNumbers1 = "";
            String randomNumbers2 = "";
            

            for (int i = 0; i < 3; i++)
            {
                int ascii_index = rnd.Next(65, 91);
                char RandomUpperCase = Convert.ToChar(ascii_index);
                randomLetters += RandomUpperCase;
                int randNum1 = rnd.Next(10);
                randomNumbers1 += randNum1;

                int randNum2 = rnd.Next(10);
                randomNumbers2 += randNum2;

            }
            String id = randomNumbers1 + "." + randomNumbers2 + " " + randomLetters;
            return id;
        }


       //Formats the Timer used in the application
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = string.Format("{0:hh\\:mm\\:ss\\.ff}", stopwatch.Elapsed);
        }

        private void Replacing_Books_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
        }


        private void start_btn_Click(object sender, EventArgs e)
        {
            //When the user presses start the Timer starts
            stopwatch.Start();

            if (start_btn.Text.Equals("START"))
            {

                //When the user clicks start, the books are draggable

                ControlExtension.Draggable(textbox1, true);
                ControlExtension.Draggable(textbox2, true);
                ControlExtension.Draggable(textbox3, true);
                ControlExtension.Draggable(textbox4, true);
                ControlExtension.Draggable(textbox5, true);
                ControlExtension.Draggable(textbox6, true);
                ControlExtension.Draggable(textbox7, true);
                ControlExtension.Draggable(textbox8, true);
                ControlExtension.Draggable(textbox9, true);
                ControlExtension.Draggable(textbox10, true);

                start_btn.Text = "STOP";


            }
            else
            {
               // Timer Stops
                stopwatch.Stop();
                
                Button temp;
                //Bubble sorting is used to sort the books once they have been stored in the list
                for (int j = 0; j <= books.Count - 2; j++)
                {
                    for (int k = 0; k <= books.Count - 2; k++)
                    {
                        String t1 = books[k].Text;
                        String t2 = books[k + 1].Text;

                        int temp1 = Int32.Parse(t1.Substring(0, 3));
                        int temp2 = Int32.Parse(t2.Substring(0, 3));

                        if (temp1 > temp2)
                        {
                            temp = books[k + 1];
                            books[k + 1] = books[k];
                            books[k] = temp;
                        }
                    }
                }

                try
                {
                    //Book locations are checked with the sorted List of books

                    Boolean flag = books[0].Location.X < books[1].Location.X &&
                                   books[1].Location.X < books[2].Location.X &&
                                   books[2].Location.X < books[3].Location.X &&
                                   books[3].Location.X < books[4].Location.X &&
                                  books[4].Location.X < books[5].Location.X &&
                                  books[5].Location.X < books[6].Location.X &&
                               books[6].Location.X < books[7].Location.X &&
                              books[7].Location.X < books[8].Location.X &&
                              books[8].Location.X < books[9].Location.X;


                    if (flag == true)
                    {
                        //If successfully sorted this message appears
                        MessageBox.Show("The Books have been correctly sorted!!");
                    }
                    else
                    {
                        //If unsuccessfully sorted this me
                        MessageBox.Show("The books have not been correctly sorted!!");
                    }
                }
                catch (Exception) { }
                



                //When the user presses Stop the Buttons are not dragable

                ControlExtension.Draggable(textbox1, false);
                ControlExtension.Draggable(textbox2, false);
                ControlExtension.Draggable(textbox3, false);
                ControlExtension.Draggable(textbox4, false);
                ControlExtension.Draggable(textbox5, false);
                ControlExtension.Draggable(textbox6, false);
                ControlExtension.Draggable(textbox7, false);
                ControlExtension.Draggable(textbox8, false);
                ControlExtension.Draggable(textbox9, false);
                ControlExtension.Draggable(textbox10, false);

                start_btn.Text = "START";
            }


        }



        private void reset_btn_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }


       
    }
}
