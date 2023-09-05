using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType_Conversion
{
    static internal class Program
    {
        static void Main(string[] args)
        {
            double doubleNum = 9999.999;
            float floatNum = 999.9F;
            decimal decimalNum = 1234.5678M;
            long longInt = -12345678; // Int64 (64-bit)
            ulong ulongInt = 12345678; //Uint64
            int intNum = -786; // Int 32
            uint uintNum = 786; //UInt32
            short shortInt = -789; // Int 16
            ushort uShortInt = 456; // UInt 16
            byte byteNum = 254; // 8-bit usigned
            sbyte sbyteNum = -123; // 8-bit signed

            // can go from big bit to small int, not other way arounf
            longInt = shortInt;
            uintNum = byteNum;

            // explicit casting
            // only get the smaller numbers of short int for byte
            byteNum = (byte)shortInt;

            try
            {
                byteNum = checked((byte)shortInt);
                byteNum = Convert.ToByte(shortInt);
            }
            catch
            {
                // output message that data will be lost
            }






        }
    }
}
