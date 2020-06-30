using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_Class_IsAs
{
    class Program
    {
        class Mammal
        {
            protected string name;
            public Mammal(string name)
            {
                this.name = name;
                Console.WriteLine($"생성자 호출 : {name}.Mammal()");
            }
            public string GetName()
            {
                return name;
            }
            public void WashMammal()
            {
                Console.WriteLine($"{GetName()}가 씻는다.");
            }
            
        }
        class Dog : Mammal
        {
            public Dog(string name) : base(name)
            {
                Console.WriteLine($"생성자 호출 : {name}.Dog()");
            }
            public void bark()
            {
                Console.WriteLine("멍멍이가 멍멍 짖는다.");
            }
        }
        class Cat : Mammal
        {
            public Cat(string name) : base(name)
            {
                Console.WriteLine($"생성자 호출 : {name}.Cat()");
            }
            public void Meow()
            {
                Console.WriteLine("야옹이가 야옹야옹 운다.");
            }
        }
        static void Main(string[] args)
        {
            Mammal m1 = new Dog("멍멍이");
            Mammal m2 = new Cat("야옹이");

            Dog d1 = (Dog)m1;
            Cat c1 = (Cat)m2;

            d1.bark();
            c1.Meow();

            Mammal m3 = new Dog("댕댕이");
            Mammal m4 = new Cat("야옹이");

            m3.WashMammal();
            m4.WashMammal();
        }
    }
}
