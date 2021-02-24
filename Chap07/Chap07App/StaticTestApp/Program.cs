using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticTestApp
{
    class TestClass
    {
        public int number;
        public float fnum;

        public float ProcSomething()
        {
            Console.WriteLine($"{number}" +"먼가를 한다.");
            return 1.0f;
        }
        static void Main(string[] args)
        {
            TestClass aCls = new TestClass();
            
            aCls.number = 10;
            aCls.fnum = 3.25f;

            TestClass bCls = new TestClass();
            bCls.number = 10;
            bCls.fnum = 4.87f;

            aCls.ProcSomething();
            bCls.ProcSomething();



        }
    }
}
