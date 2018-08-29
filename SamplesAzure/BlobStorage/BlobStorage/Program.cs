using System;
using BlobStorage.Classes;

namespace BlobStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            AzureStorageSdk.UploadBlob("image-path");
            AzureStorageApi azureSA = new AzureStorageApi("account", "key");
            azureSA.PutBlob("container", "new.jpg", "C:\\Users\\Anton\\Desktop\\test.jpg");
            azureSA.DeleteBlob("container","new.jpg");
            azureSA.ListBlobs("container");
            azureSA.GetBlob("container","new.jpg");
            Console.Read();
        }
        
    }
}
