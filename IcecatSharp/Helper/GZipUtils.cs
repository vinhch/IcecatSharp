using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;

namespace IcecatSharp
{
    public static class GZipUtils
    {
        public static async Task<string> DecompressAsync(FileInfo fileToDecompress, string newFileName = null)
        {
            var currentFileName = fileToDecompress.FullName;
            if (string.IsNullOrEmpty(newFileName))
                newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

            using (var originalFileStream = fileToDecompress.OpenRead())
            using (var decompressedFileStream = File.Create(newFileName))
            using (var decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
            {
                await decompressionStream.CopyToAsync(decompressedFileStream);
                //Console.WriteLine("Decompressed: {0}", fileToDecompress.Name);
            }

            return newFileName;
        }
    }
}
