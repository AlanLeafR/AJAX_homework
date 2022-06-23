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
    public partial class Frm_M26進階方法 : Form
    {
        public Frm_M26進階方法()
        {
            InitializeComponent();
        }

        void Swap(ref int A,ref int B)
        {
            int T = A;
            A = B;
            B = T;
        }

        void Swap(ref string A, ref string B)
        {
            string T = A;
            A = B;
            B = T;
        }

        void GenericSwap<GE>(ref GE A, ref GE B)
        {
            GE T = A;
            A = B;
            B = T;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 100, b = 200;
            MessageBox.Show($"A={a} , B={b}");
            Swap(ref a,ref b);
            MessageBox.Show($"A={a} , B={b}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = "國文", b = "英文";
            MessageBox.Show($"A={a} , B={b}");
            Swap(ref a, ref b);
            MessageBox.Show($"A={a} , B={b}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 100, b = 200;
            MessageBox.Show($"A={a} , B={b}");
            GenericSwap<int>(ref a, ref b);
            MessageBox.Show($"A={a} , B={b}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = "國文", b = "英文";
            MessageBox.Show($"A={a} , B={b}");
            GenericSwap<string>(ref a, ref b);
            MessageBox.Show($"A={a} , B={b}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a = 3.14 , b = 5.789;
            MessageBox.Show($"A={a} , B={b}");
            GenericSwap<double>(ref a, ref b);
            MessageBox.Show($"A={a} , B={b}");
        }
    }
}
