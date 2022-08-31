using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelPrj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_memberRegister_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            Frm會員註冊 f = new Frm會員註冊();
            f.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(f);
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void btn_itinerary_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            Frm旅遊行程管理 f = new Frm旅遊行程管理();
            f.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(f);
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void btn_memberManagement_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            Frm會員資料管理 f = new Frm會員資料管理();
            f.TopLevel = false;
            this.splitContainer2.Panel2.Controls.Add(f);
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
    }
}
