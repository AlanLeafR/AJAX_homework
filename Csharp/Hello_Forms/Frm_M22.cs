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
    public partial class Frm_M22 : Form
    {
        public Frm_M22()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            int grade = 0;


            if (int.TryParse(txt_grade.Text, out grade))
            {
                if (grade >= 80 && grade <= 100)
                {
                    MessageBox.Show("A級");
                }
                else if (grade >= 60 && grade <= 79)
                {
                    MessageBox.Show("B級");
                }
                else if (grade > 100)
                {
                    MessageBox.Show("請輸入1~100之間的分數");
                    txt_grade.Clear();
                }
                else
                {
                    MessageBox.Show("C級");
                }
            }
            else
            {
                MessageBox.Show("請輸入正確格式");
                txt_grade.Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("今天星期三嗎?", "提問", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("YES");
                    break;

                case DialogResult.No:
                    MessageBox.Show("NO");
                    break;
                default:
                    MessageBox.Show("請回答請回答請回答");
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            string result = "";

            while (i <= 9)
            {
                result += i + "\n";
                i++;
            }
            MessageBox.Show(result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            string result = "";

            do
            {
                result += i + "\n";
                i++;
            } while (i <= 9);
            MessageBox.Show(result);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 10;
            string result = "";

            do
            {
                result += i + "\n";
                i++;
            } while (i <= 9);
            MessageBox.Show(result);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string result = "";
            for(int i = 0, j = 10, K = 2; i <= j + K; i += 2, K++)
            {
                result += $"i={i} , j={j} , k={K}\n";
            }
            MessageBox.Show(result);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach(Control ABC in this.Controls)
            {
                //if(ABC.GetType() != typeof (Button))
                //{
                //    continue;
                //}

                if(!(ABC is Button))
                {
                    continue;
                }

                ABC.Left -= 10;
                ABC.Top += 10;
                ABC.BackColor = Color.DimGray;
                ABC.ForeColor = Color.Olive;
                ABC.Width += 10;
                //textBox.Font = new Font(textBox.Font.FontFamily, textBox.Font.Size*1.1f)
                ABC.Font = new Font(ABC.Font.FontFamily, ABC.Font.Size+1.1f);
            }
        }
    }
}

