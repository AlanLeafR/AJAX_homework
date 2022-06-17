using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_Forms
{
    partial class MyFirstMethod
    {
        public void Method07()
        {
            MessageBox.Show("Partcial Method 07");
        }
        public void Method08()
        {
            MessageBox.Show("Partcail Method 08引用01+02成功");
            method01();
            method02();
        }
    }

    public class Member
    {
        public string Name;
        public int Age;
    }
}
