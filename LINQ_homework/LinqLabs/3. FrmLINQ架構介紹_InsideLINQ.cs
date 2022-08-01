using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Starter
{
    public partial class FrmLINQ架構介紹_InsideLINQ : Form
    {
        public FrmLINQ架構介紹_InsideLINQ()
        {
            InitializeComponent();
        }

        private void btnArray_LINQ_Click(object sender, EventArgs e)
        {
            // System.Collections;       ArrayList(傳統集合)在此命名空間，要記得using
            // System.Collections.Generic;      List<>等泛型集合在此命名空間
            ArrayList arrList = new ArrayList();
            arrList.Add(2);
            arrList.Add(4);

            var q = from n in arrList.Cast<int>() 
                    //LINQ無法在非IEnumerable的集合執行，要先轉型成IEnumerable<T>型別
                    select new { N = n };

            dataGridView1.DataSource = q.ToList();
        }

        private void btn_LINQ_mix_Method_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(nwDataSet1.Products);

            var q = (from p in nwDataSet1.Products
                     orderby p.UnitsInStock descending
                     select p).Take(5);
            //取出庫存量前5筆的資料並降冪排序
            //可將LINQ查詢式包起來最後再用take方法取資料筆數
            //或是對q = q.take(5)也行

            dataGridView1.DataSource = q.ToList();
        }

        private void btn_Aggregtion_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            listBox1.Items.Add("sum = " + nums.Sum());
            listBox1.Items.Add("max = " + nums.Max());
            listBox1.Items.Add("min = " + nums.Min());
            listBox1.Items.Add("avg = " + nums.Average());
            listBox1.Items.Add("count = " + nums.Count());

            //=============================
            this.productsTableAdapter1.Fill(nwDataSet1.Products);
            var q = this.nwDataSet1.Products.Average(p => p.UnitPrice);
            listBox1.Items.Add($"AVG Price = {q:C2}"); //字串格式化 C=Money格式,2是到小數第二位

        }
    }
}