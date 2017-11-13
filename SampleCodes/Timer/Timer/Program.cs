using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TaskWithTimer
{
    class Program
    {
        public static Timer myTimer;
        static void Main(string[] args)
        {
            myTimer = new Timer(3000);
            myTimer.Elapsed += new ElapsedEventHandler(RunThis);
            myTimer.AutoReset = true;
            myTimer.Enabled = true;
            Console.Read();
        }
        private static void RunThis(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Print this line in every 3 seconds   "+"##"+DateTime.Now+"##");
        }
    }
}
