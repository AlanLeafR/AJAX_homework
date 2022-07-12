using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_Forms
{
    public partial class Frm_M34 : Form
    {
        public Frm_M34()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader txtRead = new StreamReader(@"..\suject.txt", Encoding.UTF8);
            textBox1.Text = txtRead.ReadToEnd();
            txtRead.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fileA = new FileStream(@"../testdemo.txt", FileMode.Create);
            StreamWriter fileWrire = new StreamWriter(fileA, Encoding.Default);
            fileWrire.Write(textBox1.Text);
            fileWrire.Close();
            fileA.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            label1.Text = (string)i;
        }
    }
}
