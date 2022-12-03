using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedHex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sURL;
            sURL = "https://redhex.bioshot.repl.co/check?account=" + textBox1.Text + "&password=" + textBox2.Text;


            WebRequest wrGETURL;    
            wrGETURL = WebRequest.Create(sURL);

            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();

            StreamReader objReader = new StreamReader(objStream);

            string sLine = "";
            int i = 0;

            while (sLine != null)
            {
                i++;
                sLine = objReader.ReadLine();
                if (sLine != null)
                    if (sLine == "correct!")
                    {
                      
                        string path = @"c:\ProgramData\username.redhex";

                        try
                        {
                            if (File.Exists(path))
                            {
                                Form2 z = new Form2(); // This is bad
                                Hide();
                                z.Location = new Point(Location.X, Location.Y);
                                z.Show();
                            }
                            else
                            {
                                
                                // Create the file, or overwrite if the file exists.
                                using (FileStream fs = File.Create(path))
                                {
                                    byte[] info = new UTF8Encoding(true).GetBytes(textBox1.Text);
                                    // Add some information to the file.
                                    fs.Write(info, 0, info.Length);
                                   
                                }

                            }
                            

                            // Open the stream and read it back.
                            using (StreamReader sr = File.OpenText(path))
                            {
                                string s = "";
                                while ((s = sr.ReadLine()) != null)
                                {
                                    Console.WriteLine(s);
                                }
                            }
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password!");
                    }
                
                
            }
           

            Console.ReadLine();
        }
    }
}
