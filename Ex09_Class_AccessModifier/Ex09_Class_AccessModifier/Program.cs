using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_Class_AccessModifier
{
    class Program
    {
        class A
        {
            public int value1 = 10;
            private int value2 = 20;
            protected int value3 = 30;

            public int Getvalue2()
            {
                return value2;
            }
            public class C : A
            {
                public int Getvalue3()
                {
                    return value3;
                }
            }
        }

        class B : A
        {
            public int Getvalue1()
            {
                return value1;
            }
        }
       
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            var c = new A.C();
            Console.WriteLine("a.value1 : " + a.value1);

            Console.WriteLine("b.value1 : " + b.value1);
            Console.WriteLine("b.value2 : " + b.Getvalue2()); // or b.Getvalue2(), c.Getvalue2()

            Console.WriteLine("c.value3 : " + c.Getvalue3());
        }
    }
}
