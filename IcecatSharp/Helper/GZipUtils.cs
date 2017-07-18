using System.IO;
using System.IO.Compression;

namespace IcecatSharp
{
    public static class GZipUtils
    {
        public static string Decompress(FileInfo fileToDecompress, string newFileName = null)
        {
            var currentFileName = fileToDecompress.FullName;
            if (string.IsNullOrEmpty(newFileName))
                newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

            using (FileStream originalFileStream = fileToDecompress.OpenRead())
            using (FileStream decompressedFileStream = File.Create(newFileName))
            using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
            {
                decompressionStream.CopyTo(decompressedFileStream);
                //Console.WriteLine("Decompressed: {0}", fileToDecompress.Name);
            }

            return newFileName;
        }
    }
}
