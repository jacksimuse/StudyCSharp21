using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewInheritTestApp
{
    class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine($"{this.Name} 이/가 납니다!!");
        }
    }
}
