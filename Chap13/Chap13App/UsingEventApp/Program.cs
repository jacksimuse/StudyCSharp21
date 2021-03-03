using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingEventApp
{
    class Program
    {
        //이벤트가 발생했을때 실행되는 메서드(이벤트 핸들러)
        public static void MyHandler(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("이벤트 사용!");
            CustomNoifier notifier = new CustomNoifier();
            notifier.SomethingHappened += new EventHandler(MyHandler); // 이벤트를 내가 만든 로직이 있는 메서드량 연결

            for (int i = 0; i <= 100; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}

