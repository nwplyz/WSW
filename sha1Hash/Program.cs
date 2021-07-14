using System;
using System.Security.Cryptography;
using System.Text;


namespace sha1Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Text to encrypt");
               string input = Console.ReadLine();
                Console.WriteLine(hashPassword(input));
            }
        }

        public static string hashPassword(string password)
        {
            using (SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = sha1.ComputeHash(utf8.GetBytes(password));
                return Convert.ToBase64String(data);


            }
        }

    }
}
