using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Http
{
    class Program
    {
        static void Main(string[] args)
        {
            DownloadFileUwp();
        }

        private static void DownloadFileUwp()
        {
            var task = Task.Run(async () =>
            {
                HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("http://www.techcoil.com/ph/img/logo.png");
                httpRequest.Method = "GET";
                WebResponse resp = await httpRequest.GetResponseAsync();
                using (Stream hrStream = resp.GetResponseStream())
                {
                    var reader = new StreamReader(hrStream, Encoding.UTF8);
                    using (var memstream = new MemoryStream())
                    {
                        var buffer = new byte[512];
                        var bytesRead = default(int);
                        while ((bytesRead = reader.BaseStream.Read(buffer, 0, buffer.Length)) > 0)
                            memstream.Write(buffer, 0, bytesRead);
                        var data = memstream.ToArray();
                        File.WriteAllBytes("dfuLogo.png", data);
                    }

                }
            });
            task.Wait();
        }
        static void DownloadfileConsole()
        {
            using (var client = new System.Net.WebClient())
            {
                client.DownloadFileAsync(new Uri("http://www.techcoil.com/ph/img/logo.png"), "dfcLogo.png");
            }
        }
    }
}
