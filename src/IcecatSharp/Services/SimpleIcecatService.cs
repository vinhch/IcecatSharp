using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IcecatSharp.Infrastructure;

namespace IcecatSharp.Services
{
    public class SimpleIcecatService : BaseService
    {
        public SimpleIcecatService(IceCatAccessConfig config) : base(config)
        {
        }

        public async Task<string> DownloadAsync(string xmlUrlPath, string saveFilePath = null)
        {
            var req = RequestEngine.CreateClient(_AccessConfig);

            if (string.IsNullOrEmpty(saveFilePath))
            {
                saveFilePath = _AccessConfig.DownloadDirectory + xmlUrlPath.Split('/').Last();
            }

            return await RequestEngine.DownloadFileAsync(req, xmlUrlPath, saveFilePath);
        }

        public async Task<string> DownloadAndExtractAsync(string xmlUrlPath, string saveFilePath = null)
        {
            var req = RequestEngine.CreateClient(_AccessConfig);

            var saveDirectoryPath = _AccessConfig.DownloadDirectory;
            if (!string.IsNullOrEmpty(saveFilePath))
            {
                saveDirectoryPath = Path.GetDirectoryName(saveFilePath);
            }

            var gzipFilePath = await RequestEngine.DownloadFileToDirectoryAsync(req, xmlUrlPath, saveDirectoryPath);
            var unzipFilePath = await GZipUtils.DecompressAsync(new FileInfo(gzipFilePath), saveFilePath);
            return unzipFilePath;
        }

        public async Task<string> GetAsync(string xmlUrlPath, string nodeName = null)
        {
            var req = RequestEngine.CreateClient(_AccessConfig);

            var xmlBody = await RequestEngine.GetAsStringAsync(req, xmlUrlPath);

            if (string.IsNullOrEmpty(nodeName)) return xmlBody;

            return await CustomXmlParser.ParseAsyc(nodeName, xmlBody);
        }
    }
}
