using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideTestApp
{
    class ArmorSuite
    {
        // 자식클래스에서 재정의할거야
        public virtual void Initialize()
        {
            Console.WriteLine("ArmorSuite 초기화!");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("리펄서 레이저 초기화!");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            //base.Initialize();
            Console.WriteLine("ArmorSuite개량 Warmachine 초기화!");
            Console.WriteLine("Double-Barrel 캐논 장착!");
            Console.WriteLine("Micro-Rocket 런처 장착!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArmorSuit 생산");
            ArmorSuite suite = new ArmorSuite();
            suite.Initialize();

            Console.WriteLine("WarMachine 생산");
            WarMachine machine = new WarMachine();
            machine.Initialize();

            Console.WriteLine("IronMan 생산!");
            IronMan ironMan = new IronMan();
            ironMan.Initialize();
        }
    }
}
