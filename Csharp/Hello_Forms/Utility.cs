using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_Forms
{
    public class ProductS
    {
        public int proPrice, proCount;
        public string proName;

        //public ProductStd(string name,int count,int pri)
        //{
        //    proPrice = pri;
        //    proName = name;
        //    proCount = count;
        //}

        public void reset()
        {
            proPrice = 0;            
            proCount = 0;
        }

        
    }
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

    public class UseStatic
    {
        public int InstanceCount;
        public static int StaticCount;
    }

    public enum UserRole
    {
        Admin = 0,
        User = 1,
    }

    struct Products
    {
        public string ProductName;
        public decimal ProductPrice;
        Products(string name, decimal price)
        {
           ProductName = name;
           ProductPrice = price;
        }
    }

    public struct Employee
    {
        public string employeeName;
        public int employeeAge;        
    }

    public struct StudentScore
    {
        public string StudentName;
        public int ChineseScore;
        public int EnglishScore;
        public int MathScore;
        public double TotalScore;
        public double AverageScore;


    }

}

