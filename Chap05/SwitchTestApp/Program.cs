using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string day = "화요일";

            //    if (day == "월요일")
            //    {
            //        Console.WriteLine("월요일입니다.");
            //    }
            //    else if (day == "화요일") 
            //    {
            //        Console.WriteLine("화요일입니다.");
            //    }
            //     else if (day == "수요일") 
            //    {
            //        Console.WriteLine("수요일입니다.");
            //    }
            //     else if (day == "목요일") 
            //    {
            //        Console.WriteLine("목요일입니다.");
            //    }
            //     else if (day == "금요일") 
            //    {
            //        Console.WriteLine("금요일입니다.");
            //    }
            //     else if (day == "토요일") 
            //    {
            //        Console.WriteLine("토요일입니다.");
            //    }
            //     else if (day == "일요일") 
            //    {
            //        Console.WriteLine("일요일입니다.");
            //    }
            //    else
            //        Console.WriteLine("요일이 아닙니다.");
            //}

            while (true)
            {
                Console.WriteLine("요일을 입력하세요 : ");
                string line = Console.ReadLine();

                switch (line)
                {
                    case "월요일":
                        Console.WriteLine("월요일입니다");
                        break;
                    case "화요일":
                        Console.WriteLine("화요일입니다");
                        break;
                    case "수요일":
                        Console.WriteLine("수요일입니다");
                        break;
                    case "목요일":
                        Console.WriteLine("목요일입니다");
                        break;
                    case "금요일":
                        Console.WriteLine("금요일입니다");
                        break;
                    case "토요일":
                        Console.WriteLine("토요일입니다");
                        break;
                    case "일요일":
                        Console.WriteLine("일요일입니다");
                        break;
                    default:
                        Console.WriteLine("요일이 아닙니다.");
                        break;

                }
            }
        }
    }
}
