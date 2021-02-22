using System;

namespace VariableTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int v1 = 30, v2 = 40;
             int result = v1 + v2;
             Console.WriteLineLine("결과는 " + result);*/
            // byte형
            sbyte sbMinVal = sbyte.MinValue, sbMaxVal = sbyte.MaxValue;
            Console.WriteLine($"sbyte 최소, 최대값은 {sbMinVal}, {sbMaxVal} 입니다.");
            byte bMinVal = byte.MinValue, bmaxVal = byte.MaxValue;
            Console.WriteLine($"byte 최소, 최대값은 {bMinVal}, {bmaxVal} 입니다.");
            // short형
            short shMinVal = short.MinValue, shMaxVal = short.MaxValue;
            Console.WriteLine($"short 최소, 최대값은 {shMinVal}, {shMaxVal} 입니다.");
            ushort usMinVal = ushort.MinValue, usMaxVal = ushort.MaxValue;
            Console.WriteLine($"ushort 최소, 최대값은 {usMinVal}, {usMaxVal} 입니다.");
            // int형
            int inMinVal = int.MinValue, inMaxVal = int.MaxValue;
            Console.WriteLine($"int 최소, 최대값은 {inMinVal}, {inMaxVal} 입니다.");
            uint uinMinVal = uint.MinValue, uiMaxVal = uint.MaxValue;
            Console.WriteLine($"uint 최소, 최대값은 {uinMinVal}, {uiMaxVal} 입니다.");
            // long형
            long lnMinVal = long.MinValue, lnMaxVal = long.MaxValue;
            Console.WriteLine($"long 최소, 최대값은 {lnMinVal}, {lnMaxVal} 입니다.");
            ulong ulnMinVal = ulong.MinValue, ulnMaxVal = ulong.MaxValue;
            Console.WriteLine($"ulong 최소, 최대값은 {ulnMinVal}, {ulnMaxVal} 입니다.");

            // float형
            float fMinVal = float.MinValue, fMaxVal = float.MaxValue;
            Console.WriteLine($"float 최소, 최대값은 {fMinVal}, {fMaxVal} 입니다.");
            // double형
            double dMinVal = double.MinValue, dMaxVal = double.MaxValue;
            Console.WriteLine($"double 최소, 최대값은 {dMinVal}, {dMaxVal} 입니다.");
            // decimal형
            decimal dcMinVal = decimal.MinValue, dcMaxVal = decimal.MaxValue;
            Console.WriteLine($"decimal 최소, 최대값은 {dcMinVal}, {dcMaxVal} 입니다.");
        }
    }
}
