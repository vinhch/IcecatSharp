using System.IO;

namespace IcecatSharp.Infrastructure
{
    public class IceCatAccessConfig
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string BaseUrl { get; set; } = "http://data.icecat.biz/export/freexml/";
        public string Language { get; set; }
        public string DownloadDirectory { get; set; } = $"{Directory.GetCurrentDirectory()}\\download";
    }
}
