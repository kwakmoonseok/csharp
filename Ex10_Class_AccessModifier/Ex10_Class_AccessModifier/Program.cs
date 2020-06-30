using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_Class_AccessModifier
{
    class Program
    {
        class WaterHeater
        {
            private int temperature;
            public string SetTemperature(int temp)
            {
                if (temp > 50 || temp < 0)
                    return "온도가 " + temp + "도로 정상 범위를 벗어남.";
                temperature = temp;
                return "온도가 " + temperature.ToString() + "도로 설정됨.";
            }
            public int GetTemperature()
            {
                return temperature;
            }

        }
        static void Main(string[] args)
        {
            WaterHeater heater = new WaterHeater();
            Console.WriteLine($"현재 온도는 {heater.GetTemperature()}도 입니다.");
            Console.WriteLine(heater.SetTemperature(20));
            Console.WriteLine(heater.SetTemperature(200));
            Console.WriteLine($"현재 온도는 {heater.GetTemperature()}도 입니다.");
        }
    }
}
