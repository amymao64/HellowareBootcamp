﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_HelloPage2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sGender = "";
            if (radioButton1.Checked)
            {
                sGender = "Mr.";
            }
            if (radioButton2.Checked)
            {
                sGender = "Mrs.";
            }

            DateTime dt = DateTime.Now;
            if (dt.Hour > 18)

                {
                MessageBox.Show("Good Evening!  "+sGender + textBox2.Text + "," + " Age " + textBox3.Text + ".");
                }

            else
            {
                MessageBox.Show("Good Day!  " + sGender + textBox2.Text + "," + " Age " + textBox3.Text + ".");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
