using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Starter
{
    public partial class FrmLINQ_To_XXX : Form
    {
        public FrmLINQ_To_XXX()
        {
            InitializeComponent();
            this.productsTableAdapter1.Fill(nwDataSet1.Products);
            this.categoriesTableAdapter1.Fill(nwDataSet1.Categories);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<IGrouping<string, int>> q = from n in nums
                                                                                     //group n by (n % 2);  把key換成三元運算，定義好Key是什麼意思
                                                                                    group n by n % 2 == 0 ? "偶數" : "奇數";

            //錯誤  無法將類型 'System.Collections.Generic.IEnumerable<System.Linq.IGrouping<string, int>>' 
            //隱含轉換成 'System.Collections.Generic.IEnumerable<System.Linq.IGrouping<int, int>>'。
            //已存在明確轉換(是否漏了轉型 ?)  

            //記得把key改成文字後也要改變IGrouping內的資料型態


            //依據group by的key決定分成多少個群體
            //Gruop By後會分成兩個群體，資料型態為 IGrouping<int,int >(Key的型態是int、item的型態也是int)

            dataGridView1.DataSource = q.ToList();
            //dataGridView沒辦法查看一層又一層的關係，要用tree view接
            //==========================================

            foreach (var group in q)
            {
                TreeNode X = this.treeView1.Nodes.Add(group.Key.ToString());
                foreach(var item in group)
                {
                    X.Nodes.Add(item.ToString());
                    //第二層tree已經在節點Nodes內了，所以要用一個節點變數接上一層的節點
                    //注意現在已經在gruop裡面了，in要in group而不是q
                }
            }
            

        }

        private void btn_Group_Aggregation_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 15 };

            var q = from n in nums                   
                    group n by n % 2 == 0 ? "偶數" : "奇數" into g // 用g代表前面group成兩群的群體
                    select new { MyKey = g.Key, MyCount = g.Count(), MyAvg = g.Average(),MyGroup = g };
            //取群體的值或取key的時候用g來當代表           
            //dataGridView無法看到g的樹狀結構，用treeView查看

            dataGridView1.DataSource = q.ToList();

            //==========================================
            foreach (var group in q)
            {
                string s = $"{group.MyKey}（{group.MyCount}）";
                TreeNode X = this.treeView1.Nodes.Add(s);
                //TreeNode X = this.treeView1.Nodes.Add(group.MyGroup.ToString());
                foreach (var item in group.MyGroup)
                {
                    X.Nodes.Add(item.ToString());

                }
            }

        }
        private string MyKey(int n)
        {
            if (n < 5)
                return "小"; //若傳入1~4就會直接回傳，不會執行下一行
            if (n <= 10)
                return "中";
            else
                return "大";
        }
        private void btn_group_into_Click(object sender, EventArgs e)
        {
            //練習將key分成三個群組
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 15 };
            var q = from n in nums
                    group n by MyKey(n) into g //利用方法將n分群組，並回傳key值(string)
                    select new { MyKey = g.Key, MyCount = g.Count(), MyAvg = g.Average(), MyGroup = g };
            //一定要加上MyGroup = 「g」，否則樹狀節點不知道要抓哪個群體的資料

            dataGridView1.DataSource = q.ToList();
            //==========================================
            foreach (var group in q)
            {
                string s = $"{group.MyKey}（{group.MyCount}）";
                TreeNode X = this.treeView1.Nodes.Add(s);
                //TreeNode X = this.treeView1.Nodes.Add(group.MyGroup.ToString());
                foreach (var item in group.MyGroup) //抓g之中的所有int n資料
                {
                    X.Nodes.Add(item.ToString());
                }                
            }
            //==========================================
            //利用Chart圖表呈現(工具箱->資料)
            this.chart1.DataSource = q.ToList();
            this.chart1.Series[0].XValueMember = "MyKey";
            this.chart1.Series[0].YValueMembers = "MyCount";
            //ValueMember會自動偵測Key的文字填入資料
            //如果打錯key會報錯
            #region
            //<> f__AnonymousType5`4[System.String, System.Int32, System.Double, System.Linq.IGrouping`2[System.String, System.Int32]] 類型的值，
            //    只可以使用以下類型的值: Double、Decimal、Single、int、long、uint、ulong、String、DateTime、short、ushort。'
            #endregion
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            //決定圖表的型態是什麼。 = 「~~~~」不知道就空白鍵讓VS自動填寫再「.」要的格式

            this.chart1.Series[1].XValueMember = "MyKey";
            this.chart1.Series[1].YValueMembers = "MyAvg";
            this.chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

        }

        private void btn_GroupByExtension_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");
            System.IO.FileInfo[] files = dir.GetFiles();
            this.dataGridView1.DataSource = files;

            var q = from ex in files
                    group ex by ex.Extension into g
                    select new { Extension = g.Key, Count = g.Count(),G=g };

            this.dataGridView3.DataSource = q.ToList();

            foreach (var group in q)
            {
                string s = $"{group.Extension}（{group.Count}）";
                TreeNode X = this.treeView1.Nodes.Add(s);
                //TreeNode X = this.treeView1.Nodes.Add(group.MyGroup.ToString());
                foreach (var item in group.G)
                {
                    X.Nodes.Add(item.ToString());
                }
            }

            this.chart1.DataSource = q.ToList();
            this.chart1.Series[0].XValueMember = "Extension";
            this.chart1.Series[0].YValueMembers = "Count";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");
            System.IO.FileInfo[] files = dir.GetFiles();

            var q = from f in files
                    let s = f.Extension  // let 暫存資料。讓S = f.Extension這個資料
                    where s == ".exe"
                    select f;
            MessageBox.Show("Count = " + q.Count());
            this.dataGridView1.DataSource = q.ToList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //用偵錯+在q上右鍵點監看式查看q的內容

            //集合運算子Distinct / Union / Interest / Except
            int[] nums1 = { 1, 2, 3, 77, 88, 1131, 451321 };
            int[] nums2 = { 1, 2, 3, 77, 77, 77, 5, 87, 781234 };

            IEnumerable<int> q = nums1.Intersect(nums2);
            IEnumerable<int> q2 = nums2.Distinct();

            //數量詞作業 Any / All / Contains
            //切割運算子 Take / TakeWhile / Skip / SkipWhile
            //產生作業 Generation-Range / Repeat / Empty DefaultEmpty
            //元素運算子 First / Last / Single / ElementAt
            //FirstOrDefault / LastOrDefault / SingleOrDefault / EmptyOrDefault

            //轉換資料型別
            //ToList / ToArray / ToDictionary / ToLookUp / AsEnumerable /AsQuerable

            //其他運算子 ConCat / SeQuenceEqual

        }

        private void btn_InnerJoin_Click(object sender, EventArgs e)
        {
            var q = from p in nwDataSet1.Products
                    orderby p.CategoryID
                    group p by p.CategoryID into g
                    select new { CategoryID = g.Key, AVG_UnitPrice = g.Average(p => p.UnitPrice) };

            //            select new { CategoryID = g.Key, AVG_UnitPrice = g.Average() };
            //            嚴重性 程式碼 說明 專案  檔案 行   隱藏項目狀態
            //錯誤  CS1929  'IGrouping<int, NWDataSet.ProductsRow>' 未包含 'Average' 的定義，且最佳擴充方法多載 'Queryable.Average(IQueryable<int>)' 需要類型 'IQueryable<int>' 的接收器 LinqLabs    C:\shared\LINQ_me\LinqLabs_StartUp - master\LinqLabs\4.FrmLINQ_To_XXX.cs 204 作用中
            //  g.Average()  沒寫委派的結果

            dataGridView1.DataSource = q.ToList();

            //==================================

            var q2 = from c in nwDataSet1.Categories join p in this.nwDataSet1.Products on c.CategoryID equals p.CategoryID
                     group p by c.CategoryName into g
                     select new { CategoryName = g.Key, AVG_UnitPrice = g.Average(p => p.UnitPrice) };

            dataGridView3.DataSource = q2.ToList();
            //複習一下這段

        }
    }
}
