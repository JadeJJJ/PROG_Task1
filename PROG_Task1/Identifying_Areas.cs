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
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        dictionary.Add(000, "Genral Knowlege");
        dictionary.Add(100, "philosophy & Psycology");
        dictionary.Add(200, "Religion");
        dictionary.Add(300, "Social Sciences");
        dictionary.Add(400, "Languages");
        dictionary.Add(500, "Science");
        dictionary.Add(600, "Techynology");
        dictionary.Add(700, "Arts & Recriation");
        dictionary.Add(800, "Litrature");
        dictionary.Add(900, "History and geography");

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
    }
}
