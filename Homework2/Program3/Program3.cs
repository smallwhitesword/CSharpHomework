using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class Program3
    {
        static void Main(string[] args)
        {

           
            Console.Write("100以内的所有素数是：");
            for (int n = 2; n <= 100; n++)
            {
                int i;
                for (i = 2; i < n; i++)
                    if (n % i == 0)
                        break;
                    if(n==i)
                    Console.Write(i+" ");             
            }
        }
    }
}
