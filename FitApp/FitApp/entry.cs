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
    public partial class entry : Form
    {
        public entry()
        {
            InitializeComponent();
        }

        private void entry_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //This takes each number from the text boxes, adds them together and saves them to the proper text file
        private void button1_Click(object sender, EventArgs e)
        {
            int step = Convert.ToInt32(textBox1.Text);
            int cal = Convert.ToInt32(textBox2.Text);
            int stand = Convert.ToInt32(textBox3.Text);

            int sum = step + cal + stand;

            string cMonth = DateTime.Now.Month.ToString();
            int intMonth = Convert.ToInt32(cMonth);

            

            string path = @"..\monthlyReports\" + intMonth + @".txt";



            using (StreamWriter w = File.AppendText(path))
            {
                string v = Convert.ToString(sum);
                w.Write(sum + ",");
            }

            

            Close();


        }

      
    }
}
