using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WSWHotelManagement
{
    class WSWsecurity
    {
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
