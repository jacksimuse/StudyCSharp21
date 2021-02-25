using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTestApp
{
    class Parent
    {
        protected string Name;

        public Parent(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Parnet() 생성자");
        }

        public void ParentMethod()
        {
            // ...
            Console.WriteLine($"{this.Name}.ParentMethod() 실행");
        }

    }

    class Child : Parent
    {
        public string Color; // 색상
        public Child(string Name) : base(Name)
        {
            Console.WriteLine($"{this.Name}.Child() 생성자");
        }

        //~Child()
        //{
        //    Console.WriteLine($"{this.Name}.Parent() 소멸자");
        //}

        public void ChildMethod()
        {
            Console.WriteLine($"{this.Name}.ChilMethod() 실행");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Parent p = new Parent("부모");
            p.ParentMethod(); // 부모클래스 메서드 실행
            

            Child c = new Child("자식");
            c.Color = "황색";
            c.ParentMethod(); // 부모의 메서드 실행
            c.ChildMethod(); // 자식클래스 메서드 실행
        }
    }
}
