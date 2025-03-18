using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynchronousDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Before dealy";
            //   for (int i = 0; i < 10000; i++) ;
            await Task.Delay(10000);
            label2.Text = "after delay";

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";

            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("say hello..");
        }
    }
}
