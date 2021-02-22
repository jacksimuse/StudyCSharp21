using System;

namespace IncDecTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("증감연산자 테스트");

            int result = 26;
            Console.WriteLine($"현재 숫자는 {result}"); // 26
            result += 3;
            Console.WriteLine($"현재 숫자는 {result}"); // 29
            result -= 10;
            Console.WriteLine($"현재 숫자는 {result}"); // 19

            Console.WriteLine($"현재 숫자는 {result++}"); // 19 출력을 하고 나서 1을 더함
            Console.WriteLine($"현재 숫자는 {++result}"); // 21 앞에 계산을 받고 1을 더해서  출력
        }
    }
}
