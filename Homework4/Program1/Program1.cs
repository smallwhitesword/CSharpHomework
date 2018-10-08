using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class ClockEventArgs : EventArgs
    {
        public DateTime dateTime;
        public DateTime clockTime;
        public TimeSpan duration;
    }
    public delegate void ClockHandler(object sender, ClockEventArgs e);
    public class Clock
    {
        public event ClockHandler ClockSet;
        public void set(DateTime tempTime)
        {
            ClockEventArgs args = new ClockEventArgs();
            args.dateTime = DateTime.Now;
            args.clockTime = tempTime;
            while (args.dateTime < args.clockTime)
            {
                System.Threading.Thread.Sleep(1000);
                if (args.clockTime != args.dateTime)
                {
                    args.dateTime = DateTime.Now;
                    ClockSet(this, args);
                }
            }
            Console.WriteLine("闹钟时间到！");
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入闹钟时间,如：");
            Console.WriteLine(DateTime.Now);
            DateTime clock;
            String s;
            s = Console.ReadLine();
            clock = Convert.ToDateTime(s);
            var myclock = new Clock();
            //注册事件
            myclock.ClockSet += ShowTime;
            myclock.set(clock);
        }
        static void ShowTime(object sender, ClockEventArgs e)
        {
            Console.WriteLine("闹钟倒计时！");
        }
    } 
}