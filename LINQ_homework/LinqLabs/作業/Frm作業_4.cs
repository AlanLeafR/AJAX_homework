using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqLabs;

namespace LinqLabs.作業
{
    public partial class Frm作業_4 : Form
    {
        public Frm作業_4()
        {
            InitializeComponent();
        }
        NorthwindEntities dbContext = new NorthwindEntities();
        private string MyClassification_int(int n)
        {
            if (n < 5)
                return "小";
            if (n < 10)
                return "中";
            else
                return "大";
        }

        private string MyClassification_FileSize(System.IO.FileInfo file)
        {
            if (file.Length > 999999)
                return "大檔案(>1mb)";
            else
                return "小檔案(<1mb)";
        }
        private System.IO.FileInfo[] GetPath()
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");

            System.IO.FileInfo[] files = dir.GetFiles();            

            return files;
        }

        private int MyClassification_FileYear(System.IO.FileInfo file)
        {
            return file.CreationTime.Year;
        }

        private string MyClassification_ProductsPrice(Product P)
        {
            if (P.UnitPrice < 10)
                return "1.Low_Price(0-9 US$)";
            if (P.UnitPrice < 41)
                return "2.Middle_Price(10-40 US$)";
            else
                return "3.High_Price(over 40$)";
        }

        private void RefreshScreen()
        {
            this.dataGridView1.Columns.Clear();
            this.dataGridView2.Columns.Clear();
            treeView1.Nodes.Clear();
        }

        // 作業4使用的外部方法
        //===========================================
        private void btn_Classification_int_Click(object sender, EventArgs e)
        {
            RefreshScreen();
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 15 };
            var q = from n in nums
                    group n by MyClassification_int(n) into g
                    select new { g.Key ,  g };

          foreach (var group in q)
            {
                TreeNode X = treeView1.Nodes.Add(group.Key);
                foreach (var item in group.g)
                {
                    X.Nodes.Add(item.ToString());
                }
            }
                   
        }

        private void btn_Classification_FileSize_Click(object sender, EventArgs e)
        {
            RefreshScreen();

            var q2 = from data in GetPath()
                    orderby data.Length descending                    
                    select data;

            var q = from file in GetPath()
                    group file by MyClassification_FileSize(file) into g
                    orderby g.Key ascending
                    select new { FileClassification =  g.Key,  g };

            this.dataGridView1.DataSource = q.ToList();
            this.dataGridView2.DataSource = q2.ToList();

            foreach (var group in q)
            {
                TreeNode X = treeView1.Nodes.Add(group.FileClassification);
                foreach (var item in group.g)
                {
                    string s2 = $"{item}（{item.Length}）";
                    X.Nodes.Add(s2);
                }
            }
        }

        private void btn_Classification_FileYear_Click(object sender, EventArgs e)
        {
            RefreshScreen();

            var q2 = from data in GetPath()
                     orderby data.CreationTime descending
                     select data;

            var q = from file in GetPath()
                    group file by MyClassification_FileYear(file) into g         
                    orderby g.Key descending
                    select new { FileCreationTime = g.Key, g };

            this.dataGridView1.DataSource = q.ToList();
            this.dataGridView2.DataSource = q2.ToList();
            this.dataGridView2.Columns["CreationTime"].DisplayIndex = 1;

            foreach (var group in q)
            {
                string s = $"{group.FileCreationTime.ToString()}（{group.g.Count()}筆） ";
                TreeNode X = treeView1.Nodes.Add(s);
                foreach (var item in group.g)
                {                    
                    X.Nodes.Add(item.ToString());                    
                }
            }

        }

        private void btn_NW_Products_Click(object sender, EventArgs e)
        {
            RefreshScreen();
            var q = this.dbContext.Products.OrderBy(p => p.UnitPrice);
            dataGridView2.DataSource = q.ToList();
            this.dataGridView2.Columns["UnitPrice"].DisplayIndex = 2;

            var q2 = from p in dbContext.Products.AsEnumerable()
                     group p by MyClassification_ProductsPrice(p) into g
                     orderby g.Key 
                     select new {  PriceLevels=g.Key, Count=g.Count() , g };

            this.dataGridView1.DataSource = q2.ToList();

            foreach(var group in q2)
            {
                string s = $"{group.PriceLevels}（{group.Count}筆）";
                TreeNode X = treeView1.Nodes.Add(s);
                foreach(var item in group.g)
                {
                    string s2 = $"{item.ProductName}：{item.UnitPrice}";                    
                    X.Nodes.Add(s2);
                    treeView1.Sort();
                }
            }
            //Q：如何對子節點做排序?
        }

        private void btn_NwOders_GroupByYear_Click(object sender, EventArgs e)
        {
            RefreshScreen();

            var q = this.dbContext.Orders.OrderBy(o => o.OrderDate)
                .GroupBy(p => p.OrderDate.Value.Year)                
                .Select(p => new { Year = p.Key, Count = p.Count() , p});
            this.dataGridView1.DataSource = q.ToList();
            this.dataGridView1.Columns[2].Visible = false;

            var q2 = this.dbContext.Orders.OrderBy(p => p.OrderID);
            this.dataGridView2.DataSource = q2.ToList();

            foreach(var group in q)
            {
                TreeNode X = treeView1.Nodes.Add(group.Year.ToString() );
                foreach (var item in group.p)
                {
                    string s = $"OrderID ： {item.OrderID}";
                    X.Nodes.Add(s);
                }
            }
            
        }

        private void btn_NwOders_GroupByYearMonth_Click(object sender, EventArgs e)
        {
            RefreshScreen();

            var q2 = this.dbContext.Orders.Select(order => order);
            this.dataGridView2.DataSource = q2.ToList();

            var q = this.dbContext.Orders.OrderBy(o => o.OrderDate)
               .GroupBy(o => o.OrderDate.Value.Year)
               .Select(o => new
               {
                   Year = o.Key,
                   Count = o.Count(),
                   OrderGroup = o.GroupBy( p => p.OrderDate.Value.Month).Select(p => new { p.Key,MyP=p})  //key是月份、MyP是以月份當為群組後的群組內資料                 
            }) //OrderGroup 之後不能使用select new新的欄位，這樣只是在原本的o進行操作。
               //要o.GroupBy月份把月份變成群組之後再對群組內的資料作操作
               ;

            dataGridView1.DataSource = q.ToList();

            foreach (var group in q)
            {
                TreeNode X = treeView1.Nodes.Add(group.Year.ToString() );
                 foreach(var month in group.OrderGroup)
                {
                    string s = $"{month.Key}月份訂單";
                    TreeNode X2 = X.Nodes.Add(s);                   
                    
                    foreach (var item in month.MyP) 
                    {
                        string s2 = $"OrderID：{item.OrderID}、CustomerID：{item.CustomerID}、OrderDate：{item.OrderDate.Value.Month}月{item.OrderDate.Value.Day}號";
                        X2.Nodes.Add(s2);
                    }
                }   
            }

        }

        private void btn_SalesFigures_Click(object sender, EventArgs e)
        {
            RefreshScreen();
            var q2 = this.dbContext.Order_Details.AsEnumerable().Select(od => new { OrderID = od.OrderID, Sales = ((decimal)od.UnitPrice) * ((decimal)od.Quantity) * ((decimal)(1 - od.Discount)) });
            this.dataGridView2.DataSource = q2.ToList();

            var q = this.dbContext.Order_Details.AsEnumerable().GroupBy(od => od.OrderID).Select(od => new { OrderID = od.Key, Total = od.Sum(p => (decimal)p.UnitPrice * (decimal)p.Quantity * (decimal)(1 - p.Discount)) });
            this.dataGridView1.DataSource = q.ToList();

            var q3 = this.dbContext.Order_Details.AsEnumerable().Select(od =>  od.UnitPrice * od.Quantity * (decimal)(1 - od.Discount)) ; 
            decimal B=0;
            foreach (decimal A in q3)
            {
                 B += A;
            }

            MessageBox.Show("總銷售金額："+B.ToString("0.00")+"元" );

        }

        private void btn_Top5_SalesPerson_Click(object sender, EventArgs e)
        {
            RefreshScreen();

            //var q = from sales in this.dbContext.Order_Details
            //        group sales by sales.Order.EmployeeID

            var q = from sales in this.dbContext.Orders.AsEnumerable()
                    group sales by sales.EmployeeID into g
                    orderby g.Sum(p => p.Order_Details.Sum(o => o.UnitPrice * o.Quantity * (decimal)(1 - o.Discount))) descending
                    select new { sales = g.Key, total = g.Sum(p=>p.Order_Details.Sum(o=>o.UnitPrice*o.Quantity*(decimal)(1-o.Discount))) };
                    

            this.dataGridView1.DataSource = q.Take(5).ToList();

        }

        private void btn_Top5_Sales_Price_Click(object sender, EventArgs e)
        {
            RefreshScreen();
            var q = from product in this.dbContext.Products
                    orderby product.UnitPrice descending
                    select new { product.ProductName,product.UnitPrice,product.Category.CategoryName};

            this.dataGridView1.DataSource = q.Take(5).ToList();

        }

        private void btn_IsOver300_Click(object sender, EventArgs e)
        {
            var q = (from p in this.dbContext.Products
                     where p.UnitPrice > 300
                     select p).Any();
            MessageBox.Show(q.ToString());
        }
    }
}
