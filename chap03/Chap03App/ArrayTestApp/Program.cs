using System;

namespace ArrayTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("배열테스트");

            int[] arr = new int[10];
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] 값은 {arr[i]}");
            }
        }
    }
}
