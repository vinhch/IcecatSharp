using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using IcecatSharp.Infrastructure;
using IcecatSharp.Models;

namespace IcecatSharp.Services
{
    public class DailyIndexService : BaseService
    {
        public DailyIndexService(IceCatAccessConfig config) : base(config)
        {
            XmlFileName = "daily.index.xml.gz";
        }

        public async Task<string> DownloadAndExtractAsync()
        {
            var req = RequestEngine.CreateClient(_AccessConfig);

            var gzipFilePath = await RequestEngine.DownloadFileToDirectoryAsync(req, XmlFileUrl, _AccessConfig.DownloadDirectory);

            var unzipFilePath = await GZipUtils.DecompressAsync(new FileInfo(gzipFilePath));

            return unzipFilePath;
        }

        public IEnumerable<IceCatFile> List()
        {
            return CustomXmlParser.ParseFileToList<IceCatFile>(XmlFilePath, "file");
        }
    }
}
