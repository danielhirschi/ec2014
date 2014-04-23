using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCEG.ScoreboardPc.Business
{
    public static class HelperMethods
    {
        public static byte[] StringToByteArray(string str)
        {
            ASCIIEncoding enc = new ASCIIEncoding();
            return enc.GetBytes(str);
        }

        public static string ByteArrayToString(byte[] ba)
        {
            string hex = BitConverter.ToString(ba);
            return hex.Replace("-", "");
        }

        public static string ByteArrayToFormatedString(IEnumerable<byte> ba)
        {
            if (ba == null) return String.Empty;
            if (!ba.Any()) return String.Empty;
            return String.Join(" ", ba.Select(b => ByteArrayToString(new []{ b })));
        }

    }
}
