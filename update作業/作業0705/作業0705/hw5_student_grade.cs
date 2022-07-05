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
    public partial class hw5_student_grade : Form
    {
        public hw5_student_grade()
        {
            InitializeComponent();
        }

        StudentScore stu_score;
        ArrayList lis_stu = new ArrayList();
        Random rnd = new Random();
        int nameCount=0;

        double check_double = 0;
        bool Check01, Check02, Check03;


        
       


        void ShowLab()
        {
            string result = "";
            
            for(int i = 0; i < lis_stu.Count; i++)
            {
                int[] score_arr = new int[3] { ((StudentScore)lis_stu[i]).ChineseScore, 
                                               ((StudentScore)lis_stu[i]).EnglishScore, 
                                               ((StudentScore)lis_stu[i]).MathScore };

                string[] suject_arr = new string[3] { "國文", "英文", "數學" };
                Array.Sort(score_arr, suject_arr);

                // Label要設成標楷體才能置右對齊， why ??

                result += ((StudentScore)lis_stu[i]).StudentName.PadRight(9) +
                          ((StudentScore)lis_stu[i]).ChineseScore.ToString().PadLeft(6) +
                          ((StudentScore)lis_stu[i]).EnglishScore.ToString().PadLeft(8) +
                          ((StudentScore)lis_stu[i]).MathScore.ToString().PadLeft(8)+
                          ((StudentScore)lis_stu[i]).TotalScore.ToString().PadLeft(8)+
                          ((StudentScore)lis_stu[i]).AverageScore.ToString().PadLeft(9)+
                          suject_arr[0].ToString().PadLeft(6) + score_arr[0].ToString().PadRight(4) +
                          suject_arr[2] + score_arr[2].ToString() +
                          "\n";
            }

            label5.Text = result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Check01 = double.TryParse(txt_Chi_score.Text, out check_double);
            Check02 = double.TryParse(txt_Eng_score.Text, out check_double);
            Check03 = double.TryParse(txt_Math_score.Text, out check_double);

            if (Check01 && Check02 && Check03)
            {
            stu_score.StudentName = txt_Stu_name.Text;
            stu_score.ChineseScore = Convert.ToInt32(txt_Chi_score.Text);
            stu_score.EnglishScore = Convert.ToInt32(txt_Eng_score.Text);
            stu_score.MathScore = Convert.ToInt32(txt_Math_score.Text);
            stu_score.TotalScore = stu_score.ChineseScore + stu_score.EnglishScore + stu_score.MathScore;
            stu_score.AverageScore = Math.Round((stu_score.TotalScore/3),2,MidpointRounding.AwayFromZero);
            lis_stu.Add(stu_score);
            ShowLab();
            btn_total.Enabled = true;
            }
            else
            {
                MessageBox.Show("請輸入數值。");
            }                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nameCount++;
            //int chiScore, engScore, matScore;
            stu_score.StudentName = nameCount.ToString();
            stu_score.ChineseScore = rnd.Next(0,100);
            stu_score.EnglishScore = rnd.Next(0, 100);
            stu_score.MathScore = rnd.Next(0, 100);
            stu_score.TotalScore = stu_score.ChineseScore + stu_score.EnglishScore + stu_score.MathScore;
            stu_score.AverageScore = Math.Round((stu_score.TotalScore / 3), 1, MidpointRounding.AwayFromZero);
            lis_stu.Add(stu_score);
            ShowLab();

            btn_total.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lis_stu.Clear();
            nameCount = 0;
            label5.Text = "" ;
            label7.Text = "" ;
            btn_total.Enabled = false;
            
            btn_AddStuData.Enabled = true;
            btn_RdmStuData.Enabled = true;
            btn_RdmStu20.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            for (int i = 0;i< 20; i++)
            {
                nameCount++;
                stu_score.StudentName = nameCount.ToString();
                stu_score.ChineseScore = rnd.Next(0, 100);
                stu_score.EnglishScore = rnd.Next(0, 100);
                stu_score.MathScore = rnd.Next(0, 100);
                stu_score.TotalScore = stu_score.ChineseScore + stu_score.EnglishScore + stu_score.MathScore;
                stu_score.AverageScore = Math.Round((stu_score.TotalScore / 3), 1, MidpointRounding.AwayFromZero);
                lis_stu.Add(stu_score);
            }
            ShowLab();
            btn_total.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double All_ChiTotal = 0;
            double All_EngTotal = 0;
            double All_MathTotal = 0;
            double All_ChiAverage = 0;
            double All_EngAverage = 0;
            double All_MathAverage = 0;
        
            int[] Chi_arr = new int[lis_stu.Count];
            int[] Eng_arr = new int[lis_stu.Count];
            int[] Math_arr = new int[lis_stu.Count];

            for (int i = 0; i < lis_stu.Count; i++)
            {
                All_ChiTotal += ((StudentScore)lis_stu[i]).ChineseScore;
                All_EngTotal += ((StudentScore)lis_stu[i]).EnglishScore;
                All_MathTotal += ((StudentScore)lis_stu[i]).MathScore;
                Chi_arr[i] = ((StudentScore)lis_stu[i]).ChineseScore;
                Eng_arr[i] = ((StudentScore)lis_stu[i]).EnglishScore;
                Math_arr[i] = ((StudentScore)lis_stu[i]).MathScore;
            }
           
           All_ChiAverage = Math.Round(All_ChiTotal / lis_stu.Count,1);
            All_EngAverage = Math.Round(All_EngTotal / lis_stu.Count,1);
            All_MathAverage = Math.Round(All_MathTotal / lis_stu.Count,1);

            Array.Sort(Chi_arr);
            Array.Sort(Eng_arr);
            Array.Sort(Math_arr);

            string space = "";
                
            label7.Text = $"總分：{space.PadRight(6)}{(All_ChiTotal).ToString().PadRight(8)}{All_EngTotal.ToString().PadRight(8)}{All_MathTotal}\n" +
                $"平均：{space.PadRight(6)}{All_ChiAverage.ToString().PadRight(8)}{All_EngAverage.ToString().PadRight(8)}{All_MathAverage}\n" +
                $"最高分：{space.PadRight(5)}{Chi_arr[lis_stu.Count-1].ToString().PadRight(8)}{Eng_arr[lis_stu.Count-1].ToString().PadRight(8)}{Math_arr[lis_stu.Count-1]}\n" +
                $"最低分：{space.PadRight(5)}{Chi_arr[0].ToString().PadRight(8)}{Eng_arr[0].ToString().PadRight(8)}{Math_arr[0]}";

            btn_total.Enabled = false;
            btn_AddStuData.Enabled = false;
            btn_RdmStuData.Enabled = false;
            btn_RdmStu20.Enabled = false;
        }
    }
}
