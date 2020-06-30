using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_Class_thisConstructor
{
    class Program
    {
        class Class1
        {
            int a = 1, b = 0, c = 0;
            public Class1() {

            }

            public Class1(int b)
            {
                this.b = b;
            }

            public Class1(int b, int c) : this(b)
            {
                this.c = c;
            }

            public void printField()
            {
                Console.WriteLine("a :" + a + " b : " + b + " c : " + c);
            }
        }
        static void Main(string[] args)
        {
            Class1 Class1 = new Class1();
            Console.WriteLine("Class1() 호출");
            Class1.printField();

            Class1 Class2 = new Class1(2);
            Console.WriteLine("Class1(2) 호출");
            Class2.printField();

            Class1 Class3 = new Class1(2, 3);
            Console.WriteLine("Class1(2, 3) 호출");
            Class3.printField();
        }
    }
}
