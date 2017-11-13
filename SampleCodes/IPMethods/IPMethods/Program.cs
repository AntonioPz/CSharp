using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPMethods.Class;
using System.Net;

namespace IPMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                LocalIPAddress.RunIpAddressDetection("192.168.92.");

                //LocalIPAddress.GetYourOwnIpAddress();

                //LocalIPAddress.NetworkInfo();

                //Server myServer = new Server();
                //myServer.GetServer(args);

                Console.WriteLine("######################################################################");

                Console.WriteLine("Press 'enter' for try again or, press 'c' and 'enter' for clear screen");                
                var key= Console.ReadLine();
                if (key=="c")
                    Console.Clear();
                    
            }
        }
        
    }
}
