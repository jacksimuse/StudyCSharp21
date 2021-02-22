using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intConversionApp
{
    class ConvTest
    {
        static void Main(string[] args)
        {
            short shMaxVal = short.MaxValue;
            int inCastVal = 0;

            inCastVal = shMaxVal;
            Console.WriteLine($"short가 변환한 int 값은 {inCastVal}");

            inCastVal += 5; // 32767 + 5 = 32772
            short shCastVal = (short) inCastVal;
            Console.WriteLine($"int값 변환한 short값은 {shCastVal}"); // Overflow

            float flVal = 3.141592f; // f or F 써야함
            inCastVal = (int) flVal;
            Console.WriteLine($"float값 변환한 short값은 {inCastVal}");
            double dlVal = inCastVal; // 3
            Console.WriteLine($"int값 변환한 double값은 {dlVal}");

            object obj = 20; // Boxing
            int inUnboxingVal = (int) obj; // Unboxing
            Console.WriteLine($"int값 변환한 object값은 {inUnboxingVal}");

            string strVal = "200";
            int result = int.Parse(strVal) * 3; // 문자열을 숫자로 형변환
            Console.WriteLine($"200 * 3 = {result}");

        }
    }
}
