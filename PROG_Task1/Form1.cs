using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PROG_Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Directed to Identifying Areas page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Identify_btn_Click(object sender, EventArgs e)
        {
            
            Identifying_Areas IA = new Identifying_Areas();
            IA.Show();
            this.Hide();
        }

        /// <summary>
        /// Directed to Replacing Books
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Replace_btn_Click(object sender, EventArgs e)
        {
            Replacing_Books rb = new Replacing_Books();
            rb.Show();
            this.Hide();
        }

        /// <summary>
        /// Directed to finding Call Numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void callNum_btn_Click(object sender, EventArgs e)
        {
            if (File.Exists(Database.textFile))
            {
                Finding_Call_Numbers fcn = new Finding_Call_Numbers();
                fcn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("CHECK FILE PATH");
            }
            
        }
        /// <summary>
        /// On Page Load,data is being read from TextFile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Database.readData();
        }
    }
}
//----------------------------------------------------END 0F PR0GR@M-------------------------------------------------------------------------------------------------
