using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SERV
{
    public static class Cryptography
    {
        public static string CalculateHash(string input)
        {
            var md5 = new MD5CryptoServiceProvider();
            var md5data = md5.ComputeHash(Encoding.ASCII.GetBytes(input));
            return (new ASCIIEncoding()).GetString(md5data);
        }
    }
}
