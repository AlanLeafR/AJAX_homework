using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_Forms
{
    public partial class MyFirstMethod
    {
        void method01()
        {
            MessageBox.Show("Method 01");
        }

        protected void method02()
        {
            MessageBox.Show("Method 02");
        }

        public void method03()
        {
            MessageBox.Show("Method 03");
        }
        internal void method04()
        {
            MessageBox.Show("Method 04");
        }
        protected internal void method05()
        {
            MessageBox.Show("Method 05");
        }

        public void method06() {
            method01();
            method02();
        }
    }
}
