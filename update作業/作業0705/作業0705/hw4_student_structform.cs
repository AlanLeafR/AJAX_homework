using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 作業0705
{
    public partial class hw4_student_structform : Form
    {
        public hw4_student_structform()
        {
            InitializeComponent();
        }
        StudentScore stu_score;
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            stu_score.StudentName = txt_Stu_name.Text;
            stu_score.ChineseScore = Convert.ToInt32(txt_Chi_score.Text);
            stu_score.EnglishScore = Convert.ToInt32(txt_Eng_score.Text);
            stu_score.MathScore = Convert.ToInt32(txt_Math_score.Text);
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = $"姓名：{stu_score.StudentName}\n" +
                $"國文：{stu_score.ChineseScore}\n" +
                $"英文：{stu_score.EnglishScore}\n" +
                $"數學：{stu_score.MathScore}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] score = new int[3]{ stu_score.ChineseScore, stu_score.EnglishScore,stu_score.MathScore};
            string[] suject = new string[3] { "國文", "英文", "數學" };
            Array.Sort(score,suject);
            label6.Text = $"最高科目成績為：{suject[2]}{score[2]}\n" +
                $"最低科目成績為：{suject[0]}{score[0]}";
        }
    }
}
