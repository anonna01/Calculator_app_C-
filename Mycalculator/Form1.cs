﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mycalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox2.Text);

            double sum = txt1 / txt2;

            textBox3.Text = sum.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lebel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double txt1=Convert.ToDouble(textBox1.Text);
            double txt2=Convert.ToDouble(textBox2.Text);
            
            double sum = txt1 + txt2;

            textBox3.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox2.Text);

            double sum = txt1 - txt2;

            textBox3.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox2.Text);

            double sum = txt1 * txt2;

            textBox3.Text = sum.ToString();
        }
    }
}
