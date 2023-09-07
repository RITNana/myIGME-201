using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType_Conversion
{
    static internal partial class Program
    {

        static int MyAdder(int a, int b)
        {
            return 1;
        }

        static double MyAdder(double a, double b)
        {
            return 1;
        }
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

                byteNum = byte.Parse(shortInt.ToString());
                bool bValid = byte.TryParse(shortInt.ToString(), out byteNum);
            }
            catch
            {

                // output message that data will be lost
                Console.Write("Data was lost!");
            }

            // int / int = int
            doubleNum =  (double)longInt / shortInt; // answer will be int 

            shortInt = (short)3.94; // shortInt = 3
            MyAdder(shortInt, shortInt);
            MyAdder(doubleNum, shortInt);
            MyDivider(byteNum, shortInt);





        }
    }
}
