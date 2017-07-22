using System.Threading.Tasks;
using IcecatSharp.Services;
using Xunit;

namespace IcecatSharp.Tests
{
    public class SimpleIcecatService_Tests_Fixture : IAsyncLifetime
    {
        public SimpleIcecatService Service => new SimpleIcecatService(Utils.IceCatConfig);

        public async Task DisposeAsync()
        {
        }

        public async Task InitializeAsync()
        {
        }
    }
}