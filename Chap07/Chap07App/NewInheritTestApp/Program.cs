using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewInheritTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("동물 클래스 상속");

            Animal animal = new Animal();

            animal.Age = 30;
            animal.Name = "개미";
            animal.Breath();

            Dog dog = new Dog();

            dog.Name = "개미";
            dog.Age = 5000;
            dog.HowOld();
            dog.Bark();

            Bird bird = new Bird();

            bird.Name = "꿍이";
            bird.Age = 10000000; // bird에는 Age에 대한걸 입력 안해서 출력 안됨
            bird.Fly();
        }
    }
    
}
