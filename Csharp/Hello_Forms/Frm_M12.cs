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
    public partial class Frm_M12 : Form
    {
        public Frm_M12()
        {
            InitializeComponent();
        }

        int count = 0;

        private void CountPlus_Click(object sender, EventArgs e)
        {
            count += 1;
            labelCount.Text = "Count：" + count;

        }

        private void CountMinus_Click(object sender, EventArgs e)
        {
            count -= 1;
            labelCount.Text = "Count：" + count;
        }

        private void CountZero_Click(object sender, EventArgs e)
        {
            count = 0;
            labelCount.Text = "Count：" + count;
        }

        private void CountMulti_Click(object sender, EventArgs e)
        {
            count *= count;
            labelCount.Text = "Count：" + count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = ++count;
            //count = count + 1;
            //int i = count;

            labelCount.Text = "Count：" + count;
            MessageBox.Show(i.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = count++;
            //int i = count;
            //count = count + 1;

            labelCount.Text = "Count：" + count;
            MessageBox.Show(i.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a;
            a = 0;

            if (true)
            {
                int x;
                x = 100;
                a = x;
            }
            // x
            MessageBox.Show(a.ToString());
       
        }

        UseStatic us = new UseStatic();

        private void button6_Click(object sender, EventArgs e)
        {
            us.InstanceCount++;
            LabInstant.Text = "InstantCount：" + us.InstanceCount;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UseStatic.StaticCount++;
            LabStatic.Text = "StaiticCount：" + UseStatic.StaticCount;
        }

        private void CallHello_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
        }
    }
}
