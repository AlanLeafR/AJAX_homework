using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLabs
{
    class MyClMethod
    {
        internal static void SwapAnyType<T>(ref T n1,ref T n2)
        {
            T temp = n2;
            n2 = n1;
            n1 = temp;
        }

    }
}
