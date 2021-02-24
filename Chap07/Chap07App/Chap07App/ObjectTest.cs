using System;

namespace Chap07App
{
    class ObjectTest
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("객체 사용");

            //Cat cat1 = new Cat(Name: "야옹이", Color: "흰색");
            //cat1.Name = "야옹이";
            //cat1.Color = "흰색";
            //cat1.Meow();

            //Cat kitty = new Cat();
            //kitty.Name = "키티";
            //kitty.Color = "하얀색";
            //kitty.Meow();

            //Cat nero = new Cat();
            //nero.Name = "검은고양이 네로";
            //nero.Color = "검은색";
            //nero.Meow();

            Cat yomi = new Cat("요미", "흰색", "암컷");
            yomi.Meow();


        }
    }

    class Cat
    {
        public Cat() { }

        public Cat(string Name)
        {
        
        }

        public Cat(string Name, string Color) 
        {
            this.Name = Name;
            this.Color = Color;
        }

        public Cat(string Name, string Color, string Gender) : this(Name, Color)
        {
            this.Gender = Gender;
        }

        public string Name; // 이름 
        public string Color; // 색상
        public string Gender; // 성별

        public void Meow()
        {
            Console.WriteLine($"{this.Name}(색상{this.Color} / 성별{this.Gender}) : 야옹!");
        }
    }
}
