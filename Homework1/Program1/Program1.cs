using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework1
{
    class Program1
    {
        static void Main()
        {
            string s = "";
            int a = 0;
            int b = 0;
            int result;
            Console.Write("Please input an number: ");
            s = Console.ReadLine();
            a = Int32.Parse(s);
            Console.Write("Please input an number: ");
            s = Console.ReadLine();
            b = Int32.Parse(s);
            result = a * b;
            Console.Write("两个数的积为：" + result);
        }
    }
}
