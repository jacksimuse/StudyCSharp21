using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstTestApp
{
    class Program
    {
        enum Season
        {
            봄,
            여름,
            가을,
            겨울
        }

        static void Main(string[] args)
        {
            Console.WriteLine("상수테스트");
            const double Pi = 3.141592;
            Console.WriteLine($"원주율의 값은 {Pi}");

            Season mySeason = (Season) 1; // = Season.여름; 
            Console.WriteLine($"지금 계절은 {mySeason}입니다.");

            int a = 0;
            Console.WriteLine($"a는 {a}");
            int? b = null;
            Console.WriteLine($"b는 {b}");
        }
    }
}
