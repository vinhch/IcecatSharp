using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using IcecatSharp.Infrastructure;
using IcecatSharp.Models;

namespace IcecatSharp.Services.Product
{
    public class ProductService : BaseService
    {
        public ProductService(IceCatAccessConfig config) : base(config)
        {
        }

        public async Task<IceCatProduct> GetAsync(long productId)
        {
            var req = RequestEngine.CreateClient(_AccessConfig);

            var productXmlUrl = BuildXmlFileUrl($"{productId}.xml");

            var productXml = await RequestEngine.GetAsStringAsync(req, productXmlUrl);

            return CustomXmlParser.Parse<IceCatProduct>(productXml, "Product");
        }

        //public ICECATinterface GetToXdsClass(long productId)
        //{
        //    var req = RequestEngine.CreateClient(_AccessConfig);

        //    var productXmlUrl = BuildXmlFileUrl($"{productId}.xml");

        //    var productXml = RequestEngine.DownloadRequestToString(req, productXmlUrl);

        //    return CustomXmlParser.Parse<ICECATinterface>(productXml);
        //}
    }
}
