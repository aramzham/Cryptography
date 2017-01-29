using System;

namespace AghasPasswordGenerator
{
    public class SimpleCoder
    {
        public string Code { get; }
        #region Constructors
        public SimpleCoder()
        {
            Code = GenerateCode();
        }
        public SimpleCoder(int length)
        {
            Code = GenerateCode(length);
        }
        #endregion
        public string GenerateCode(int length = 32)
        {
            var code = new char[length];
            var r = new Random();
            for (var i = 0; i < length; i++)
            {
                if (r.Next(0, 2) == 0) code[i] = (char)r.Next(48, 58);
                else code[i] = (char)r.Next(65, 71);
            }
            return new string(code);
        }
    }
}