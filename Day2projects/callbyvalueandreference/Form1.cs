﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace callbyvalueandreference
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //global section
        class swapdemo
        {
            public void swapexample1(int x, int y)
            {
                int temp;
                temp = x;
                x = y;
                y = temp;
            }

            public void swapexample2(ref int x, ref int y)
            {
                int temp;
                temp = x;
                x = y;
                y = temp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = 10;
            b = 20;
            MessageBox.Show("Before swapping ...");
            MessageBox.Show("A=" + a + "\nB=" + b);
            swapdemo obj = new swapdemo();
            obj.swapexample1(a, b);
            MessageBox.Show("After swapping ...");
            MessageBox.Show("A=" + a + "\nB=" + b);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b;
            a = 10;
            b = 20;
            MessageBox.Show("Before swapping ...");
            MessageBox.Show("A=" + a + "\nB=" + b);
            swapdemo obj = new swapdemo();
            obj.swapexample2(ref a, ref b);
            MessageBox.Show("After swapping ...");
            MessageBox.Show("A=" + a + "\nB=" + b);

        }
    }
}
