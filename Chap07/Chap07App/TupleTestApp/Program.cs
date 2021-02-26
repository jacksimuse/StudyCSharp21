using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuple = (1, "성명건", "010-6683-7732", "부산시 해운대구", true);
            var tuple2 = (Idx: 2, Name: "홍길동", Phone: "010-9999-9999", Address: "경남 창원시 의창구", Marrige: false);

            Console.WriteLine($"{tuple.Item1} / {tuple.Item2} / {tuple.Item3} /{tuple.Item4} /{tuple.Item5} /");
            Console.WriteLine($"{tuple2.Item1} / {tuple2.Item2} / {tuple2.Item3} /{tuple2.Item4} /{tuple2.Item5} /");

            tuple2.Address = "우리집";
            Console.WriteLine($"{tuple2.Item1} / {tuple2.Item2} / {tuple2.Item3} /{tuple2.Item4} /{tuple2.Item5} /"); // 튜플 수정가능
        }
    }
}
