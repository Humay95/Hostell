using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hostelapp
{
   static class Extensions
    {
        public static bool IsNotEmpty(string[] values,string CheckInput)
        {
            foreach(string a in values)
            {
                if( a==CheckInput)
                { return false; }
            }
            return true;
        }
        public static string hashMe (this string password)
        {
            byte[] byteArray = new ASCIIEncoding().GetBytes(password);
            byte[] hashArray = new SHA256Managed().ComputeHash(byteArray);
            String hashedPassword = new ASCIIEncoding().GetString(hashArray);

            return hashedPassword;
        }
        
    }
}
