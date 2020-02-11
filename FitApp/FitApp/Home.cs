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

    public partial class Home : Form
    {
        public string userPath = @"..\user.txt";
        string currentMonth;
        
        public Home()
        {
            InitializeComponent();
            this.Text = "FitApp"; //Sets window title for the app

            //Opens window for user data if the user file does not exist
            if (File.Exists(userPath) != true)
            {
                userInfo user = new userInfo();
                user.ShowDialog();
            }

            //Reads user.txt if file already exists
            if (File.Exists(userPath) == true)
            {
                string userText = File.ReadAllText(userPath);
                userLabel.Text = userText;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userLabel_Click(object sender, EventArgs e)
        {

        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Defines current month variable
            currentMonth = DateTime.Now.ToString("MM");
            Convert.ToInt32(currentMonth);

            //Changes listbox2 based on index selected from listbox1
            if (listBox1.SelectedIndex == 0)
            {
                listBox2.Items.Clear();
                string monthPath = @"..\monthlyReports\1.txt";

                if (new FileInfo(monthPath).Length > 0)
                {
                    string[] newCont2 = File.ReadAllLines(monthPath);
                    foreach (string line in newCont2)
                    {
                        newCont2 = line.Split(',');
                    }

                    int arrayCount = (newCont2.Length);
                    int x = 0;

                    while (x < arrayCount)
                    {
                        listBox2.Items.Add(newCont2[x]);
                        x++;
                    }

                }

            }

            if (listBox1.SelectedIndex == 1)
            {
                listBox2.Items.Clear();
                string monthPath = @"..\monthlyReports\2.txt";

                if (new FileInfo(monthPath).Length > 0)
                {
                    string[] newCont3 = File.ReadAllLines(monthPath);
                    foreach (string line in newCont3)
                    {
                        newCont3 = line.Split(',');
                    }

                    int arrayCount = (newCont3.Length);
                    int x = 0;

                    while (x < arrayCount)
                    {
                        listBox2.Items.Add(newCont3[x]);
                        x++;
                    }

                }

            }

            if (listBox1.SelectedIndex == 2)
            {
                listBox2.Items.Clear();
                string monthPath = @"..\monthlyReports\3.txt";

                if (new FileInfo(monthPath).Length > 0)
                {
                    string[] newCont2 = File.ReadAllLines(monthPath);
                    foreach (string line in newCont2)
                    {
                        newCont2 = line.Split(',');
                    }

                    int arrayCount = (newCont2.Length);
                    int x = 0;

                    while (x < arrayCount)
                    {
                        listBox2.Items.Add(newCont2[x]);
                        x++;
                    }

                }
            }

            if (listBox1.SelectedIndex == 3)
            {
                listBox2.Items.Clear();
                string monthPath = @"..\monthlyReports\4.txt";

                if (new FileInfo(monthPath).Length > 0)
                {
                    string[] newCont2 = File.ReadAllLines(monthPath);
                    foreach (string line in newCont2)
                    {
                        newCont2 = line.Split(',');
                    }

                    int arrayCount = (newCont2.Length);
                    int x = 0;

                    while (x < arrayCount)
                    {
                        listBox2.Items.Add(newCont2[x]);
                        x++;
                    }

                }
            }

            if (listBox1.SelectedIndex == 4)
            {
                listBox2.Items.Clear();
                string monthPath = @"..\monthlyReports\5.txt";

                if (new FileInfo(monthPath).Length > 0)
                {
                    string[] newCont2 = File.ReadAllLines(monthPath);
                    foreach (string line in newCont2)
                    {
                        newCont2 = line.Split(',');
                    }

                    int arrayCount = (newCont2.Length);
                    int x = 0;

                    while (x < arrayCount)
                    {
                        listBox2.Items.Add(newCont2[x]);
                        x++;
                    }
                }
            }

            if (listBox1.SelectedIndex == 5)
            {
                listBox2.Items.Clear();
                string monthPath = @"..\monthlyReports\6.txt";

                if (new FileInfo(monthPath).Length > 0)
                {
                    string[] newCont2 = File.ReadAllLines(monthPath);
                    foreach (string line in newCont2)
                    {
                        newCont2 = line.Split(',');
                    }

                    int arrayCount = (newCont2.Length);
                    int x = 0;

                    while (x < arrayCount)
                    {
                        listBox2.Items.Add(newCont2[x]);
                        x++;
                    }

                }
            }

            if (listBox1.SelectedIndex == 6)
            {
                listBox2.Items.Clear();
                string monthPath = @"..\monthlyReports\7.txt";

                if (new FileInfo(monthPath).Length > 0)
                {
                    string[] newCont2 = File.ReadAllLines(monthPath);
                    foreach (string line in newCont2)
                    {
                        newCont2 = line.Split(',');
                    }

                    int arrayCount = (newCont2.Length);
                    int x = 0;

                    while (x < arrayCount)
                    {
                        listBox2.Items.Add(newCont2[x]);
                        x++;
                    }

                }
            }

            if (listBox1.SelectedIndex == 7)
            {
                listBox2.Items.Clear();
                string monthPath = @"..\monthlyReports\8.txt";

                if (new FileInfo(monthPath).Length > 0)
                {
                    string[] newCont2 = File.ReadAllLines(monthPath);
                    foreach (string line in newCont2)
                    {
                        newCont2 = line.Split(',');
                    }

                    int arrayCount = (newCont2.Length);
                    int x = 0;

                    while (x < arrayCount)
                    {
                        listBox2.Items.Add(newCont2[x]);
                        x++;
                    }

                }
            }

            if (listBox1.SelectedIndex == 8)
            {
                listBox2.Items.Clear();
                string monthPath = @"..\monthlyReports\9.txt";

                if (new FileInfo(monthPath).Length > 0)
                {
                    string[] newCont2 = File.ReadAllLines(monthPath);
                    foreach (string line in newCont2)
                    {
                        newCont2 = line.Split(',');
                    }

                    int arrayCount = (newCont2.Length);
                    int x = 0;

                    while (x < arrayCount)
                    {
                        listBox2.Items.Add(newCont2[x]);
                        x++;
                    }

                }
            }

            if (listBox1.SelectedIndex == 9)
            {
                listBox2.Items.Clear();
                string monthPath = @"..\monthlyReports\10.txt";

                if (new FileInfo(monthPath).Length > 0)
                {
                    string[] newCont2 = File.ReadAllLines(monthPath);
                    foreach (string line in newCont2)
                    {
                        newCont2 = line.Split(',');
                    }

                    int arrayCount = (newCont2.Length);
                    int x = 0;

                    while (x < arrayCount)
                    {
                        listBox2.Items.Add(newCont2[x]);
                        x++;
                    }

                }
            }

            if (listBox1.SelectedIndex == 10)
            {
                listBox2.Items.Clear();
                string monthPath = @"..\monthlyReports\11.txt";

                if (new FileInfo(monthPath).Length > 0)
                {
                    string[] newCont2 = File.ReadAllLines(monthPath);
                    foreach (string line in newCont2)
                    {
                        newCont2 = line.Split(',');
                    }

                    int arrayCount = (newCont2.Length);
                    int x = 0;

                    while (x < arrayCount)
                    {
                        listBox2.Items.Add(newCont2[x]);
                        x++;
                    }

                }
            }

            if (listBox1.SelectedIndex == 11)
            {
                listBox2.Items.Clear();
                string monthPath = @"..\monthlyReports\12.txt";

                if (new FileInfo(monthPath).Length > 0)
                {
                    string[] newCont2 = File.ReadAllLines(monthPath);
                    foreach (string line in newCont2)
                    {
                        newCont2 = line.Split(',');
                    }

                    int arrayCount = (newCont2.Length);
                    int x = 0;

                    while (x < arrayCount)
                    {
                        listBox2.Items.Add(newCont2[x]);
                        x++;
                    }

                }
            }



        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            entry entry = new entry();
            entry.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //Defines paths and variables to be used on updateButton_Click
            string cMonth = DateTime.Now.Month.ToString();
            int intMonth = Convert.ToInt32(cMonth);

            string path = @"..\monthlyReports\" + intMonth + @".txt";
            string path2 = @"..\monthlyReports\current.txt";

            //Overwrites current.txt with current month values
            string content = File.ReadAllText(path);
            File.WriteAllText(path2, content);

            //Deletes the last character in the current.txt making the array function properly
            if (new FileInfo(path2).Length > 0)
            {
                string fileContent = File.ReadAllText(path2);
                fileContent = fileContent.Remove(fileContent.Length - 1);
                File.WriteAllText(path2, fileContent);
            }

            //Check to see if file is empty, if not reads the file contents
            if (new FileInfo(path2).Length > 0)
            {
                string[] current = File.ReadAllLines(path2);

                foreach (string line in current)
                {
                    current = line.Split(',');
                }

                int[] myInts = Array.ConvertAll(current, s => int.Parse(s));

                int sum = myInts.Sum();

                label4.Text = Convert.ToString(sum);

                //Reads the goal line in the user file and converts it to an int
                string secondLine;
                using (var reader = new StreamReader(userPath))
                {
                    reader.ReadLine(); // skip
                    secondLine = reader.ReadLine();
                }

                //Calculates percentage for the monthly goal bar percentage
                double goal = Convert.ToInt32(secondLine);
                double percent = (sum / goal) * 100;
                progressBar1.Value = Convert.ToInt32(percent);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
