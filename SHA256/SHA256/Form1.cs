using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using SHA256;

namespace SHA256
{
    public partial class Form1 : MetroForm
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

        public void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "SHA256":

                    label4.Text = (Hashing.Confirm(textBox1.Text, textBox2.Text, Supported_HA.SHA256)) ? "Status:Correct" : "Status:Incorrect";
                    break;

                case "SHA384":

                    label4.Text = (Hashing.Confirm(textBox1.Text, textBox2.Text, Supported_HA.SHA384)) ? "Status:Correct" : "Status:Incorrect";
                    break;
                case "SHA512":

                    label4.Text = (Hashing.Confirm(textBox1.Text, textBox2.Text, Supported_HA.SHA512)) ? "Status:Correct" : "Status:Incorrect";
                    break;


            }
           
        }

        public void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "SHA256":

                    textBox2.Text = Hashing.ComputeHash(textBox1.Text, Supported_HA.SHA256, null);
                    break;

                case "SHA384":

                    textBox2.Text = Hashing.ComputeHash(textBox1.Text, Supported_HA.SHA384, null);
                    break;
                case "SHA512":

                    textBox2.Text = Hashing.ComputeHash(textBox1.Text, Supported_HA.SHA512, null);
                    break;


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
            ff.Show();
        }
    }
}
