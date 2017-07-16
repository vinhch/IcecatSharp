using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace IcecatSharp.Infrastructure
{
    public static class RequestEngine
    {
        private static void CreateFolderIfNeeded(string path)
        {
            if (Directory.Exists(path)) return;
            Directory.CreateDirectory(path);
        }

        private static string GetValidFileName(string fileName)
        {
            return Path.GetInvalidFileNameChars().Aggregate(fileName, (current, c) => current.Replace(c.ToString(), string.Empty));
        }

        public static HttpClient CreateClient(IceCatAccessConfig config)
        {
            var authByteArray = Encoding.ASCII.GetBytes($"{config.Username}:{config.Password}");
            var authString = Convert.ToBase64String(authByteArray);

            var client = new HttpClient
            {
                BaseAddress = new Uri(config.BaseUrl)
            };
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authString);

            return client;
        }
    }
}
