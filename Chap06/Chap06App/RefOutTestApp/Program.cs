using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 22, b = 3;
            int val = 0;
            int rem = 0;
            Divide(a, b,  out val, out rem); // 2. out(ref)을 적어서 밖에서 온거다 표시

            Console.WriteLine($"{a}, {b} : a/b = {val}, a%b = {rem}");

            bool isSucceed = int.TryParse("1000",  out int result);
            Console.WriteLine($"변환결과 {isSucceed}, result값 {result}");
        }


        static void Divide(int a, int b, out int quotient, out int reminder) // 1. out(ref)을 달아줘서 밖으로 내보낼거다 표시
        {
            quotient = a / b;
            reminder = a % b;
        }
    }
}
