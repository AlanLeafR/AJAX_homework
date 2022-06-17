using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hello_Forms;

namespace Console_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;

            Console.WriteLine("Hello World! C#");
            Console.Write("請輸入您要的餐點：");
            sentence = Console.ReadLine();
            Console.WriteLine("您點的餐點是：" + sentence);

            MyFirstMethod mc = new MyFirstMethod();
            mc.method03();
            mc.method06();
            mc.Method07(); //在utility中
            mc.Method08(); //在utility中

            Console.ReadKey();
           
        }
    }
}
