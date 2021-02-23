using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap05App
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("수를 입력하세요 : ");
                string line = Console.ReadLine(); // 콘솔에서 입력값으로 변수할당

                if (line == "quit") break; // quit 입력하면 프로그램 종료

                int number = 0;
                int.TryParse(line, out number); // <- 에러가 0으로 처리되고 계속 진행됨 // int.Parse(line); <- 에러나면서 cmd종료창 뜸
                Console.WriteLine(number);
                if (number > 0)
                {
                    if (number % 2 == 0)
                        Console.WriteLine("0보다 큰 짝수");
                    else
                        Console.WriteLine("0보다 큰 홀수");
                }
                else
                {
                    Console.WriteLine("0보다 작은수");
                }
            }

            Console.WriteLine("계산종료!");
        }
    }
}
