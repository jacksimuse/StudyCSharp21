using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] sources = {1,2,3,4,5,6,7,8,9,10};

            // for
            Console.WriteLine("For문");
            for (int i = 0; i < sources.Length; i++)
            {
                Console.WriteLine($"sources[{i}] = {sources[i]}");
            }
            // foreach
            Console.WriteLine("Foreach문");
            var idx = 0;
            foreach (var item in sources)
            {
                Console.WriteLine($"sources[{idx++}] = {item}");
            }
            foreach (var item in sources)
            {
                if (item % 3 == 0)
                {
                    Console.WriteLine($"3의 배수 {item}");
                }
                else
                    continue;
            }
        }
    }
}
