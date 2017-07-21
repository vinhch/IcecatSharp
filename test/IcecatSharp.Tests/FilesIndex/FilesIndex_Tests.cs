using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IcecatSharp.Tests
{
    [Trait("Category", "FilesIndex")]
    public class FilesIndex_Tests : IClassFixture<FilesIndex_Tests_Fixture>
    {
        private readonly FilesIndex_Tests_Fixture _fixture;

        public FilesIndex_Tests(FilesIndex_Tests_Fixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async Task DownloadAndExtract_FilesIndex()
        {
            var filePath = await _fixture.Service.DownloadAndExtractAsync();
            Assert.True(File.Exists(filePath));
        }

        [Fact]
        public async Task List_FilesIndex()
        {
            var icecatFiles = _fixture.Service.List();
            var count = icecatFiles.Count();
            Assert.True(count > 0);
        }
    }
}
