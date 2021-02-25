using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiInterfaceApp
{
    interface IRunnalbe // 자동차 종류
    {
        void Run();
    }

    interface IFlyable // 비행기 종류
    {
        void Fly();
    }
    class DroneCar : IRunnalbe, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("날아!");
        }
        public void Run()
        {
            Console.WriteLine("달려!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("드론카!");

            DroneCar dreamCar = new DroneCar();
            dreamCar.Run();
            dreamCar.Fly();

            Console.WriteLine("자동차로 변경(interface)");
            IRunnalbe car = dreamCar;
            car.Run();
            // car.Fly(); error

            Console.WriteLine("비행기로 변경(interface)");
            IFlyable plane = dreamCar;
            plane.Fly();
            // plane.Fly(); error
        }
    }
}
