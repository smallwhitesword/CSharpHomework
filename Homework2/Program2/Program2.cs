using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program2
    {
        static void Main(string[] args)
        {
            int[] numbers = {3, 56, 8, 13, 26, 8, 77, 65, 42};
            int maxV = numbers[0];
            int minV = numbers[0];
            int sum = 0;
            for(int i=0;i<numbers.Length;i++)
            {              
                if (maxV < numbers[i])
                    maxV = numbers[i];
                if (minV > numbers[i])
                    minV = numbers[i];             
                sum += numbers[i];
            }
            float ave = 0;
            ave = sum / numbers.Length;
            Console.WriteLine("数组的最大值为：" + maxV);
            Console.WriteLine("数组的最小值为：" + minV);
            Console.WriteLine("数组的平均值为：" + ave);
            Console.WriteLine("数组元素的和为：" + sum);
        }
    }
}
