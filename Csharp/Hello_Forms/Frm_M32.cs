using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_Forms
{
    public partial class Frm_M32 : Form
    {
        public Frm_M32()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder SB = new StringBuilder();
            StringBuilder SB2 = new StringBuilder();

            string MHR = "SUN";

            SB.Append("AAA");
            SB2 = SB;
            SB.Append(MHR);

            MessageBox.Show("SB[0]："+SB[0].ToString()+"　　SB[MAX]"+SB[SB.Length-1].ToString());
            MessageBox.Show("SB2："+SB2.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dir = @"C:\Users\Student\Desktop\project\demo.txt";
            MessageBox.Show(Path.GetDirectoryName(dir) + "\n"
                + Path.GetFileName(dir) + "\n"
                + Path.GetFileNameWithoutExtension(dir) + "\n"
                + Path.GetFullPath(dir));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string oras = "ovdpogjpowsvpsovqpvoqpovjpo";
            MessageBox.Show( oras.IndexOf('o').ToString());
            MessageBox.Show(oras.LastIndexOf('j').ToString());

            string pkm = "";
            //pkm = oras.Substring(0, 5);
            //MessageBox.Show(pkm);
            pkm = oras.Trim('o');
            MessageBox.Show(pkm);
            pkm = oras.ToUpper();
            MessageBox.Show(pkm);
            pkm = oras.ToLower();
            MessageBox.Show(pkm);
        }
    }
}
