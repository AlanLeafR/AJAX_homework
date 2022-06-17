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
    public partial class MemberObjectcs : Form
    {
        public MemberObjectcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member mem01 = new Member();
            mem01.Name = "Amiya";
            mem01.Age = 24;

            //string name = "Amaiya";
            //int age = 24;
            //MessageBox.Show("會員名字：" + name + " ,年齡：" + age);

            MessageBox.Show("會員名字：" + mem01.Name +  " ,年齡：" + mem01.Age);

            Member mem02 = new Member()
            {
                Name = "Spector",
                Age = 25,
            };

            MessageBox.Show("會員名字：" + mem02.Name + " ,年齡：" + mem02.Age);

        }

        private void RegisterClick_Click(object sender, EventArgs e)
        {
            //public delegate void EventHandler(object sender, EventArgs e);
            MemberRegister.Click += new EventHandler(MemberRegister_Click);
            MemberRegister02.Click += MemberRegister02_Click;
            MessageBox.Show("註冊事件成功，可以開始進行會員註冊");
        }

        private void MemberRegister02_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Member02註冊成功");
        }

        private void MemberRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Member01註冊成功");
        }

        private void UnRegisterClick_Click(object sender, EventArgs e)
        {
            MemberRegister.Click -= new EventHandler(MemberRegister_Click);
            MemberRegister02.Click -= MemberRegister02_Click;
        }
    }
}
