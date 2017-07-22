using System.Net.Http;
using IcecatSharp.Infrastructure;

namespace IcecatSharp.Services
{
    public abstract class BaseService
    {
        protected BaseService(IceCatAccessConfig config)
        {
            _AccessConfig = config;
            _Client = RequestEngine.CreateClient(config);

        }
        protected bool IsRefsXmlService { get; set; } = false;
        protected IceCatAccessConfig _AccessConfig { get; set; }
        protected HttpClient _Client { get; set; }
        protected string XmlFileName { get; set; }
        protected string XmlFileUrl => BuildXmlFileUrl(XmlFileName);

        protected virtual string XmlFilePath
        {
            get
            {
                var xmlFileName = XmlFileName.Contains(".gz")
                    ? XmlFileName.Replace(".gz", string.Empty)
                    : XmlFileName;

                return $"{_AccessConfig.DownloadDirectory}\\{xmlFileName}";
            }
        }
        protected virtual string BuildXmlFileUrl(string xmlFileName)
        {
            var language = string.Empty;

            if (IsRefsXmlService)
                language = "refs/";
            else if (!string.IsNullOrEmpty(_AccessConfig.Language))
                language = $"{_AccessConfig.Language}/";

            return $"{_AccessConfig.BaseUrl}{language}{xmlFileName}";
        }
    }
}
