using System;

namespace DelegateChainApp
{
    delegate void AllCalc(int x, int y); // 대리자 선언
    class Program
    {
        static void Plus(int a, int b) { Console.WriteLine($"a + b = {a + b }"); }
        static void Minus(int a, int b) { Console.WriteLine($"a - b = {a - b }"); }
        static void Multiple(int a, int b) { Console.WriteLine($"a * b = {a * b }"); }
        static void Divide(int a, int b) { Console.WriteLine($"a / b = {a / b }"); }


        static void Main(string[] args)
        {
            Console.WriteLine("Calculating!!");
            AllCalc allCalc = Plus;
            allCalc += Minus;
            allCalc += Multiple;
            allCalc += Divide;


            allCalc(10, 5);
        }
    }
}
