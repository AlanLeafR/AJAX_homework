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


namespace Hello_Forms
{
    public partial class Leaf_Homework_Form : Form
    {
        public Leaf_Homework_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //// 確認子視窗是否有啟動，若啟動則關閉子視窗
            //if (ActiveMdiChild != null)
            //{
            //    ActiveMdiChild.Close();
            //}                          
            ////實體化視窗物件
            //FormHello hello = new FormHello();

            ////設定最高級父容器為this(主視窗)
            //hello.MdiParent = this;
            ////設定子視窗的父容器為panel
            //hello.Parent = this.splitContainer1.Panel2;
            ////hello.StartPosition = this.splitContainer1.Panel2.CenterParent;
            //hello.Show();
            //hello.BringToFront();

            this.splitContainer1.Panel2.Controls.Clear();
          

            FormHello Hello = new FormHello();
            Hello.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(Hello);
            //Hello.Parent = this.splitContainer1.Panel2;
            Hello.Show();
            //Hello.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (ActiveMdiChild != null) ActiveMdiChild.Close();

            //hw2_Loan Lo = new hw2_Loan();
            //Lo.MdiParent = this;
            //Lo.Parent = this.splitContainer1.Panel2;
            //Lo.Show();
            //Lo.BringToFront();


            //this.splitContainer1.Panel2.Controls.Clear();
            //this.splitContainer1.Panel2.Controls.Remove(sender as Button).parent);
            this.splitContainer1.Panel2.Controls.Clear();
       
            hw2_Loan Lo = new hw2_Loan();
            Lo.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(Lo);
            //Lo.Parent = this.splitContainer1.Panel2;
            Lo.Show();
            //Lo.BringToFront();
            //if(private void button2_Click(object sender, EventArgs e))
            // {

            //    this.splitContainer1.Panel2.Controls.Remove(Lo);
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.splitContainer1.Panel2.Controls.Clear();         
            foreach (Form frm in this.splitContainer1.Panel2.Controls)  //釋放記憶體空間
            {
                frm.Close();
                frm.Dispose();
            }

            hw3_POS POS = new hw3_POS();
            POS.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(POS);
            POS.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.splitContainer1.Panel2.Controls.Clear();
        

            hw4_student_structform stu_struck = new hw4_student_structform();
            stu_struck.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(stu_struck);
            stu_struck.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
       
            
        }
    }
}
