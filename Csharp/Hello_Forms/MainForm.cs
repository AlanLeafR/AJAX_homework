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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstMethod();

            void FirstMethod()
            {
                MessageBox.Show("First Method");
            }
        }

        private void OpnHello_Click(object sender, EventArgs e)
        {
            FormHello HelloForm = new FormHello();
            HelloForm.Show();
        }


        private void OpnMethod2_Click(object sender, EventArgs e)
        {
            MyFirstMethod mc = new MyFirstMethod();
            //mc.method01();
            //mc.method02();
            mc.method03();
            mc.method04();
            mc.method05();
        }

        private void AgeCalculator_Click(object sender, EventArgs e)
        {
            string Birth = BirthYear(100);
            MessageBox.Show(Birth);
        }

        string BirthYear(int Age)
        {
          
            int BirthYear = DateTime.Now.Year - Age;
            string result = "您的出生年是" + BirthYear + "年";
            return result;
         }

        private void EncapTest_Click(object sender, EventArgs e)
        {
            MyFirstMethod mc = new MyFirstMethod();
            mc.method06();
        }

        private void PartcailClass_Click(object sender, EventArgs e)
        {
            MyFirstMethod mc = new MyFirstMethod();
            mc.Method07();
            mc.Method08();
        }
    }
}
