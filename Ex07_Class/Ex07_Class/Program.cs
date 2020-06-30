using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube Cube1 = new Cube(1, 2, 3);
            
            Console.WriteLine("Cube 객체가 생성된 횟수 : " + Cube.countOfInstance);
            Console.WriteLine("Cube1의 부피 : " + Cube1.GetVolume());

            Cube Cube2 = new Cube(4, 5, 6);

            Console.WriteLine("Cube 객체가 생성된 횟수 : " + Cube.countOfInstance);
            Console.WriteLine("Cube2의 부피 : " + Cube2.GetVolume());
        }
    }
    class Cube
    {
        int x, y, z;
        public static int countOfInstance;

        public Cube(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            Cube.countOfInstance++;
        }
        public int GetVolume()
        {
            return x * y * z;
        }
    }
}
