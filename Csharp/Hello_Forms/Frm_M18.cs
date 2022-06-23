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
    public partial class Frm_M18 : Form
    {
        public Frm_M18()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product");
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            UserRole Role = UserRole.Admin;

            //if(Role == UserRole.Admin)
            //{
            //    btnEnter.Enabled = true;
            //}

            btnEnter.Enabled = Role == UserRole.Admin;
        }
    }
}
