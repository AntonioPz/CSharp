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
        public static string ipAdd=null;
        static void Main(string[] args)
        {
            while (true)
            {
                string newipadd = "";
                char[] mca = LocalIPAddress.GetYourOwnIpAddress().ToString().ToCharArray();
                int cout = 0;
                for (int i = 0; i < mca.Length; i++)
                {
                    newipadd += mca[i];
                    if (mca[i] == '.')
                        cout++;
                    if (cout==3)
                        break;
                }
                LocalIPAddress.RunIpAddressDetection(newipadd);

                //LocalIPAddress.GetYourOwnIpAddress();

                //LocalIPAddress.NetworkInfo();

                //Server myServer = new Server();
                //myServer.GetServer(args);

                Console.WriteLine("######################################################################");

                Console.WriteLine("Press 'enter' for try again or \nEnter 'c' for clear screen");                
                var key= Console.ReadLine();
                if (key == "c")
                    Console.Clear();
            }
        }
        
    }
}
