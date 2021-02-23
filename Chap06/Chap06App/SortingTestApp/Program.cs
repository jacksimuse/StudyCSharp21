using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 47, y = 5;
            Console.WriteLine($"Before Swap {x}, {y}");

            Program.Swap(ref x, ref y); // 정렬 기반 /  2. 주소에도 ref 걸어줘야됨

            Console.WriteLine($"After Swap {x}, {y}");
        }

        private static void Swap(ref int p1, ref int p2) // 1. ref -> reference 주소를 참조해서 복사해옴 = 주소값을 쓰겠다는말
        {
            int temp = p1; // temp = 47
            p1 = p2; // p1 = 5, p2 =5
            p2 = temp; // p2 = 47
        }
    }
}
