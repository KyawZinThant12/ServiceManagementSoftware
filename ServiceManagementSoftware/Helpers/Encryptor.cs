using System.Security.Cryptography;
using System.Text;
using System.Linq;

namespace ServiceManagementSoftware.Helpers
{
    public static class Encryptor
    {
        public static string Encrypt(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            md5.ComputeHash(Encoding.ASCII.GetBytes(text));

            byte[] result = md5.Hash;

            return result.Aggregate<byte, string>(null, (current, b) => current + b.ToString("x2"));
        }
    }
}
