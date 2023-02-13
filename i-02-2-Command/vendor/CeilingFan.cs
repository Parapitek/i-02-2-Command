using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i_02_2_Command
{
    class CeilingFan
    {
        public static int HIGH = 3;
        public static int MEDIUM = 2;
        public static int LOW = 1;
        public static int OFF = 0;

        string location;
        int speed;

        public CeilingFan(string location)
        {
            this.location = location;
            speed = OFF;
        }

        public void high()
        {
            speed = HIGH;
            Console.WriteLine("Вентилятор в " + location + " на высокой скорости");
        }

        public void medium()
        {
            speed = MEDIUM;
            Console.WriteLine("Вентилятор в " + location + " на средней скорости");
        }

        public void low()
        {
            speed = LOW;
            Console.WriteLine("Вентилятор в " + location + " на низкой скорости");
        }

        public void off()
        {
            speed = OFF;
            Console.WriteLine("Вентилятор в " + location + " выключен");
        }

        public int getSpeed()
        {
            return speed;
        }
    }
}
