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
    public partial class hw2_Loan : Form
    {
        public hw2_Loan()
        {
            InitializeComponent();
        }

        int monthlyPayment = 0;
        int totalPayment = 0;
        
        double A1;
        double A2;
        double A3;

        // string 貸款金額 = loan_txt.Text; 存取限制疑問
        // ↑上述機制C#視為一種運算，只能在method中執行



        private void PayMonth_Click(object sender, EventArgs e)
        {
            Calculator();
            MessageBox.Show("月付額：" + monthlyPayment + "元");
        }

        private void total_Click(object sender, EventArgs e)
        {
            Calculator();
            //totalPayment = ( Calculator()* 12*int.Parse(deadline_year_txt.Text) ) - downPayment;
            MessageBox.Show("總金額：" + totalPayment + "元");
        }

         void Calculator() //每月應還本金+利息計算機
        {
            
            A1 = double.Parse(loan_txt.Text); //貸款金額
            A2 = double.Parse(deadline_year_txt.Text); //期限(年)
            A3 = double.Parse(AnnualRate_txt.Text); //年利率(%)
            double A4 = double.Parse(down_payment_txt.Text);//頭期款

            double A5 = A3 / 12 / 100; //月利率
            double A6 = A2 * 12; //月數
            double A8 = A1 - A4; //貸款金額-頭期款

            //公式：[(1+月利率)^12 * 月利率] / [(1+月利率)^12 -1]  = 月償還率
            //Math.Pow( (1+月利率) , 月份 )

            double A7 = (Math.Pow((1 + A5), A6) * A5) / (Math.Pow((1 + A5), A6) - 1); //月償還率
            monthlyPayment = (int)Math.Round(A8 * A7); // A8(貸款金額-頭期款)*A7(月償還率)=每月應還本金+利息，四捨五入至整數
            totalPayment =  monthlyPayment * 12 *(int)A2 ; 


        }

        private void Report_btn_Click(object sender, EventArgs e)
        {
            hw2_Loan_Report RP = new hw2_Loan_Report();
            Calculator();
            RP.report_txt.Text = A1.ToString(); 
            RP.textBox1.Text = A2.ToString();
            RP.textBox2.Text = A3.ToString();
            RP.textBox3.Text = monthlyPayment.ToString();
            RP.textBox4.Text = totalPayment.ToString();
            RP.Show();
        }
    }
}
