using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlobStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.UploadBlob("image-path");
            Console.Read();
        }
        static void UploadBlob(string path)
        {
            string accountname = "your-account-name";
            string accesskey = "your-access-key";
            try
            {
                //Add NuGet WindowsAzure.Storege
                StorageCredentials creden = new StorageCredentials(accountname, accesskey);
                CloudStorageAccount acc = new CloudStorageAccount(creden, useHttps: true);
                CloudBlobClient client = acc.CreateCloudBlobClient();
                CloudBlobContainer cont = client.GetContainerReference("testblob");
                cont.CreateIfNotExists();
                cont.SetPermissions(new BlobContainerPermissions
                {
                    PublicAccess = BlobContainerPublicAccessType.Blob
                });
                CloudBlockBlob cblob = cont.GetBlockBlobReference("New-image-name.extension");

                using (Stream file = System.IO.File.OpenRead(@"" + path))
                {
                    cblob.UploadFromStream(file);
                    Console.WriteLine("Your image was upload");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ERROR:" + ex.ToString());
            }
        }
    }
}
