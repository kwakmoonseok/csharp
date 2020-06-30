using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_IsAs
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] objectArr = new object[] { 8, 9, 'c', null, 15.99, 745, true };
            Console.WriteLine(SumDoubleOnly(objectArr));
        }
        static double SumDoubleOnly(object[] obArr)
        {
            double temp = 0;
            foreach (object elements in obArr)
            {
                if (elements is double)
                    temp += (double)elements;
                
            }
            return temp;
        }
    }
}
