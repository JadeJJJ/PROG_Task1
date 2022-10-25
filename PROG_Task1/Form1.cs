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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Identify_btn_Click(object sender, EventArgs e)
        {
            
            Identifying_Areas IA = new Identifying_Areas();
            IA.Show();
            this.Hide();
        }

        private void Replace_btn_Click(object sender, EventArgs e)
        {
            Replacing_Books rb = new Replacing_Books();
            rb.Show();
            this.Hide();
        }

        private void callNum_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Finding Call Numbers Has Not Been Implemetned Yet!!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}