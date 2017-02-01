using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Originality
{
    public class FileOriginality
    {
        private byte[] ComputeHMACSHA256(byte[] toBeHashed)
        {
            using (var hmac = new HMACSHA256())
            {
                try
                {
                    return hmac.ComputeHash(toBeHashed);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    return new byte[] {};
                }
            }
        }

        public string GetHMACSHA256(string path)
        {
            var fileBytes = File.ReadAllBytes(path);
            var hashBytes = ComputeHMACSHA256(fileBytes);
            return Convert.ToBase64String(hashBytes);
        }
    }
}
