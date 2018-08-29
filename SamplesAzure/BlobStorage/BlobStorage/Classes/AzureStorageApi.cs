//https://github.com/khaueviana/azure-blob-storage-rest

using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace BlobStorage.Classes
{
    public class AzureStorageApi
    {
        private static string ACCOUNT_NAME;
        private static string STORAGE_ACCOUNT_KEY;
        private static string STORAGE_ENDPOINT;

        public AzureStorageApi(string accountName, string storageAccountKey)
        {
            ACCOUNT_NAME = accountName;
            STORAGE_ACCOUNT_KEY = storageAccountKey;
            STORAGE_ENDPOINT = "https://" + ACCOUNT_NAME + ".blob.core.windows.net/";
        }
        public void PutBlob(string container, string blobName, string filePath)
        {
            const string requestMethod = "PUT";
            var urlPath = String.Format("{0}/{1}", container, blobName);
            const string storageServiceVersion = "2014-02-14";
            var dateInRfc1123Format = DateTime.UtcNow.ToString("R", CultureInfo.InvariantCulture);
            var blobContent = File.ReadAllBytes(filePath);
            var blobLength = blobContent.Length;
            const String blobType = "BlockBlob";
            var canonicalizedHeaders = String.Format(
                    "x-ms-blob-type:{0}\nx-ms-date:{1}\nx-ms-version:{2}",
                    blobType,
                    dateInRfc1123Format,
                    storageServiceVersion);

            var canonicalizedResource = String.Format("/{0}/{1}", ACCOUNT_NAME, urlPath);
            var stringToSign = String.Format("{0}\n\n\n{1}\n\n\n\n\n\n\n\n\n{2}\n{3}",
                    requestMethod,
                    blobLength,
                    canonicalizedHeaders,
                    canonicalizedResource);

            var authorizationHeader = CreateAuthorizationHeader(stringToSign);

            var uri = new Uri(STORAGE_ENDPOINT + urlPath);
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = requestMethod;
            request.Headers.Add("x-ms-blob-type", blobType);
            request.Headers.Add("x-ms-date", dateInRfc1123Format);
            request.Headers.Add("x-ms-version", storageServiceVersion);
            request.Headers.Add("Authorization", authorizationHeader);
            request.ContentLength = blobLength;

            using (var requestStream = request.GetRequestStream())
            {
                requestStream.Write(blobContent, 0, blobLength);
            }
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                var eTag = response.Headers["ETag"];
            }
        }
        public void DeleteBlob(string container, string blobName)
        {
            const string requestMethod = "DELETE";
            var urlPath = String.Format("{0}/{1}", container, blobName);
            const string storageServiceVersion = "2014-02-14";
            var dateInRfc1123Format = DateTime.UtcNow.ToString("R", CultureInfo.InvariantCulture);
            const String blobType = "BlockBlob";
            var canonicalizedHeaders = String.Format(
                    "x-ms-blob-type:{0}\nx-ms-date:{1}\nx-ms-version:{2}",
                    blobType,
                    dateInRfc1123Format,
                    storageServiceVersion);

            var canonicalizedResource = String.Format("/{0}/{1}", ACCOUNT_NAME, urlPath);
            var stringToSign = String.Format("{0}\n\n\n\n\n\n\n\n\n\n\n\n{1}\n{2}",
                    requestMethod,
                    canonicalizedHeaders,
                    canonicalizedResource);

            var authorizationHeader = CreateAuthorizationHeader(stringToSign);

            var uri = new Uri(STORAGE_ENDPOINT + urlPath);
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = requestMethod;
            request.Headers.Add("x-ms-blob-type", blobType);
            request.Headers.Add("x-ms-date", dateInRfc1123Format);
            request.Headers.Add("x-ms-version", storageServiceVersion);
            request.Headers.Add("Authorization", authorizationHeader);

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                Console.WriteLine(response.StatusCode);
            }
        }
        public void ListBlobs(string containerName)
        {
            const string requestMethod = "GET";
            var urlPath = String.Format("restype=container&comp=list");
            const string storageServiceVersion = "2014-02-14";
            var dateInRfc1123Format = DateTime.UtcNow.ToString("R", CultureInfo.InvariantCulture);
            var canonicalizedHeaders = String.Format(
                    "x-ms-date:{0}\nx-ms-version:{1}",
                    dateInRfc1123Format,
                    storageServiceVersion);
            var canonicalizedResource = String.Format("/{0}/{1}{2}", ACCOUNT_NAME, containerName, "\ncomp:list\nrestype:container");
            var stringToSign = String.Format("{0}\n\n\n\n\n\n\n\n\n\n\n\n{1}\n{2}",
                    requestMethod,
                    canonicalizedHeaders,
                    canonicalizedResource);
            var authorizationHeader = CreateAuthorizationHeader(stringToSign);
            var uri = new Uri(STORAGE_ENDPOINT + containerName + "?" + urlPath);
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = requestMethod;
            request.Headers.Add("x-ms-date", dateInRfc1123Format);
            request.Headers.Add("x-ms-version", storageServiceVersion);
            request.Headers.Add("Authorization", authorizationHeader);
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    var reader = new StreamReader(stream, Encoding.UTF8);
                    var responseXml = reader.ReadToEnd();

                    bool concatenate = false;
                    bool findName = true;
                    string itemName = "";

                    Console.WriteLine("-------------{0}'s blobs--------------", containerName);
                    for (int i = 0; i < responseXml.Length; i++)
                    {
                        if (findName && responseXml[i] == '<' && responseXml[i + 1] == 'N' && responseXml[i + 2] == 'a' && responseXml[i + 3] == 'm' && responseXml[i + 4] == 'e' && responseXml[i + 5] == '>')
                        {
                            concatenate = true;
                            findName = false;
                            i += 5;
                            continue;
                        }
                        if (concatenate && responseXml[i] != '<')
                            itemName += responseXml[i];
                        else if (concatenate)
                        {
                            Console.WriteLine(itemName);
                            itemName = "";
                            concatenate = false;
                            findName = true;
                        }
                    }
                    Console.WriteLine("-------------------------------------------");
                }
            }
        }
        public static string CreateAuthorizationHeader(string canonicalizedString)
        {
            string signature;
            using (var hmacSha256 = new HMACSHA256(Convert.FromBase64String(STORAGE_ACCOUNT_KEY)))
            {
                var dataToHmac = Encoding.UTF8.GetBytes(canonicalizedString);
                signature = Convert.ToBase64String(hmacSha256.ComputeHash(dataToHmac));
            }
            var authorizationHeader = String.Format(
                CultureInfo.InvariantCulture,
                "{0} {1}:{2}",
                "SharedKey",
                ACCOUNT_NAME,
                signature
            );
            return authorizationHeader;
        }
    }
}
