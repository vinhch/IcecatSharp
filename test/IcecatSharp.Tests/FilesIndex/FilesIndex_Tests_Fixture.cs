using System.Threading.Tasks;
using IcecatSharp.Services;
using Xunit;

namespace IcecatSharp.Tests
{
    public class FilesIndex_Tests_Fixture : IAsyncLifetime
    {
        public FilesIndexService Service => new FilesIndexService(Utils.IceCatConfig);

        public async Task InitializeAsync()
        {
        }

        public async Task DisposeAsync()
        {
        }
    }
}
