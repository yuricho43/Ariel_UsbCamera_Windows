using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSystem
{
    public class SupportEtc
    {

        //=== binary data를 string으로 변환하는 함수
        //    example : byte[4] = 03 3E 34  27
        //             ==> string "03 3E 34 27"
        public string ConvertHexArrayToString(byte[] data, int len)
        {
            byte[] byteArray = new byte[len];
            Buffer.BlockCopy(data, 0, byteArray, 0, len);

            string strResult = System.BitConverter.ToString(byteArray);
            strResult = strResult.Replace("-", " ");
            return strResult;
        }

        public string ConvertHexArrayToString2(byte[] data, int offset, int len)
        {
            byte[] byteArray = new byte[len];
            Buffer.BlockCopy(data, offset, byteArray, 0, len);

            string strResult = System.BitConverter.ToString(byteArray);
            strResult = strResult.Replace("-", " ");
            return strResult;
        }

        //=== hex sring을 byte array로 변환하는 함수
        //    example : string "03 3E 34 27"
        //              byte[4] = 03 3E 34  27

        public static byte[] ConvertHexStringToByteArray2(string hexString)
        {
            byte[] StrByte = Encoding.UTF8.GetBytes(hexString);

            return StrByte;
        }


        //--- ConvertHexArrayToString와 유사.
        //    ConvertHexArrayToString : binary array를 string으로 변환. length 제공 (00도 포함할 수 있다)
        //    ConvertHexStringToAsciiString : ascii값을 가지고 있는 char array를 string으로 변환. length 제공 필요없음.  
        public static string ConvertHexStringToAsciiString(string hexString)
        {
            string strSum = "";
            string strData;
            byte[] StrByte = Encoding.UTF8.GetBytes(hexString);

            for (int i = 0; i < hexString.Length; i++)
            {
                strData = string.Format("{0:X2}", StrByte[i]);
                strSum += strData;
            }
            return strSum;
        }
    }
}
