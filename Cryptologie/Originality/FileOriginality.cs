using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

namespace Originality
{
    public class FileOriginality
    {
        private byte[] ComputeSHA256(byte[] toBeHashed)
        {
            using (var sha256 = SHA256.Create())
            {
                try
                {
                    return sha256.ComputeHash(toBeHashed);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    return new byte[] { };
                }
            }
        }

        public string GetSHA256(string path)
        {
            var fileBytes = File.ReadAllBytes(path);
            var hashBytes = ComputeSHA256(fileBytes);
            return Convert.ToBase64String(hashBytes);
        }

        public bool IsOriginal(string path)
        {
            var entryHash = GetSHA256(path);

            Thread.Sleep(10000); // some heavy work for 10 seconds

            var finalHash = GetSHA256(path);

            return entryHash.Equals(finalHash, StringComparison.Ordinal);
        }
    }
}
