using System.Threading.Tasks;
using Xunit;

namespace IcecatSharp.Tests
{
    [Trait("Category", "Product")]
    public class Product_Tests : IClassFixture<Product_Tests_Fixture>
    {
        private readonly Product_Tests_Fixture _fixture;

        public Product_Tests(Product_Tests_Fixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async Task Gets_Products()
        {
            const int productId = 61845;
            var obj = await _fixture.Service.GetAsync(productId);
            Assert.True(int.Parse(obj.ID) == productId);
        }
    }
}
