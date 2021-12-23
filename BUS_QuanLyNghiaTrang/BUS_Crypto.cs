using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLyNghiaTrang;

namespace BUS_QuanLyNghiaTrang
{
    public class BUS_Crypto
    {
        DAL_Crypto dalCrypto = new DAL_Crypto();

        public string Encrypt(string text)
        {
            return dalCrypto.Encrypt(text);
        }

        public string Decrypt(string cipher)
        {
            return dalCrypto.Decrypt(cipher);
        }
    }
}
