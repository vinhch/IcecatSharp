using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using IcecatSharp.Services.Product;
using Xunit;

namespace IcecatSharp.Tests
{
    public class Product_Tests_Fixture : IAsyncLifetime
    {
        public ProductService Service => new ProductService(Utils.IceCatConfig);

        public async Task DisposeAsync()
        {
        }

        public async Task InitializeAsync()
        {
        }
    }
}
