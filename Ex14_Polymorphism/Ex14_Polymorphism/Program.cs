using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_Polymorphism
{
    class Program
    {
        interface Lamp
        {
            void TurnOn();
            void TurnOff();
        }
        class Incandescent_Lamp : Lamp
        {
            public void TurnOn()
            {
                Console.WriteLine("백열등 켜짐");
            }
            public void TurnOff()
            {
                Console.WriteLine("백열등 꺼짐");
            }
        }
        class Fluorescent_Lamp : Lamp
        {
            public void TurnOn()
            {
                Console.WriteLine("형광등 켜짐");
            }
            public void TurnOff()
            {
                Console.WriteLine("형광등 꺼짐");
            }
        }
        class LED_Lamp : Lamp
        {
            public void TurnOn()
            {
                Console.WriteLine("LED등 켜짐");
            }
            public void TurnOff()
            {
                Console.WriteLine("LED등 꺼짐");
            }
        }
        class TableLamp
        {
            private Lamp light;

            public void InstallLight(Lamp light)
            {
                this.light = light;
            }
            public void On()
            {
                if (light != null)
                    light.TurnOn();
                else
                    Console.WriteLine("전구가 없습니다.");
            }
            public void Off()
            {
                if (light != null)
                    light.TurnOff();
                else
                    Console.WriteLine("전구가 없습니다.");
            }
        }
        static void Main(string[] args)
        {
            var stand = new TableLamp();
            var light1 = new Incandescent_Lamp();
            var light2 = new Fluorescent_Lamp();
            var light3 = new LED_Lamp();

            stand.InstallLight(light1);
            stand.On();
            stand.Off();

            stand.InstallLight(light2);
            stand.On();
            stand.Off();

            stand.InstallLight(light3);
            stand.On();
            stand.Off();
        }
    }
}
