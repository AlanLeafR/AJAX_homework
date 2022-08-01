using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHomeWork
{
    public partial class Frm作業_1 : Form
    {
        public Frm作業_1()
        {
            InitializeComponent();
            this.ordersTableAdapter1.Fill(this.nwDataSet1.Orders);
            MakeComboList(); //資料載入時就把combolist建好

            students_scores = new List<Student>()
                                         {
                                            new Student{ Name = "aaa", Class = "CS_101", Chi = 80, Eng = 80, Math = 50, Gender = "Male" },
                                            new Student{ Name = "bbb", Class = "CS_102", Chi = 80, Eng = 80, Math = 100, Gender = "Male" },
                                            new Student{ Name = "ccc", Class = "CS_101", Chi = 60, Eng = 50, Math = 75, Gender = "Female" },
                                            new Student{ Name = "ddd", Class = "CS_102", Chi = 80, Eng = 70, Math = 85, Gender = "Female" },
                                            new Student{ Name = "eee", Class = "CS_101", Chi = 80, Eng = 80, Math = 50, Gender = "Female" },
                                            new Student{ Name = "fff", Class = "CS_102", Chi = 80, Eng = 80, Math = 80, Gender = "Female" },

                                          };
        }

        List<Student> students_scores;

        public class Student
        {
            public string Name { get; set; }
            public string Class { get; set; }
            public int Chi { get; set; }
            public int Eng { get; internal set; }
            public int Math { get; set; }
            public string Gender { get; set; }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private System.IO.FileInfo[] GetPath()
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");

            System.IO.FileInfo[] files = dir.GetFiles();

            this.dataGridView1.DataSource = files;

            return files;
        }
        
        int top_count = 0;
        int bottom_count = 0;
        private void button13_Click(object sender, EventArgs e)
        {
            //this.nwDataSet1.Products.Take(10);//Top 10 Skip(10)
            //Distinct()
            //dataGridView1.Columns.Clear();

            //下一頁

            ordersTableAdapter1.ClearBeforeFill = false;

            bool isInt = int.TryParse(textBox1.Text, out int result);
            if (isInt)
            {
                int p_text = Convert.ToInt32(textBox1.Text);

                var q = (from o in nwDataSet1.Orders
                         orderby o.OrderID
                         select o).Skip(bottom_count).Take(p_text);

                bottom_count += p_text;
                top_count = bottom_count - p_text;

                dataGridView1.DataSource = q.ToList();
            }
            else
                MessageBox.Show("請輸入數字");
        }
        private void button12_Click(object sender, EventArgs e)
        {
            //上一頁
            ordersTableAdapter1.ClearBeforeFill = false;

            bool isInt = int.TryParse(textBox1.Text, out int result);
            if (isInt)
            {
                int p_text = Convert.ToInt32(textBox1.Text);

                top_count -= p_text;

                var q = (from o in nwDataSet1.Orders
                         orderby o.OrderID
                         select o).Skip(top_count).Take(p_text);

                bottom_count = top_count + p_text;

                dataGridView1.DataSource = q.ToList();
            }
            else
                MessageBox.Show("請輸入數字");
        }
        

        private void button14_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");

            System.IO.FileInfo[] files =  dir.GetFiles();

            this.dataGridView1.DataSource = files;
            //dataGridView1.Columns["Extension"].DisplayIndex = 1; //將log欄位顯示設置為第二個
            //dataGridView1.Columns[0].Visible = false;

            var q = from data in files
                    where data.Extension == ".log"
                    select new { data.Name, data.Extension } ;  //Q：要怎麼只顯示extension欄位???
                                                                                                   //Ａ：new一個新欄位專門叫他的資料，資料包含原本資料的欄位內容

            this.dataGridView1.DataSource = q.ToList();
            //this.dataGridView1.Columns[0].HeaderText = "AAA"; //改變欄位名稱
            //for (int i = 0; i < 15; i++)  //逃避現實方法，把所有欄位隱藏起來除了自己要的再顯示
            //{
            //    dataGridView1.Columns[i].Visible = false;
            //    if (i == 7|| i == 0)
            //        dataGridView1.Columns[i].Visible = true;
            //}
        }

        private void button36_Click(object sender, EventArgs e)
        {
            #region 搜尋 班級學生成績

            // 
            // 共幾個 學員成績 ?						

            // 找出 前面三個 的學員所有科目成績					
            // 找出 後面兩個 的學員所有科目成績					

            // 找出 Name 'aaa','bbb','ccc' 的學成績						

            // 找出學員 'bbb' 的成績	                          

            // 找出除了 'bbb' 學員的學員的所有成績 ('bbb' 退學)	

        		
            // 數學不及格 ... 是誰 
            #endregion

        }

        private void button2_Click(object sender, EventArgs e)
        {
          var q = from data in GetPath()
                        where data.CreationTime.Year == 2019
                       select data;

            this.dataGridView1.DataSource = q.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var q = from data in GetPath()
                    where data.Length > 5000000 //檔案大小大於5000kb的。1kb=1024byte
                    select data;

            this.dataGridView1.DataSource = q.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Columns.Clear();
            this.dataGridView2.Columns.Clear();

            this.ordersTableAdapter1.Fill(this.nwDataSet1.Orders);
            this.order_DetailsTableAdapter1.Fill(this.nwDataSet1.Order_Details);

            var q = from p in this.nwDataSet1.Orders                    
                    select p;

            var q2 = from p in this.nwDataSet1.Order_Details
                     select p;

            this.dataGridView1.DataSource = q.ToList();
            this.dataGridView2.DataSource = q2.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //new {.....  Min=33, Max=34.}
            // 找出 'aaa', 'bbb' 'ccc' 學員 國文數學兩科 科目成績  |		

            //個人 所有科的  sum, min, max, avg

        }

        void MakeComboList()
        {
            this.ordersTableAdapter1.Fill(this.nwDataSet1.Orders);

            //var q = from Year in this.nwDataSet1.Orders
            //        group Year by Year.OrderDate.Year into Sort_Year
            //        select Sort_Year;
            ////用GroupBy整理資料，會剩下只有3筆(1996、1997、1998)
            //this.dataGridView1.DataSource = q.ToList();
            //foreach (var Item in q)
            //{
            //    comboBox1.Items.Add(Item.Key);
            //    //滑鼠放到key上可以查到輸入key( 索引 )會回傳element( 值 )
            //    //key是經group by整理後的欄位名稱，藉由key才可以找到資料element
            //    //這個方法缺點是完全不知道怎麼寫型別，只能用var item找
            //}

            //第二種方法 by軒兒~~
            var q2 = from p in this.nwDataSet1.Orders
                     select p.OrderDate.Year;
            //把所有年份都抓出來丟到q的集合中，但因為太多筆所以要用distinct

            foreach (int Item in q2.Distinct())
            //用distinct過濾掉重複的值，並回傳一組集合
            //好處是可以明確知道item的型別，不用var去接也不用key去找element
            {
                comboBox1.Items.Add(Item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Columns.Clear();
            this.dataGridView2.Columns.Clear();

            this.ordersTableAdapter1.Fill(this.nwDataSet1.Orders);
            this.order_DetailsTableAdapter1.Fill(this.nwDataSet1.Order_Details);

            var q = from p in this.nwDataSet1.Orders
                        where p.OrderDate.Year.ToString() == comboBox1.Text
                        select p;
            var q2 = from p in this.nwDataSet1.Order_Details
                     where p.OrdersRow.OrderDate.Year.ToString() == comboBox1.Text  //OrdersRow哪裡來的??
                     select new { p.OrderID,p.ProductID,p.UnitPrice,p.Quantity,p.Discount};

            this.dataGridView1.DataSource = q.ToList();
            this.dataGridView2.DataSource = q2.ToList();

        }
    }
}
