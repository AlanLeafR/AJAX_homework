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


namespace Starter
{
    public partial class FrmLinq_To_Entity : Form
    {
        public FrmLinq_To_Entity()
        {
            InitializeComponent();
            dbContext.Database.Log = Console.WriteLine;
        }
        NorthwindEntities dbContext = new NorthwindEntities();

        // Entity實體資料模型

        // 1.app.config 位於LinqLabs_StartUp-master\packages\EntityFramework.6.2.0\Content\net40
        // 連線字串都已經設定好了，不用再自己接手管
        // 2.NorthwindEntities繼承自DbContext，並將資料欄都變成屬性了
        // public class NorthwindEntities : System.Data.Entity.DbContext
        // 3.參考組件以及DLL檔也自動幫你下載到資料夾中了
        //LinqLabs_StartUp-master\packages\EntityFramework.6.2.0\lib\net40
        // 4.DataSet model 需要處理DB Null ;  Entity Model不需要處理DB Null (會自動ignore)

        private void button1_Click(object sender, EventArgs e)
        {
            // In Memory DB Context
            // 首先要Using NW model的參考，去查看NorthwindEntities在物件瀏覽器底下的命名空間
            //public class NorthwindEntities : System.Data.Entity.DbContext          「  LinqLabs 的成員」(這個)
            
            var q = from p in dbContext.Products
                    where p.UnitPrice > 50
                    select p;

            dataGridView1.DataSource = q.ToList();

                    
         }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = this.dbContext.Categories.First().Products.ToList();
            //利用導覽屬性Products，從dbContext資料庫中找到Categories資料表第一筆資料對應的產品
            //將Categories ID =1 的所有產品列出來
            MessageBox.Show(this.dbContext.Products.First().Category.CategoryName);
            //秀出產品列表第一筆中，從導覽屬性Category找出產品名字
        }

        private void btn_oderby_thenby_Click(object sender, EventArgs e)
        {

            var q = from p in dbContext.Products
                    orderby p.UnitsInStock descending, p.ProductID ascending
                    //依據庫存數量降冪排序，如果有相同的數量則依據產品ID作升冪排序
                    select p;
            this.dataGridView1.DataSource = q.ToList();

            //============================================
            //用lambda表示式和方法寫

            var q2 = this.dbContext.Products.OrderByDescending(p => p.UnitsInStock).ThenBy(p => p.ProductID);
            //order by有內建OrderByDescending方法可直接降冪排序
            //一個排不夠可以用ThenBy繼續排同樣的庫存數量時第二個指定的排序條件
            dataGridView2.DataSource = q2.ToList();


        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            var q = from p in dbContext.Products
                    group p by p.Category.CategoryName into g
                    select new { CategoryName = g.Key, AvgUnitPrice = g.Average(p => p.UnitPrice) };
            //可以跟Frm4的INNER JOIN做比對
            //使用Entity Model就不用再JOIN了，直接利用導覽屬性Category找到CategoryName

            dataGridView1.DataSource = q.ToList();

            //========================================
            
            var q2 = from p in dbContext.Products.AsEnumerable()
                         //若用EntityModel和LINQ語法，使用了自己的方法時系統不知道怎麼轉譯成T-SQL語言會報錯
                         //AsEnumerable()可以告訴VS只需要執行到此行，之後當成是Enumerable的方法

                         //  ※但是會出現沒有實體化p.Category.CategoryName ，為何???※
                     group p by p.Category.CategoryName into g
                    select new { CategoryName = g.Key, AvgUnitPrice = $"{g.Average(p => p.UnitPrice):C2}" };

            dataGridView2.DataSource = q2.ToList();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //bool? b;

            //滑鼠移到OrderDate上會發現有問號
            //型別後面的?代表可為空值
            //上面的b值可以是true、false、null

            var q = from p in this.dbContext.Orders
                    group p by p.OrderDate.Value.Year into g
                    select new { g.Key, count = g.Count() };

            this.dataGridView1.DataSource = q.ToList();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            Product prod = new Product { ProductName = "XXX", Discontinued = false };
            this.dbContext.Products.Add(prod);

            dbContext.SaveChanges();
            //可於輸出監看背後的SQL指令

            #region
            //            於 2022 / 7 / 29 下午 05:19:46 + 08:00
            // 開啟連接
            //於 2022 / 7 / 29 下午 05:19:46 + 08:00
            // 開始交易
            //INSERT[dbo].[Products]([ProductName], [SupplierID], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock], [UnitsOnOrder], [ReorderLevel], [Discontinued])
            //VALUES(@0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, @1)
            //SELECT[ProductID]
            //FROM[dbo].[Products]
            //WHERE @@ROWCOUNT > 0 AND[ProductID] = scope_identity()


            //-- @0: 'XXX'(Type = String, Size = 40)

            //-- @1: 'False'(Type = Boolean)

            //-- 於 2022 / 7 / 29 下午 05:19:47 + 08:00
            // 執行
            //LinqLabs.exe' (CLR v4.0.30319: LinqLabs.exe): 已載入 'C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.Caching\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Runtime.Caching.dll'。已略過載入符號。模組已最佳化，並已啟用 [Just My Code] 偵錯工具選項。
            //-- 於 11 毫秒後完成，結果: SqlDataReader



            //於 2022 / 7 / 29 下午 05:19:47 + 08:00
            // 認可交易
            //於 2022 / 7 / 29 下午 05:19:47 + 08:00
            // 關閉連接
            #endregion

            MessageBox.Show("新增資料成功");

        }
    }
}
