using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_Forms
{
    public partial class FormHello : Form
    {

        public FormHello()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Name1_Click(object sender, EventArgs e)
        {
            string NameBox = txtBox1.Text;
            MessageBox.Show("Hello, " + NameBox);
        }

        private void tet_Name1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Name2_Click(object sender, EventArgs e)
        {
            string NameBox2 = txtBox2.Text;
            MessageBox.Show("Hello, " + NameBox2);
        }
    }
}
