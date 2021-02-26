using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewInheritTestApp
{
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{this.Name} : 멍멍!!!");
        }
        public void HowOld()
        {
            Console.WriteLine($"{this.Name}의 나이는 {this.Age}");
        }
    }
}
