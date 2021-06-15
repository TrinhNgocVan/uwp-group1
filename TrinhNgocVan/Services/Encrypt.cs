using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinhNgocVan.Services
{
    class Encrypt
    {
        public String EncryptString(String text)
        {
            
                return Convert.ToBase64String(System.Text.Encoding.Unicode.GetBytes(text));
           
        }
    }
}
