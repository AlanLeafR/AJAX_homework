using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Starter
{
    public partial class FrmHelloLinq : Form
    {
        public FrmHelloLinq()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //            public interface IEnumerable<T>
            //    System.Collections.Generic 的成員

            //摘要: 
            //公開支援指定類型集合上簡單反覆運算的列舉值。

            // 若要瀏覽此類型的.NET Framework 原始程式碼，請參閱 Reference Source。


            //類型參數:
            //T: 要列舉之物件的類型。

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //syntax sugar 語法糖(可以輕鬆地寫foreach迴圈)
            foreach (int n in nums)
            {
                this.listBox1.Items.Add(n);
            }

            //====================

            this.listBox1.Items.Add("===============");

            //C# compiler轉譯
            //實際上C# compiler幫你做的事
            //藏在foreach下的秘密: foreach原理說明

            System.Collections.IEnumerator En =nums.GetEnumerator();
            //找出nums陣列的列舉元，並創一個資料型別為IEnumerator的變數En去接
            while (En.MoveNext()) //MoveNext會回傳bool，確認集合的元素是否可以移至下一個
            {
                this.listBox1.Items.Add(En.Current); //把現在En集合中的元素加到listbox中
            }


            //int www;
            //foreach (int w in www)
            //{
            //    錯誤 CS1579 因為 'int' 不包含 'GetEnumerator' 的公用執行個體或延伸模組定義，
            //        所以 foreach 陳述式無法在型別 'int' 的變數上運作
            //}

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //改用List跑一遍foreach的過程
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,13,15 };
            foreach (int n in nums)
            {
                this.listBox1.Items.Add(n);
            }
            //====================
            this.listBox1.Items.Add("===============");

            var en = nums.GetEnumerator();
            //如果資料型別超～～～～級長，可以用var當作變數資料型別代稱。
            //系統會從值自動判斷資料型別該是什麼
            //不過原則上只有在資料型別無法打出來的時候才會用var代替，
            //盡量還是把所有資料型別寫出才方便辨識
            while (en.MoveNext())
            {
                this.listBox1.Items.Add(en.Current);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //step1.定義資料來源(define source object)         
            int[] nums ={ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //step2.定義LINQ語法(define Query)
            //IEnumerable<int> q - 公開支援指定型別集合上簡單反覆運算的列舉值
            IEnumerable<int> q = from n in nums
                                                        //where n % 2 == 0
                                                        //where n >= 5 && n <= 10
                                                        where n <3 || n > 8
                                                     //用C#語法結合sql
                                                        select n;
           
            //從陣列nums中提起每個int元素，並指派給(可列舉值的資料型態)q
            //不知道要用什麼型別可以先用var，系統會自動判斷值屬於什麼型別
            //from "n"系統也會自動判斷型別為int，因為nums陣列元素必定都是同樣的int型別


            //step3.執行Query查詢(execute Query)
            foreach (int n in q)
            {
                this.listBox1.Items.Add(n);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //step1.定義資料來源(define source object)         
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            bool isEven(int n)
            {
                //if (n % 2 == 0)
                //    return true;
                //else
                //    return false;                    
                return (n % 2 == 0);
                //更精簡的寫法，只回傳n/2餘數為0的值
            }

            //step2.定義LINQ語法(define Query)
            //用C#語法+方法結合sql
            IEnumerable<int> q = from n in nums                              
                                 where isEven(n)                            
                                 select n;
            //注意，這個階段還只是在define，code沒有實際執行isEven(n)方法
            //要到step3.的時候in q，叫到q才回頭看q該如何定義跟使用的方法
            //可以在IEnumerable<int> q和foreach (int n in q)這兩行設中斷點，觀察方法的執行

            //step3.執行Query查詢(execute Query)
            foreach (int n in q)
            {
                this.listBox1.Items.Add(n);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            bool isEven(int n)
            {                 
                return (n % 2 == 0);  
            }

            IEnumerable<Point> q = from n in nums
                                      where isEven(n)
                                      select new Point(n,n*n);
            //也可以直接select一個新的類別，不過要在IEnumerable的時候就指定型別為<類別>
            foreach (Point n in q)
            {
                this.listBox1.Items.Add(n);
            }

            //執行Query查詢(execute Query - ToXXX)
            dataGridView1.DataSource= q.ToList();

            // C#自動在背景做foreach，將每個可列舉的值轉為集合
            //在設計拉一個DataGridView，把DataSource的來源設成 q.ToList();就可以呈現出表格資料
            //注意DataSource的來源不是每個資料型別都可以系結，例如不能將DataSource = string
            //通常是接table、dataset或是list，詳細可從MS官網上查詢DataGridView.DataSource 屬性的備註

            //==================================

            //使用資料圖表呈現，一樣DataSource接的來源有限制資料型態
            chart1.DataSource = q.ToList();
            chart1.Series[0].XValueMember = "X";
            chart1.Series[0].YValueMembers = "Y";
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            //chart1.Series代表一條線或一組數據，有s代表很多個所以從[0]開始
            //ChartType決定資料圖表型態，看是要用圓柱徒還是線圖都可以
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] words = { "aaa","ucuc","joijoj", "apple", "xaxApple","pineApPLe","appLeJUICE"};
            IEnumerable<string> q = from s in words
                                    where s.Length>6 && s.ToUpper().Contains("APPLE")
                                    orderby s descending  //依照字串string排序並降冪
                                    select s;

            foreach (string s in q)
            {
                this.listBox1.Items.Add(s);
            }

            //==================
            dataGridView1.DataSource = q.ToList();

            // DataSource會系結物件的「屬性」，string的屬性只有Lengh，
            // 所以把q轉成List後抓到的也只有長度的屬性。除非自己去寫新的類別再賦予屬性去Get 字串資料

            //var q = q.Where(......).Select(......); 以後使用擴充方法(LINQ方法指令)時會像這樣
        }

        private void button49_Click(object sender, EventArgs e)
        {
            //            #region 組件 System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
            //            // C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5.2\System.Core.dll
            //            #endregion

            //            using System.Collections;
            //            using System.Collections.Generic;

            //namespace System.Linq
            //    {
            //        //
            //        // 摘要:
            //        //     提供一組 static (Shared 在 Visual Basic 中) 方法來查詢物件實作 System.Collections.Generic.IEnumerable`1。
            //        public static class Enumerable
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //DataSetModel - class.....(利用DataSet模組，裡頭有很多class可以應用)
            //內建模組所以不用自己在接水管打SQL指令去連結跟adapt了
            //先在資料庫連結NW資料庫，再到專案右鍵新增項目>左方點資料>DataSet物件
            //將product和order資料表加入DataSet中並「建置」，否則工具箱不會出現
            //從工具箱將nwDataSet跟productsTableAdapter加入設計，這樣就可以在下方code使用了

            //SqlConnection Open(); => SqlCommand ExecuteReader >While(SqlDataRearder.Read())....=>productsTableAdapter1
            //模組幫我們做完這些事情，不用再自己接水管了

            this.productsTableAdapter1.Fill(this.nwDataSet1.Products); //將Adapter的東西Fill到DataSet1中的Products屬性
            var q = from p in this.nwDataSet1.Products
                    where p.ProductName.StartsWith("C") && p.UnitPrice > 30 //StartsWith->找開頭關鍵字
                    select p;

            this.dataGridView1.DataSource = q.ToList();
         }

        private void button9_Click(object sender, EventArgs e)
        {
            this.ordersTableAdapter1.Fill(this.nwDataSet1.Orders);

            var q = from p in this.nwDataSet1.Orders
                    //where p.OrderDate.Year > 1996 && p.OrderDate.Year < 1998
                    where p.OrderDate.Year == 1997
                    select p;

            this.dataGridView1.DataSource = q.ToList();
        }
    }
}
