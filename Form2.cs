using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RedHex
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\ProgramData\username.redhex"))
            {
                string text = System.IO.File.ReadAllText(@"C:\ProgramData\username.redhex");


                // Display the file contents to the console. Variable text is a string.
                label1.Text = "Welcome, " + text + "!";


                // Keep the console window open in debug mode.


            }
            else
            {

                MessageBox.Show("You are not logged in!");
                this.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create the NotifyIcon.
            notifyIcon1.ShowBalloonTip(3000, "RedHex", "Running!", ToolTipIcon.None);
            this.Hide();


        }

        private void notifyIcon1_DoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
    }
}
