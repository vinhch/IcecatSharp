using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

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

        public static async Task<string> DownloadFileAsync(HttpClient client, string downloadUrl, string saveFilePath)
        {
            var saveDirectoryPath = Path.GetDirectoryName(saveFilePath);
            CreateFolderIfNeeded(saveDirectoryPath);

            var fileName = saveFilePath.Split('\\').Last().ToLower().Trim();
            fileName = GetValidFileName(fileName);

            var filePath = $"{saveDirectoryPath}\\{fileName}";

            using (var response = await client.GetAsync(downloadUrl, HttpCompletionOption.ResponseHeadersRead)
                .ConfigureAwait(false))
            {
                response.EnsureSuccessStatusCode();
                using (var contentStream = await response.Content.ReadAsStreamAsync())
                using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true))
                {
                    //Response.BufferOutput = false;   // to prevent buffering
                    //var totalRead = 0L;
                    //var totalReads = 0L;
                    var buffer = new byte[8192];
                    var isMoreToRead = true;

                    do
                    {
                        var read = await contentStream.ReadAsync(buffer, 0, buffer.Length);
                        if (read == 0)
                        {
                            isMoreToRead = false;
                        }
                        else
                        {
                            await fileStream.WriteAsync(buffer, 0, read);

                            //totalRead += read;
                            //totalReads += 1;
                            //if (totalReads % 2000 == 0)
                            //{
                            //    Console.WriteLine(string.Format("total bytes downloaded so far: {0:n0}", totalRead));
                            //}
                        }
                    }
                    while (isMoreToRead);
                }
            }

            return filePath;
        }

        public static Task<string> DownloadFileToDirectoryAsync(HttpClient client, string downloadUrl, string saveDirectoryPath)
        {
            var fileName = downloadUrl.Split('/').Last().ToLower().Trim();

            var filePath = $"{saveDirectoryPath}\\{fileName}";

            return DownloadFileAsync(client, downloadUrl, filePath);
        }

        public static async Task<byte[]> GetAsByteAsync(HttpClient client, string url)
        {
            using (var response = await client.GetAsync(url).ConfigureAwait(false))
            {
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsByteArrayAsync();
            }
        }

        public static async Task<string> GetAsStringAsync(HttpClient client, string url)
        {
            using (var response = await client.GetAsync(url).ConfigureAwait(false))
            {
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
