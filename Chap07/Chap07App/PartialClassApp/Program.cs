using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassApp
{
    partial class MyClass
    {
        public void Method3() { Console.WriteLine("Method3"); }
        public void Method4() { Console.WriteLine("Method4"); }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass _class = new MyClass();
            _class.Method1();
            _class.Method2();
            _class.Method3();
            _class.Method4();
        }
    }
}
