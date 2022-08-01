using LinqLabs;
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
    public partial class FrmLangForLINQ : Form
    {
        public FrmLangForLINQ()
        {
            InitializeComponent();
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n1 = 100, n2 = 200;
            MessageBox.Show("交換前：" + n1 + "," + n2);
            SWAP(ref n1, ref n2);
            MessageBox.Show("交換後：" + n1 + "," + n2);
            //===========================
            string s1 = "aaa", s2 = "bbb";
            MessageBox.Show("交換前：" + s1 + "," + s2);
            SWAP(ref s1, ref s2);
            MessageBox.Show("交換後：" + s1 + "," + s2);


        }
        private void SWAP(ref int n1, ref int n2)  //參數要加上ref才能傳址
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
        private void SWAP(ref string s1, ref string s2)  //參數要加上ref才能傳址
        {
            string temp = s1;
            s1 = s2;
            s2 = temp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string S = SystemInformation.ComputerName;
            MessageBox.Show(S);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int n1 = 100, n2 = 200;
            MessageBox.Show("交換前：" + n1 + "," + n2);
            MyClMethod.SwapAnyType<int>(ref n1, ref n2);
            MessageBox.Show("交換後：" + n1 + "," + n2);

            //===========================

            string s1 = "aaa", s2 = "bbb";
            MessageBox.Show("交換前：" + s1 + "," + s2);
            MyClMethod.SwapAnyType<string>(ref s1, ref s2);
            MessageBox.Show("交換後：" + s1 + "," + s2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.buttonX.Click += ButtonX_Click;
            this.buttonX.Click += aaa;
            this.buttonX.Click += delegate (object sender1, EventArgs e1)
            {
                MessageBox.Show("匿名方法");
            };

            //===============================

            //C#3.0簡潔版匿名方法=>(Lamda表示式)
            //this.buttonX.Click += delegate (object sender1, EventArgs e1)=>
            //{
            //    MessageBox.Show("匿名方法");
            //};

            //this.buttonX.Click += bbb;
            //
            //錯誤  'bbb' 沒有任何多載符合委派 'EventHandler' LinqLabs C:\shared\LINQ_me\LinqLabs_StartUp - master\LinqLabs\2.FrmLangForLINQ.cs 73  

            //使用匿名方法最後要記得加上;
            //參數名稱因為sender,  e已經被原本click事件的委派用過了，所以要改名

        }
        //練習用委派註冊方法
        //委派會指向方法位址，事件可以指向方法清單
        //藉由this.buttonX.Click事件，註冊(+=)ButtonX_Click和aaa的方法
        //如果一開始只點buttonX按鈕，因為沒有註冊事件所以沒有事情發生
        //當點下 button2_Click則執行內部的註冊code，所以buttonX.Click註冊了上述兩個方法
        //如果事件的參數不符合委派的定義，則會報錯

        private void aaa(object sender, EventArgs e)
        {
            MessageBox.Show("aaa");
        }

        private void ButtonX_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ButtonX_Click");
        }

        //private void bbb(int a, int b)
        //{
        //    throw new NotImplementedException();
        //}

        bool Test(int n)
        {
            return n > 5;
        }

        delegate bool MyDelegate(int n);
        private void btnLambda_Click(object sender, EventArgs e)
        {
            bool Result = Test(10);
            MessageBox.Show("Result = " + Result);

            //C# 1.0 具名方法
            MyDelegate delegateObject = Test;  //new MyDelegate(Test); 
            //可以使用語法糖直接打上方法名稱
            Result = delegateObject.Invoke(2);  //delegateObject(2);
            //委派加上invoke，讓code更明確。invoke = 啟用   委派的方法
            MessageBox.Show("C# 1.0 具名方法 Result = " + Result);

            //delegateObject = aaa;            
            //錯誤  'aaa' 沒有任何多載符合委派 'FrmLangForLINQ.MyDelegate'  

            //==========================================
            //C# 2.0 匿名方法
            delegateObject = delegate (int n)
                                                                 {
                                                                     return n % 2 == 0;
                                                                 };
            //delegateObject = delegate (int n, int aa)           
            //錯誤  委派 'FrmLangForLINQ.MyDelegate' 不接受 2 個引數 LinqLabs 

            Result = delegateObject(8);
            MessageBox.Show("C# 2.0 匿名方法 Result =" + Result);

            //==========================================
            //C# 3.0 匿名方法簡潔版─Labmda Expression=>
            //Lambda運算式事件立委派最簡單的方法
            //更抽象、沒有參數型別、沒寫return，只剩下參數內容和陳述式=>非常高階的抽象

            delegateObject = n => n % 2 == 0;
            Result =  delegateObject(9);
            MessageBox.Show("C# 3.0 Labmda Expression Result =" + Result);

        }

        static List<int> MyWhere(int[] nums , MyDelegate delegateObj)
        {
            List<int> list_isEven = new List<int>();
            foreach(int n in nums)
            {
                if (delegateObj(n))
                    list_isEven.Add(n);
            }
            return list_isEven;
        }

        private void btnMyWhere_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> list_Over5= MyWhere(nums, Test); //具名方法
            List<int> list_Odd = MyWhere(nums, n=>n%2!=0); //Lambda 匿名方法求奇數
            List<int> list_Even = MyWhere(nums, n => n % 2 == 0); //Lambda 匿名方法求偶數

            foreach(int n in list_Over5)
            {
                listBox1.Items.Add(n);
            }
            foreach (int n in list_Odd)
            {
                listBox2.Items.Add(n);
            }

        }
        static IEnumerable<int> MyIterator(int[] nums, MyDelegate delegateObj)
        {           
            foreach (int n in nums)
            {
                if (delegateObj(n))
                    yield return n;
            }            
        }
        private void btnYieldReturn_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> q = MyIterator(nums, n => n % 2 == 0);
            
            foreach(int n in q)
            {
                listBox1.Items.Add(n);
            }
            
        }

        private void btn_LINQseeCsharp_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 
            
            //IEnumerable<int> q = from n in nums
            //                                            where n>5
            //                                            select n;

            //IEnumerable<int> q = MyWhere(nums, n => n > 5);          
            var q =nums.Where( n => n > 5); //用擴充功能Where實作條件篩選的功能
            foreach (int n in q)
            {
                listBox1.Items.Add(n);
            }

            //了解擴充功能Where背後運行的原理，就是從迭代器、foreach迴圈、
            //委派、匿名方法以及yield return結合而成。以後若需要使用where篩選
            //功能直接.Where(n=> code內容)即可

            //================================

            string[] words = { "aaa", "bbb", "scscaac", "hwuihwdwada" };
            IEnumerable<string> q2 = words.Where<string>(w => w.Length > 5);
            //Where<T source>的泛型型別來源會根據前面「變數.」來決定，
            //原則上省略由系統自動判斷
            this.listBox2.Items.Clear();
            foreach(string W_Over5 in q2)
            {
                this.listBox2.Items.Add(W_Over5);
            }
            //================================


            //this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            //Fill只需要一次，多次Fill會報錯。故將這行移至建構子的部分就不用每次都Fill

            //利用原本LINQ查詢方法找價格>30的產品
            //var q3 = from Price_Over30 in nwDataSet1.Products
            //        where Price_Over30.UnitPrice > 30
            //        select Price_Over30;
            //this.dataGridView1.DataSource = q3.ToList();

            //利用擴充功能Where節省力氣
            var q3 = nwDataSet1.Products.Where(p => p.UnitPrice > 30);
            this.dataGridView1.DataSource = q3.ToList();
        }

        private void btn_VarTaste_Click(object sender, EventArgs e)
        {
            int n = 1 ;
            var s = "addaca";
            var p = new Point(100,200);

            MessageBox.Show(s+","+n);
            MessageBox.Show(p.X+","+p.Y);
        }
        private void btn_Object_Initializer_Click(object sender, EventArgs e)
        {
            MyPoint pt1 = new MyPoint();
            pt1.P1 = 100; //set; int w = pt1.P1; //get
            pt1.P2 = 200; //set

            MyPoint pt2 = new MyPoint(99); //Constructor()
            MyPoint pt3 = new MyPoint(88,77);

            List<MyPoint> list_P = new List<MyPoint>();
            list_P.Add(pt1);
            list_P.Add(pt2);
            list_P.Add(pt3);

            //C# 3.0 {  }object initialize 物件初始化

            list_P.Add(new MyPoint {P1=1,P2=2,Field1="axaxa",Field2="jjojo"});
            list_P.Add(new MyPoint { P1=34});
            list_P.Add(new MyPoint { P1 = 435431, P2 = 488431 });

            dataGridView1.DataSource = list_P; //可以在此設中斷點查看pt1和list_P
            //觀察發現list_P有包含Field1~2、P1~2，但是dataGridView最後只呈現屬性欄位

            List<MyPoint> list_P2 = new List<MyPoint>()
            {
                new MyPoint{ P1=3, P2=344 },
                new MyPoint{ P1 = 484},
                new MyPoint{ P2 =46687 }
            };
            //連續用兩次建構子初始化建構 list_P2 和MyPoint內的資料
            //注意建構子初始化要用「{  }」，建構子內欄位之間用 「,」 隔開
            dataGridView2.DataSource = list_P2;
        }

        private void btn_Anonymouse_Type_Click(object sender, EventArgs e)
        {
            var pt1 = new { P1 = 1213, P2 = 1231321, P3 = "scacacas", P4 = 3.14, P5 = true };
            var pt2 = new { P1 = 13, P2 = 121, P3 = "kokodayo" };
            var pt3 = new { P1 = 55.66, P5 = true };
            //匿名型別初始化可以增添任意欄位，資料型態也隨意

            this.listBox1.Items.Add(pt1.GetType()); //查看匿名型別的型別到底是什麼
            this.listBox1.Items.Add(pt2.GetType());//一長串很難理解的系統文字
            this.listBox1.Items.Add(pt2.GetType());
            //===========================

            //利用匿名型別搭配LINQ查詢

            // 1.用一般LINQ查詢方式寫

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var q = from n in nums
            //        where n > 5
            //        select new { N = n, Square = n * n, Cube = n * n * n };

            // 2.用擴充方法Where+Select+Lambda表示式+匿名方法寫
            // 今日所學集大成
            var q = nums.Where(n => n > 5).Select( n=>new { N = n, Square = n * n, Cube = n * n * n });

            // IEnumerable<int> q = from n in nums
            //錯誤  無法將類型 'System.Collections.Generic.IEnumerable<<anonymous type: int N, int Square, int Cube>>' 隱含轉換成 'System.Collections.Generic.IEnumerable<int>'。已存在明確轉換(是否漏了轉型 ?) 
            //所以要將型別設成var，才能接到匿名型別
            this.dataGridView1.DataSource = q.ToList();

            //===========================

            //利用NW DataBase+匿名型別搭配LINQ查詢
            //已經將adapter code放入建構子中，不用再Fill一次

            // 1.用一般LINQ查詢方式寫
            //var q2 = from p in nwDataSet1.Products
            //         where p.UnitPrice > 50
            //         select new
            //         {
            //             ID = p.ProductID,
            //             產品名稱 = p.ProductName,
            //             p.UnitPrice,
            //             p.UnitsInStock,
            //             total = p.UnitPrice * p.UnitsInStock
            //         };

            // 2.用擴充方法Where+Select+Lambda表示式+匿名方法寫
            // 今日所學集大成

            var q2 = nwDataSet1.Products.Where(p => p.UnitPrice > 50).Select(p => new
            {
                ID = p.ProductID,
                產品名稱 = p.ProductName,
                p.UnitPrice,
                p.UnitsInStock,
                total =  $"{p.UnitPrice * p.UnitsInStock,10:C2}" //標準化輸入
            }
            );

            this.dataGridView2.DataSource = q2.ToList();

        }

        private void button32_Click(object sender, EventArgs e)
        {
            //練習製作擴充方法
            //首先要先在namespace底下創立靜態類別之中的靜態方法
            //錯誤   擴充方法必須定義在最上層靜態類別中; MyStringExtend 為巢狀類別
            //注意都要是public & static

            string Ex_method_string = "scscacacako";
            int count = Ex_method_string.WordCount();
            MessageBox.Show("count = " + count);

            //================================

            string s2 = "abcdefg";
            char c2 = s2.Chars_Index(3);
            MessageBox.Show("Chars = " + c2);
        }

//錯誤   擴充方法必須定義在最上層靜態類別中; MyStringExtend 為巢狀類別


    }
    public static class MyStringExtend
    {
        public static int WordCount(this string s)
        {
            return s.Length; //Length是string的屬性不是方法
        }

        public static char Chars_Index(this string s,int index)
        {
            return s[index];
        }
    }

    class MyPoint
    {
       internal string Field1 = "AAA", Field2 = "BBB"; 
        // 欄位：Field。class裡的區域變數稱為欄位。通常是設定private或protect
        private int m_P1;

        internal MyPoint() //建構子Constructor()
        {

        }
        internal MyPoint(int p1)
        {
            this.P1 = p1;
        }
        internal MyPoint(int p1,int p2)
        {
            this.P1 = p1;
            this.P2 = p2;
        }

        public int P1
        {
            get
            {
                //一段logic運算後...
                return m_P1;
            }
            set
            {
                //一段logic運算後...
                m_P1 = value;
            }
        }
        public int P2 { get; set; }
    }    
}
