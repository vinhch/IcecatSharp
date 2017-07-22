using System.Threading.Tasks;
using Xunit;

namespace IcecatSharp.Tests
{
    public class SimpleIcecatService_Tests : IClassFixture<SimpleIcecatService_Tests_Fixture>
    {
        private readonly SimpleIcecatService_Tests_Fixture _fixture;

        public SimpleIcecatService_Tests(SimpleIcecatService_Tests_Fixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async Task Gets_An_XML()
        {
            const string xmlUrl = "http://data.icecat.biz/export/freexml/INT/61845.xml";
            var content = await _fixture.Service.GetAsync(xmlUrl);
            var contentWithNode = await _fixture.Service.GetAsync(xmlUrl, "Product");
            Assert.True(!string.IsNullOrEmpty(content) && !string.IsNullOrEmpty(contentWithNode));
        }
    }
}
