using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IPMethods.Class
{
    class LocalIPAddress
    {
        private static List<Ping> pingers= new List<Ping>();
        private static int instances = 0;
        private static object @lock = new object();
        private static int result = 0;
        private static int timeOut = 5000;
        private static int ttl = 5;
        
        public static void RunIpAddressDetection(string BaseIP)
        {
            result = 0;
            //string baseIP = "192.168.92.";

            Console.WriteLine("Pinging 255 destinations of C-class in {0}*", BaseIP);

            CreatePingers(255);

            PingOptions po = new PingOptions(ttl, true);
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            byte[] data = enc.GetBytes("abababababababababababababababab");

            SpinWait wait = new SpinWait();
            int cnt = 1;

            Stopwatch watch = Stopwatch.StartNew();

            foreach (Ping p in pingers)
            {
                lock (@lock)
                {
                    instances += 1;
                }

                p.SendAsync(string.Concat(BaseIP, cnt.ToString()), timeOut, data, po);
                cnt += 1;
            }

            while (instances > 0)
            {
                wait.SpinOnce();
            }

            watch.Stop();

            DestroyPingers();

            Console.WriteLine("Finished in {0}. Found {1} active IP-addresses.", watch.Elapsed.ToString(), result);

        }
        public static void Ping_completed(object s, PingCompletedEventArgs e)
        {
            lock (@lock)
            {
                instances -= 1;
            }

            if (e.Reply.Status == IPStatus.Success)
            {
                try
                {
                    //IPHostEntry host = Dns.GetHostByAddress(e.Reply.Address.ToString());
                    //Console.WriteLine(string.Concat("Active IP: ", e.Reply.Address.ToString()," - ", host.HostName));
                    Console.WriteLine(string.Concat("Active IP: ", e.Reply.Address.ToString()));
                    result += 1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Ping_Completed: "+ ex.ToString());
                }
                
            }
            else
            {
                //Console.WriteLine(String.Concat("Non-active IP: ", e.Reply.Address.ToString()))
            }
        }
        private static void CreatePingers(int cnt)
        {
            for (int i = 1; i <= cnt; i++)
            {
                Ping p = new Ping();
                p.PingCompleted += Ping_completed;
                pingers.Add(p);
            }
        }
        private static void DestroyPingers()
        {
            foreach (Ping p in pingers)
            {
                p.PingCompleted -= Ping_completed;
                p.Dispose();
            }

            pingers.Clear();

        }
        public static string GetYourOwnIpAddress()
        {   
            // Get host name
            String strHostName = Dns.GetHostName();
            string YourIPAddress = null;
            // Find host by name
            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);

            // Enumerate IP addresses
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                YourIPAddress = ipaddress.ToString();
            }
            return YourIPAddress;
        }
        public static void NetworkInfo()
        {
            foreach (NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                Console.WriteLine("Name: " + netInterface.Name);
                Console.WriteLine("Description: " + netInterface.Description);
                Console.WriteLine("Addresses: ");
                IPInterfaceProperties ipProps = netInterface.GetIPProperties();
                foreach (UnicastIPAddressInformation addr in ipProps.UnicastAddresses)
                {
                    Console.WriteLine(" " + addr.Address.ToString());
                }
                Console.WriteLine("______________________________________________________________________");
            }
        }
    }
}
