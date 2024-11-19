using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertingStringToNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textAge = "23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string textBigNumber = "-90000000L";
            long BigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(BigNumber);

            string textNegative = "-55,2";
            double Negative = Convert.ToDouble(textNegative);
            Console.WriteLine(Negative);

            string textPrecision = "5,000001f";
            float Precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(Precision);

            string textMoney = "14,99M";
            decimal Money = Convert.ToDecimal(textMoney);
            Console.WriteLine(Money); 


        }
    }
}
