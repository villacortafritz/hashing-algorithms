using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    internal sealed class hashSHA512 : HashAlgorithm
    {
        public String ComputeHash(String filename)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                using (FileStream stream = File.OpenRead(filename))
                {
                    return BitConverter.ToString(sha512.ComputeHash(stream)).Replace("-", "").ToLower();
                }
            }
        }
    }
}
