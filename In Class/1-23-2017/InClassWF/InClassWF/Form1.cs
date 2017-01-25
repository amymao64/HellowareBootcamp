using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassWF
{
    public partial class Form1 : Form
    {
        Customer customer1;
        Customer customer2;

        public Form1()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            customer1 = new Customer(textBox1.Text,textBox2.Text);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
