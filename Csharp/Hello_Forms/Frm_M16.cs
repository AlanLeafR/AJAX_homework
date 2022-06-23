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
    public partial class Frm_M16 : Form
    {
        public Frm_M16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal d = 10;
            MessageBox.Show(d.ToString());
            ByValueType(d);
            MessageBox.Show(d.ToString());
        }

        void ByValueType (decimal d)
        {
            d = 1000;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Member MB = new Member();
            MB.Name = "hunter";
            MB.Age = 20;

            MessageBox.Show(MB.Name + "你好 , 年齡:" + MB.Age.ToString());

            ByReferenceType(MB);
            MessageBox.Show(MB.Name+"你好 , 年齡:"+MB.Age.ToString());
        }

        void ByReferenceType(Member member)
        {
            member.Age = 30;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal dec = 110;
            MessageBox.Show(dec.ToString());
            ByRef(ref dec);
            MessageBox.Show(dec.ToString());
        }
        void ByRef(ref decimal d)
        {
            d = 10500;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 15;
            MessageBox.Show(a.ToString());
            ByOut(out a);
            MessageBox.Show(a.ToString());

        }
        void ByOut(out int Age)
        {
            Age = 25;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            string Lan = MyParams("國文", 30, 40, 85, 74);
            MessageBox.Show(Lan);
            string Math = MyParams("數學", 50, 20, 75, 90,35);
            MessageBox.Show(Math);
        }

        string MyParams (string Course, params int[] scores)
        {
            int total = 0;
            for(int i = 0; i < scores.Length; i++)
            {
                total += scores[i];
            }
            return Course + "的總成績是" + total+"分";
        }

    }
}
