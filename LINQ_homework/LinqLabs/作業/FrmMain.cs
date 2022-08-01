using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyHomeWork;
using LinqLabs;
using LinqLabs.作業;

namespace priAdoDoNetDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            Frm作業_1 f = new Frm作業_1();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Frm作業_2 f = new Frm作業_2();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Frm作業_4 f = new Frm作業_4();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
    }
}
