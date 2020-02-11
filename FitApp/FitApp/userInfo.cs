using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FitApp
{

    public partial class userInfo : Form
    {
        public userInfo()
        {
            InitializeComponent();
        }


        //Defines a path for the user text file
        public string userPath = @"..\user.txt";


        private void userInfo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Writes the username and goal to the text file
            using (var tw = new StreamWriter(userPath, true))
            {
                tw.WriteLine(textBox1.Text);
                tw.WriteLine(textBox2.Text);
            }
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

