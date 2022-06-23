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
    public partial class Frm_M26 : Form
    {
        public Frm_M26()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int[] arr = new int [3];
            //arr[0] = 11111;
            //arr[1] = 22222;
            //arr[2] = 33333;

            //int[] arr = new int[3] { 1, 2, 3 };

            
            int[] arr = { 10, 20, 30 };

            int i = 1;

            for (  ; i < arr.Length ; i++)
            {
                MessageBox.Show(arr[i].ToString());
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,]arr2= new int[3, 2] { { 7,5 }, 
                                        { 2, 4 },
                                        { 1, 6 } }; 
            string result = "";

            //for(int i=0; i < arr2.GetLength(0); i++)
            //{
            //    for(int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        result += $"arr2 [{ i } , { j }]  =>  {arr2[i,j]}\n";
            //    }
            //}

            foreach(int item in arr2)
            {
                result += item + "\n";
            }

            MessageBox.Show(result);
        }

        int[] CreatArray(int Length)
        {
            int[] arr = new int[Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            //foreach(int item in arr)
            //{
            //    item = item+1;  ???(無法執行)
            //}

            return arr;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int[] NewArr = CreatArray(20);
            string result = "";
            for(int i = 0; i < NewArr.Length; i++)
            {
                result += NewArr[i] + "\n";
            }
            MessageBox.Show(result);
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            Member[] arrMember = new Member[2];

            arrMember[0] = new Member();
            arrMember[0].Name = "AAA";
            arrMember[0].Age = 10;

            arrMember[1] = new Member();
            arrMember[1].Name = "BBB";
            arrMember[1].Age = 20;

            string result = "";

            result = arrMember[0].Name + arrMember[0].Age+"\n"+
                arrMember[1].Name + arrMember[1].Age;
            MessageBox.Show(result);
        }

    }
}
