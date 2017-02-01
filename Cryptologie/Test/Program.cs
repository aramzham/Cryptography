using System;
using System.Text;
using Cryptography;
using Originality;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region HMAC Demonstration
            //var originalMessage = "Original Message to hash";
            //var originalMessage2 = "This is another message to hash";
            //Console.WriteLine("HMAC Demonstration in .NET");
            //Console.WriteLine("--------------------------");
            //Console.WriteLine();
            //var key = HMAC.GenerateKey();
            //var hmacMd5Message =
            //HMAC.ComputeHMACMD5(Encoding.UTF8.GetBytes(originalMessage), key);
            //var hmacMd5Message2 =
            //HMAC.ComputeHMACMD5(Encoding.UTF8.GetBytes(originalMessage2), key);
            //var hmacSha1Message =
            //HMAC.ComputeHMACSHA1(Encoding.UTF8.GetBytes(originalMessage), key);
            //var hmacSha1Message2 =
            //HMAC.ComputeHMACSHA1(Encoding.UTF8.GetBytes(originalMessage2), key);
            //var hmacSha256Message =
            //HMAC.ComputeHMACSHA256(Encoding.UTF8.GetBytes(originalMessage), key);
            //var hmacSha256Message2 =
            //HMAC.ComputeHMACSHA256(Encoding.UTF8.GetBytes(originalMessage2), key);
            //var hmacSha512Message =
            //HMAC.ComputeHMACSHA512(Encoding.UTF8.GetBytes(originalMessage), key);
            //var hmacSha512Message2 =
            //HMAC.ComputeHMACSHA512(Encoding.UTF8.GetBytes(originalMessage2), key);
            //Console.WriteLine();
            //Console.WriteLine("MD5 HMAC");
            //Console.WriteLine();
            //Console.WriteLine("Message 1 hash = " +
            //Convert.ToBase64String(hmacMd5Message));
            //Console.WriteLine("Message 2 hash = " +
            //Convert.ToBase64String(hmacMd5Message2));
            //Console.WriteLine();
            //Console.WriteLine("SHA 1 HMAC");
            //Console.WriteLine();
            //Console.WriteLine("Message 1 hash = " +
            //Convert.ToBase64String(hmacSha1Message));
            //Console.WriteLine("Message 2 hash = " +
            //Convert.ToBase64String(hmacSha1Message2));
            //Console.WriteLine();
            //Console.WriteLine("SHA 256 HMAC");
            //Console.WriteLine();
            //Console.WriteLine("Message 1 hash = " +
            //Convert.ToBase64String(hmacSha256Message));
            //Console.WriteLine("Message 2 hash = " +
            //Convert.ToBase64String(hmacSha256Message2));
            //Console.WriteLine();
            //Console.WriteLine("SHA 512 HMAC");
            //Console.WriteLine();
            //Console.WriteLine("Message 1 hash = " +
            //Convert.ToBase64String(hmacSha512Message));
            //Console.WriteLine("Message 2 hash = " +
            //Convert.ToBase64String(hmacSha512Message2));
            //Console.WriteLine();

            //Console.ReadLine();
            #endregion

            #region DESEncryption Demonstration
            //var des = new DesEncryption();
            //var key = DesEncryption.GenerateRandomNumber(8);
            //var iv = DesEncryption.GenerateRandomNumber(8);
            //var original = "Text to encrypt";
            //var encrypted = des.Encrypt(Encoding.UTF8.GetBytes(original), key, iv);
            //var decrypted = des.Decrypt(encrypted, key, iv);
            //var decryptedMessage = Encoding.UTF8.GetString(decrypted);
            //Console.WriteLine("DES Encryption Demonstration in .NET");
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Original Text = " + original);
            //Console.WriteLine("Encrypted Text = " +
            //Convert.ToBase64String(encrypted));
            //Console.WriteLine("Decrypted Text = " + decryptedMessage);
            //Console.ReadLine();
            #endregion

            var fo = new FileOriginality();
            Console.WriteLine(fo.GetHMACSHA256(@"C:\Users\HP\Desktop\emails.txt"));

            Console.ReadKey();
        }
    }
}