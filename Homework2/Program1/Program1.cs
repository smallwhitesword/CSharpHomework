using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个数：");
            string s = "";
            s = Console.ReadLine();
            int n = Int32.Parse(s);

            Console.Write(s + "的所有素数因子是：");
            for (int i=2;i<n+1;i++)
            {
                while(n%i==0)
                {
                    Console.Write(i+" ");
                    n = n / i;
                }
                if (n == i)
                {
                    break;
                }
            }
        }
    }
}
