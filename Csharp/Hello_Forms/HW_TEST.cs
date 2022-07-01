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
    public partial class HW_TEST : Form
    {
        public HW_TEST()
        {
            InitializeComponent();
        }

        bool act = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            FormHello hello = new FormHello();
            hello.MdiParent = this;
            hello.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            hw2_Loan Lo = new hw2_Loan();
            Lo.MdiParent = this;
            Lo.Show();
        }
    }
}
